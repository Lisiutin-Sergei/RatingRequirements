namespace RatingRequirements.UI
{
    partial class EditDocumentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDocumentForm));
			this.tbIndicatorType = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbIndicator = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbDocumentName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbFileName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbIndicatorFormula = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbPoints = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbIsExecuted = new System.Windows.Forms.CheckBox();
			this.lblParam3 = new System.Windows.Forms.Label();
			this.numParam3 = new System.Windows.Forms.NumericUpDown();
			this.lblParam2 = new System.Windows.Forms.Label();
			this.numParam2 = new System.Windows.Forms.NumericUpDown();
			this.lblParam1 = new System.Windows.Forms.Label();
			this.numParam1 = new System.Windows.Forms.NumericUpDown();
			this.tbDocumentFormula = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numParam3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numParam2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numParam1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbIndicatorType
			// 
			this.tbIndicatorType.Location = new System.Drawing.Point(139, 26);
			this.tbIndicatorType.Name = "tbIndicatorType";
			this.tbIndicatorType.ReadOnly = true;
			this.tbIndicatorType.Size = new System.Drawing.Size(261, 20);
			this.tbIndicatorType.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Тип показателя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Показатель";
			// 
			// tbIndicator
			// 
			this.tbIndicator.Location = new System.Drawing.Point(139, 52);
			this.tbIndicator.Multiline = true;
			this.tbIndicator.Name = "tbIndicator";
			this.tbIndicator.ReadOnly = true;
			this.tbIndicator.Size = new System.Drawing.Size(261, 44);
			this.tbIndicator.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Название документа";
			// 
			// tbDocumentName
			// 
			this.tbDocumentName.Location = new System.Drawing.Point(139, 137);
			this.tbDocumentName.Name = "tbDocumentName";
			this.tbDocumentName.Size = new System.Drawing.Size(261, 20);
			this.tbDocumentName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Имя файла";
			// 
			// tbFileName
			// 
			this.tbFileName.Location = new System.Drawing.Point(139, 163);
			this.tbFileName.Name = "tbFileName";
			this.tbFileName.Size = new System.Drawing.Size(261, 20);
			this.tbFileName.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Формула показателя";
			// 
			// tbIndicatorFormula
			// 
			this.tbIndicatorFormula.Location = new System.Drawing.Point(139, 102);
			this.tbIndicatorFormula.Name = "tbIndicatorFormula";
			this.tbIndicatorFormula.ReadOnly = true;
			this.tbIndicatorFormula.Size = new System.Drawing.Size(261, 20);
			this.tbIndicatorFormula.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Набрано баллов";
			// 
			// tbPoints
			// 
			this.tbPoints.Location = new System.Drawing.Point(107, 52);
			this.tbPoints.Name = "tbPoints";
			this.tbPoints.ReadOnly = true;
			this.tbPoints.Size = new System.Drawing.Size(128, 20);
			this.tbPoints.TabIndex = 10;
			// 
			// btnClose
			// 
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(615, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(50, 50);
			this.btnClose.TabIndex = 12;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.Btn_Close_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(12, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 50);
			this.btnSave.TabIndex = 13;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbIsExecuted);
			this.groupBox1.Controls.Add(this.lblParam3);
			this.groupBox1.Controls.Add(this.numParam3);
			this.groupBox1.Controls.Add(this.lblParam2);
			this.groupBox1.Controls.Add(this.numParam2);
			this.groupBox1.Controls.Add(this.lblParam1);
			this.groupBox1.Controls.Add(this.numParam1);
			this.groupBox1.Controls.Add(this.tbDocumentFormula);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.tbPoints);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(424, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 193);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Формула";
			// 
			// cbIsExecuted
			// 
			this.cbIsExecuted.AutoSize = true;
			this.cbIsExecuted.Location = new System.Drawing.Point(14, 115);
			this.cbIsExecuted.Name = "cbIsExecuted";
			this.cbIsExecuted.Size = new System.Drawing.Size(83, 17);
			this.cbIsExecuted.TabIndex = 18;
			this.cbIsExecuted.Text = "Выполнено";
			this.cbIsExecuted.UseVisualStyleBackColor = true;
			this.cbIsExecuted.Visible = false;
			this.cbIsExecuted.CheckedChanged += new System.EventHandler(this.RecalcFormula);
			// 
			// lblParam3
			// 
			this.lblParam3.AutoSize = true;
			this.lblParam3.Location = new System.Drawing.Point(11, 165);
			this.lblParam3.Name = "lblParam3";
			this.lblParam3.Size = new System.Drawing.Size(67, 13);
			this.lblParam3.TabIndex = 17;
			this.lblParam3.Text = "Параметр 3";
			this.lblParam3.Visible = false;
			// 
			// numParam3
			// 
			this.numParam3.Location = new System.Drawing.Point(107, 163);
			this.numParam3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numParam3.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numParam3.Name = "numParam3";
			this.numParam3.Size = new System.Drawing.Size(128, 20);
			this.numParam3.TabIndex = 16;
			this.numParam3.Visible = false;
			this.numParam3.ValueChanged += new System.EventHandler(this.RecalcFormula);
			// 
			// lblParam2
			// 
			this.lblParam2.AutoSize = true;
			this.lblParam2.Location = new System.Drawing.Point(11, 140);
			this.lblParam2.Name = "lblParam2";
			this.lblParam2.Size = new System.Drawing.Size(67, 13);
			this.lblParam2.TabIndex = 15;
			this.lblParam2.Text = "Параметр 2";
			this.lblParam2.Visible = false;
			// 
			// numParam2
			// 
			this.numParam2.Location = new System.Drawing.Point(107, 138);
			this.numParam2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numParam2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numParam2.Name = "numParam2";
			this.numParam2.Size = new System.Drawing.Size(128, 20);
			this.numParam2.TabIndex = 14;
			this.numParam2.Visible = false;
			this.numParam2.ValueChanged += new System.EventHandler(this.RecalcFormula);
			// 
			// lblParam1
			// 
			this.lblParam1.AutoSize = true;
			this.lblParam1.Location = new System.Drawing.Point(11, 114);
			this.lblParam1.Name = "lblParam1";
			this.lblParam1.Size = new System.Drawing.Size(67, 13);
			this.lblParam1.TabIndex = 13;
			this.lblParam1.Text = "Параметр 1";
			this.lblParam1.Visible = false;
			// 
			// numParam1
			// 
			this.numParam1.Location = new System.Drawing.Point(107, 112);
			this.numParam1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numParam1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this.numParam1.Name = "numParam1";
			this.numParam1.Size = new System.Drawing.Size(128, 20);
			this.numParam1.TabIndex = 12;
			this.numParam1.Visible = false;
			this.numParam1.ValueChanged += new System.EventHandler(this.RecalcFormula);
			// 
			// tbDocumentFormula
			// 
			this.tbDocumentFormula.Location = new System.Drawing.Point(107, 26);
			this.tbDocumentFormula.Name = "tbDocumentFormula";
			this.tbDocumentFormula.ReadOnly = true;
			this.tbDocumentFormula.Size = new System.Drawing.Size(128, 20);
			this.tbDocumentFormula.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Формула";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbIndicatorType);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.tbIndicator);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tbDocumentName);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbFileName);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.tbIndicatorFormula);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 68);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(406, 193);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Документ";
			// 
			// EditDocumentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 270);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(693, 309);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(693, 309);
			this.Name = "EditDocumentForm";
			this.Text = " Редактирование документа";
			this.Load += new System.EventHandler(this.Form_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numParam3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numParam2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numParam1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIndicatorType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndicator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDocumentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIndicatorFormula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPoints;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblParam3;
        private System.Windows.Forms.NumericUpDown numParam3;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.NumericUpDown numParam2;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.NumericUpDown numParam1;
        private System.Windows.Forms.CheckBox cbIsExecuted;
        private System.Windows.Forms.TextBox tbDocumentFormula;
        private System.Windows.Forms.Label label7;
    }
}