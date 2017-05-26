namespace RatingRequirements.UI
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbConfirmPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbUserPosition = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(165, 31);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(170, 20);
			this.tbUserName.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Имя пользователя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Пароль";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(165, 116);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(170, 20);
			this.tbPassword.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Подтвердите пароль";
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.Location = new System.Drawing.Point(165, 142);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.Size = new System.Drawing.Size(170, 20);
			this.tbConfirmPassword.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(111, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(183, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Введите регистрационные данные";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(47, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Логин";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(165, 90);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(170, 20);
			this.tbLogin.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(47, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Должность";
			// 
			// tbUserPosition
			// 
			this.tbUserPosition.Location = new System.Drawing.Point(165, 57);
			this.tbUserPosition.Name = "tbUserPosition";
			this.tbUserPosition.Size = new System.Drawing.Size(170, 20);
			this.tbUserPosition.TabIndex = 10;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(114, 176);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(75, 23);
			this.btnRegister.TabIndex = 12;
			this.btnRegister.Text = "OK";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.Btn_Register_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(195, 176);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbUserPosition);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbConfirmPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbUserName);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 250);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 250);
			this.Name = "RegistrationForm";
			this.Text = "Регистрация пользователя";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserPosition;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}