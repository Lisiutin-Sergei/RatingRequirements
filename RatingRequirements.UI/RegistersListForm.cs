using RatingRequirements.Configuration;
using RatingRequirements.Core.Interface.Service;
using RatingRequirements.UI.Import;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RatingRequirements.UI
{
    /// <summary>
    /// Форма для списка реестров.
    /// </summary>
    public partial class RegistersListForm : Form
    {
        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        private readonly Guid _userId;

        /// <summary>
        /// Сервис импорта данных.
        /// </summary>
        private readonly IImport _importService;

        #region Сервисы

        private readonly IRegisterService _registerService;
        private readonly IUserService _userService;

        #endregion

        public RegistersListForm(
            Guid userId,
            IRegisterService registerService,
            IUserService userService)
        {
            InitializeComponent();

            _userId = userId;

            _registerService = registerService;
            _userService = userService;

            _importService = IoC.Instance.Resolve<DocxWordImport>(new IoC.NinjectArgument("userId", _userId));
        }

        #region Обработка событий

        /// <summary>
        /// При загрузке формы.
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshUserName();
                RefreshRegistersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Добавление нового реестра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var form = IoC.Instance.Resolve<EditRegisterForm>(
                new IoC.NinjectArgument("userId", _userId),
                new IoC.NinjectArgument("registerId", Guid.Empty));
                form.FormClosed += RefreshRegistersList;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshRegistersList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение реестра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_EditRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegisters.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите реестр для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var registerId = Guid.Parse(dgvRegisters.SelectedRows[0].Cells["RegisterId"]?.Value?.ToString());

                var form = IoC.Instance.Resolve<EditRegisterForm>(
                    new IoC.NinjectArgument("userId", _userId),
                    new IoC.NinjectArgument("registerId", registerId));
                form.FormClosed += RefreshRegistersList;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshRegistersList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаление реестра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeleteRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegisters.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите реестр для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var registerId = Guid.Parse(dgvRegisters.SelectedRows[0].Cells["RegisterId"].Value?.ToString());

                var confirmation = MessageBox.Show("Удалить реестр?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (confirmation == DialogResult.OK)
                {
                    _registerService.DeleteRegister(registerId);
                    RefreshRegistersList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Печать реестра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bbtn_PrintRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegisters.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите реестр для печати", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var registerId = Guid.Parse(dgvRegisters.SelectedRows[0].Cells["RegisterId"]?.Value?.ToString());
                _importService.ImportRegister(registerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Обновить список реестров.
        /// </summary>
        private void RefreshRegistersList(object sender = null, EventArgs e = null)
        {
            dgvRegisters.Rows.Clear();

            var registers = _registerService.GetRegistersByUserId(_userId);
            if (!(registers?.Any() ?? false))
            {
                return;
            }

            foreach (var register in registers)
            {
                dgvRegisters.Rows.Add(register.RegisterId, register.Name, register.RegisterDate.ToString("dd.MM.yyyy"));
            }
        }

        /// <summary>
        /// Обновить имя пользователя.
        /// </summary>
        private void RefreshUserName()
        {
            var user = _userService.GetUserById(_userId);
            tbUserName.Text = user.Name ?? user.Login;
        }

        /// <summary>
        /// Выйти.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion
    }
}
