using RatingRequirements.Core.Interface.Service;
using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingRequirements.UI
{
    /// <summary>
    /// Форма редактирования документа.
    /// </summary>
    public partial class EditDocumentForm : Form
    {
        /// <summary>
        /// Идентификатор документа.
        /// </summary>
        private Guid _documentId;

        /// <summary>
        /// Идентификатор реестра.
        /// </summary>
        private Guid _registerId;

        /// <summary>
        /// Идентификатор показателя.
        /// </summary>
        private Guid _indicatorId;

        /// <summary>
        /// Показатель.
        /// </summary>
        private Indicator _indicator;

        #region Сервисы
        
        private readonly IIndicatorService _indicatorService;
        private readonly IIndicatorTypeService _indicatorTypeService;
        private readonly IDocumentService _documentService;

        #endregion

        public EditDocumentForm(
            Guid documentId,
            Guid indicatorId,
            Guid registerId,
            IIndicatorService indicatorService,
            IIndicatorTypeService indicatorTypeService,
            IDocumentService documentService)
        {
            InitializeComponent();

            _documentId = documentId;
            _registerId = registerId;
            _indicatorId = indicatorId;
            
            _indicatorTypeService = indicatorTypeService;
            _indicatorService = indicatorService;
            _documentService = documentService;

            _indicator = _indicatorService.GetIndicatorById(_indicatorId);
        }

        #region Обработка событий

        /// <summary>
        /// При загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                var isEdit = _documentId != Guid.Empty;
                ShowParameters();

                var indicatorType = _indicatorTypeService.GetIndicatorTypeById(_indicator.IndicatorTypeId);

                tbIndicator.Text = _indicator.Name;
                tbIndicatorType.Text = indicatorType.Name;
                tbIndicatorFormula.Text = _indicator.FormulaBase;

                if (isEdit)
                {
                    var document = _documentService.GetDocumentById(_documentId);
                    tbDocumentName.Text = document.Name;
                    tbFileName.Text = document.FileName;
                    tbDocumentFormula.Text = document.Formula;
                    tbPoints.Text = document.Points;

                    Text = $"Редактирование документа \"{document.Name}\"";
                }
                else
                {
                    RecalcFormula();

                    Text = "Новый документ";
                }

                ShowParameters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрыть форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Пересчитать формулу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecalcFormula(object sender = null, EventArgs e = null)
        {
            var formulaBase = _indicator.FormulaBase;

            // Если формулы нет - галочка, пересчитывать ничего не надо
            if (string.IsNullOrEmpty(formulaBase))
            {
                tbDocumentFormula.Text = null;
                tbPoints.Text = cbIsExecuted.Checked ? "+" : "-";
            }
            else
            {
                List<double> formulaParams = new List<double>();
                if (_indicator.ParamsCount > 0)
                {
                    formulaParams.Add((double)numParam1.Value);
                }
                if (_indicator.ParamsCount > 1)
                {
                    formulaParams.Add((double)numParam2.Value);
                }
                if (_indicator.ParamsCount > 2)
                {
                    formulaParams.Add((double)numParam3.Value);
                }

                tbDocumentFormula.Text = string.Format(formulaBase, formulaParams.Select(p => p.ToString()).ToArray());
                tbPoints.Text = string.IsNullOrEmpty(Formula.Check(_indicator.Name, formulaParams))
                    ? Formula.Calculate(tbDocumentFormula.Text, formulaParams)
                    : null;
            }
        }

        /// <summary>
        /// Валидация сохранения.
        /// </summary>
        private void ValidateSave()
        {
            List<double> formulaParams = new List<double>();
            if (_indicator.ParamsCount > 0)
            {
                formulaParams.Add((double)numParam1.Value);
            }
            if (_indicator.ParamsCount > 1)
            {
                formulaParams.Add((double)numParam2.Value);
            }
            if (_indicator.ParamsCount > 2)
            {
                formulaParams.Add((double)numParam3.Value);
            }

            var error = Formula.Check(_indicator.Name, formulaParams);
            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }
        }

        /// <summary>
        /// Сохранение документа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSave();

                var document = new Document
                {
                    DocumentId = _documentId,
                    FileName = tbFileName.Text,
                    Name = tbDocumentName.Text,
                    Formula = tbDocumentFormula.Text,
                    IndicatorId = _indicatorId,
                    Points = tbPoints.Text,
                    RegisterId = _registerId
                };
                _documentId = _documentService.SaveDocument(document);

                // Перезагрузить форму после сохранения
                Form_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Показать параметры.
        /// </summary>
        private void ShowParameters()
        {
            // Если формулы нет, показываем галочку
            if (string.IsNullOrEmpty(_indicator.FormulaBase))
            {
                numParam1.Visible = numParam2.Visible = numParam3.Visible =
                    lblParam1.Visible = lblParam2.Visible = lblParam3.Visible = false;
                cbIsExecuted.Visible = true;
            }
            else
            {
                // Если формула есть, скрываем галочку, отображаем параметры
                cbIsExecuted.Visible = false;

                numParam1.Visible = numParam2.Visible = numParam3.Visible =
                    lblParam1.Visible = lblParam2.Visible = lblParam3.Visible = false;
                if (_indicator.ParamsCount > 0)
                {
                    numParam1.Visible = lblParam1.Visible = true;
                }
                if (_indicator.ParamsCount > 1)
                {
                    numParam2.Visible = lblParam2.Visible = true;
                }
                if (_indicator.ParamsCount > 2)
                {
                    numParam3.Visible = lblParam3.Visible = true;
                }
            }
        }

        #endregion
    }
}
