using RatingRequirements.Configuration;
using RatingRequirements.Core.Interface.Service;
using RatingRequirements.Core.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RatingRequirements.UI
{
    /// <summary>
    /// Форма редактирования реестра.
    /// </summary>
    public partial class EditRegisterForm : Form
    {
        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        private readonly Guid _userId;

        /// <summary>
        /// Идентификатор реестра.
        /// </summary>
        private Guid _registerId;

        #region Сервисы

        private readonly IRegisterService _registerService;
        private readonly IUserService _userService;
        private readonly IIndicatorService _indicatorService;
        private readonly IIndicatorTypeService _indicatorTypeService;
        private readonly IDocumentService _documentService;

        #endregion

        public EditRegisterForm(
            Guid userId,
            Guid registerId,
            IRegisterService registerService,
            IUserService userService,
            IIndicatorService indicatorService,
            IIndicatorTypeService indicatorTypeService,
            IDocumentService documentService)
        {
            InitializeComponent();

            _userId = userId;
            _registerId = registerId;

            _registerService = registerService;
            _userService = userService;
            _indicatorTypeService = indicatorTypeService;
            _indicatorService = indicatorService;
            _documentService = documentService;
        }

        #region Обработка событий

        /// <summary>
        /// При загрузке формы.
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                var isEdit = _registerId != Guid.Empty;

                if (isEdit)
                {
                    var register = _registerService.GetRegisterById(_registerId);
                    tbRegisterName.Text = register.Name;
                    dpRegisterDate.Value = register.RegisterDate;
                    RefreshUserName(register.UserId);
                    
                    Text = $"Редактирование реестра \"{register.Name}\"";

                    RefreshIndicatorsTree();
                }
                else
                {
                    RefreshUserName(_userId);
                    tbRegisterName.Text = "ОЦЕНОЧНАЯ ВЕДОМОСТЬ ПО ВЫПОЛНЕНИЮ РЕЙТИНГОВЫХ ПРОФЕССИОНАЛЬНЫХ ТРЕБОВАНИЙ";

                    Text = "Новый реестр";
                }

                // Заблокировать дерево и таблицу для новых реестров
                gbIndicators.Enabled = isEdit;
                gbDocuments.Enabled = isEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// При изменени выбора в дереве показателей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tree_Indicators_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                RefreshDocumentsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранить реестр.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var register = new Register
                {
                    Name = tbRegisterName.Text,
                    RegisterDate = dpRegisterDate.Value,
                    RegisterId = _registerId,
                    UserId = _userId
                };
                _registerId = _registerService.SaveRegister(register);

                DialogResult = DialogResult.OK;
                Close();
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
        /// Добавить документ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeIndicators.SelectedNode?.Level != 1 || string.IsNullOrEmpty(treeIndicators.SelectedNode.Name))
                {
                    throw new Exception("Выберите показатель.");
                }

                var indicatorId = Guid.Parse(treeIndicators.SelectedNode.Name);

                var form = IoC.Instance.Resolve<EditDocumentForm>(
                    new IoC.NinjectArgument("documentId", Guid.Empty),
                    new IoC.NinjectArgument("indicatorId", indicatorId),
                    new IoC.NinjectArgument("registerId", _registerId));
                form.FormClosed += RefreshDocumentsGrid;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменить документ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_EditDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeIndicators.SelectedNode?.Level != 1 || string.IsNullOrEmpty(treeIndicators.SelectedNode.Name))
                {
                    throw new Exception("Выберите показатель.");
                }
                var indicatorId = Guid.Parse(treeIndicators.SelectedNode.Name);

                if (dgvDocuments.SelectedRows.Count != 1)
                {
                    throw new Exception("Выберите документ для редактирования.");
                }
                var documentId = Guid.Parse(dgvDocuments.SelectedRows[0].Cells["DocumentId"]?.Value?.ToString());

                var form = IoC.Instance.Resolve<EditDocumentForm>(
                    new IoC.NinjectArgument("documentId", documentId),
                    new IoC.NinjectArgument("indicatorId", indicatorId),
                    new IoC.NinjectArgument("registerId", _registerId));
                form.FormClosed += RefreshDocumentsGrid;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удалить документ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeleteDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeIndicators.SelectedNode?.Level != 1 || string.IsNullOrEmpty(treeIndicators.SelectedNode.Name))
                {
                    throw new Exception("Выберите показатель.");
                }
                var indicatorId = Guid.Parse(treeIndicators.SelectedNode.Name);

                if (dgvDocuments.SelectedRows.Count != 1)
                {
                    throw new Exception("Выберите документ для редактирования.");
                }
                var documentId = Guid.Parse(dgvDocuments.SelectedRows[0].Cells["DocumentId"]?.Value?.ToString());

                var confirmation = MessageBox.Show("Удалить документ?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmation == DialogResult.OK)
                {
                    _documentService.DeleteDocument(documentId);
                    RefreshDocumentsGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion 

        #region Вспомогательные методы

        /// <summary>
        /// Обновить имя пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        private void RefreshUserName(Guid userId)
        {
            var user = _userService.GetUserById(userId);
            tbRegisterUser.Text = user.Name ?? user.Login;
        }

        /// <summary>
        /// Обновить дерево показателей.
        /// </summary>
        private void RefreshIndicatorsTree()
        {
            treeIndicators.Nodes.Clear();

            var indicatorTypes = _indicatorTypeService.GetIndicatorTypesForUser(_userId);
            var indicators = _indicatorService.GetAllIndicators();

            if (!(indicatorTypes?.Any() ?? false) || !(indicators?.Any() ?? false))
            {
                return;
            }

            // Накидать типов показателей на 1 уровень дерева
            foreach (var indicatorType in indicatorTypes)
            {
                var node = treeIndicators.Nodes.Add(indicatorType.IndicatorTypeId.ToString(), indicatorType.Name);

                // Накидать показатели для типа на 2 уровень дерева
                var currentIndicators = indicators.Where(e => e.IndicatorTypeId == indicatorType.IndicatorTypeId);
                foreach (var indicator in currentIndicators)
                {
                    node.Nodes.Add(indicator.IndicatorId.ToString(), indicator.Name);
                }
            }
        }

        /// <summary>
        /// Обновить таблицу с документами.
        /// </summary>
        private void RefreshDocumentsGrid(object sender = null, EventArgs e = null)
        {
            dgvDocuments.Rows.Clear();

            if (treeIndicators.SelectedNode?.Level != 1 || string.IsNullOrEmpty(treeIndicators.SelectedNode.Name))
            {
                return;
            }

            var indicatorId = Guid.Parse(treeIndicators.SelectedNode.Name);

            var documents = _documentService.GetDocumentsByIndicator(indicatorId, _registerId);
            if (!(documents?.Any() ?? false))
            {
                return;
            }

            foreach (var document in documents)
            {
                dgvDocuments.Rows.Add(
                    document.DocumentId,
                    document.Name,
                    document.FileName,
                    document.Formula,
                    document.Points);
            }
        }

        #endregion
    }
}
