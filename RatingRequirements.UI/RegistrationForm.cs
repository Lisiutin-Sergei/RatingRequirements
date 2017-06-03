using RatingRequirements.Configuration;
using RatingRequirements.Core.Interface.Service;
using RatingRequirements.Core.Model;
using RatingRequirements.Utilities.Common;
using RatingRequirements.Utilities.ExtensionMethods;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RatingRequirements.UI
{
    /// <summary>
    /// Форма регистрации пользователя.
    /// </summary>
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userServie;

        public RegistrationForm(IUserService userServie)
        {
            _userServie = userServie;

            InitializeComponent();
        }

        /// <summary>
        /// При загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                var positions = _userServie.GetAllPositions();

                cbPosition.DataSource = positions;
                cbPosition.DisplayMember = "Name"; 
                cbPosition.ValueMember = "PositionId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Валидация регистрации пользователя.
        /// </summary>
        private void ValidateRegistration()
        {
            Argument.NotNullOrWhiteSpace(tbUserName.Text, "Не заполнено имя пользователя.");
            Argument.NotNullOrWhiteSpace(cbPosition.Text, "Не заполнена должность пользователя.");
            Argument.NotNullOrWhiteSpace(tbLogin.Text, "Не заполнен логин пользователя.");
            Argument.NotNullOrWhiteSpace(tbPassword.Text, "Не заполнен пароль пользователя.");
            Argument.NotNullOrWhiteSpace(tbConfirmPassword.Text, "Не заполнено подтверждение пароль пользователя.");

            Argument.Require(tbPassword.Text == tbConfirmPassword.Text, "Пароль и его подтверждение не совпадают.");
            var users = _userServie.LoadUsersByFilter(u => u.Login.EqualsIgnoreCase(tbLogin.Text));
            Argument.Require((users?.Any() ?? false) == false, "Уже существует пользователь с введенным логином.");
        }

        /// <summary>
        /// Регистрация пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateRegistration();

                var user = new User
                {
                    Login = tbLogin.Text,
                    Name = tbUserName.Text,
                    PositionId = (Guid)cbPosition.SelectedValue
                };
                user.UserId = _userServie.InsertUser(user, tbPassword.Text);

                // Переход на форму приложения
                Close();
                IoC.Instance.Resolve<RegistersListForm>(new IoC.NinjectArgument("userId", user.UserId)).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Отменить авторизацию.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
