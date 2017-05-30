namespace RatingRequirements.UI
{
    partial class RegistersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistersListForm));
            this.dgvRegisters = new System.Windows.Forms.DataGridView();
            this.RegisterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.btnEditRegister = new System.Windows.Forms.Button();
            this.btnDeleteRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintRegister = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegisters
            // 
            this.dgvRegisters.AllowUserToAddRows = false;
            this.dgvRegisters.AllowUserToDeleteRows = false;
            this.dgvRegisters.AllowUserToResizeColumns = false;
            this.dgvRegisters.AllowUserToResizeRows = false;
            this.dgvRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterId,
            this.RegisterName,
            this.RegisterDate});
            this.dgvRegisters.Location = new System.Drawing.Point(12, 65);
            this.dgvRegisters.Name = "dgvRegisters";
            this.dgvRegisters.ReadOnly = true;
            this.dgvRegisters.RowHeadersVisible = false;
            this.dgvRegisters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisters.Size = new System.Drawing.Size(560, 284);
            this.dgvRegisters.TabIndex = 0;
            // 
            // RegisterId
            // 
            this.RegisterId.HeaderText = "Id";
            this.RegisterId.Name = "RegisterId";
            this.RegisterId.ReadOnly = true;
            this.RegisterId.Visible = false;
            // 
            // RegisterName
            // 
            this.RegisterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegisterName.HeaderText = "Название";
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.HeaderText = "Дата";
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRegister.Image")));
            this.btnAddRegister.Location = new System.Drawing.Point(12, 9);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(50, 50);
            this.btnAddRegister.TabIndex = 1;
            this.btnAddRegister.UseVisualStyleBackColor = true;
            this.btnAddRegister.Click += new System.EventHandler(this.Btn_AddRegister_Click);
            // 
            // btnEditRegister
            // 
            this.btnEditRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRegister.Image")));
            this.btnEditRegister.Location = new System.Drawing.Point(68, 9);
            this.btnEditRegister.Name = "btnEditRegister";
            this.btnEditRegister.Size = new System.Drawing.Size(50, 50);
            this.btnEditRegister.TabIndex = 1;
            this.btnEditRegister.UseVisualStyleBackColor = true;
            this.btnEditRegister.Click += new System.EventHandler(this.Btn_EditRegister_Click);
            // 
            // btnDeleteRegister
            // 
            this.btnDeleteRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRegister.Image")));
            this.btnDeleteRegister.Location = new System.Drawing.Point(124, 9);
            this.btnDeleteRegister.Name = "btnDeleteRegister";
            this.btnDeleteRegister.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteRegister.TabIndex = 1;
            this.btnDeleteRegister.UseVisualStyleBackColor = true;
            this.btnDeleteRegister.Click += new System.EventHandler(this.Btn_DeleteRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(522, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btnPrintRegister
            // 
            this.btnPrintRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRegister.Image")));
            this.btnPrintRegister.Location = new System.Drawing.Point(180, 9);
            this.btnPrintRegister.Name = "btnPrintRegister";
            this.btnPrintRegister.Size = new System.Drawing.Size(50, 50);
            this.btnPrintRegister.TabIndex = 1;
            this.btnPrintRegister.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Location = new System.Drawing.Point(333, 25);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(183, 13);
            this.tbUserName.TabIndex = 2;
            // 
            // RegistersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintRegister);
            this.Controls.Add(this.btnDeleteRegister);
            this.Controls.Add(this.btnEditRegister);
            this.Controls.Add(this.btnAddRegister);
            this.Controls.Add(this.dgvRegisters);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "RegistersListForm";
            this.Text = "Список документации";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegisters;
        private System.Windows.Forms.Button btnAddRegister;
        private System.Windows.Forms.Button btnEditRegister;
        private System.Windows.Forms.Button btnDeleteRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.TextBox tbUserName;
    }
}