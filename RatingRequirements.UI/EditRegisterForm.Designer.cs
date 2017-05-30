namespace RatingRequirements.UI
{
    partial class EditRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRegisterForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbIndicators = new System.Windows.Forms.GroupBox();
            this.treeIndicators = new System.Windows.Forms.TreeView();
            this.gbDocuments = new System.Windows.Forms.GroupBox();
            this.btnDeleteDocument = new System.Windows.Forms.Button();
            this.btnEditDocument = new System.Windows.Forms.Button();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIndicators.SuspendLayout();
            this.gbDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(885, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // tbRegisterName
            // 
            this.tbRegisterName.Location = new System.Drawing.Point(119, 73);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(816, 20);
            this.tbRegisterName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название реестра";
            // 
            // dpRegisterDate
            // 
            this.dpRegisterDate.Location = new System.Drawing.Point(119, 99);
            this.dpRegisterDate.Name = "dpRegisterDate";
            this.dpRegisterDate.Size = new System.Drawing.Size(200, 20);
            this.dpRegisterDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата реестра";
            // 
            // tbRegisterUser
            // 
            this.tbRegisterUser.Location = new System.Drawing.Point(458, 99);
            this.tbRegisterUser.Name = "tbRegisterUser";
            this.tbRegisterUser.ReadOnly = true;
            this.tbRegisterUser.Size = new System.Drawing.Size(477, 20);
            this.tbRegisterUser.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Владелец реестра";
            // 
            // gbIndicators
            // 
            this.gbIndicators.Controls.Add(this.treeIndicators);
            this.gbIndicators.Location = new System.Drawing.Point(15, 125);
            this.gbIndicators.Name = "gbIndicators";
            this.gbIndicators.Size = new System.Drawing.Size(304, 350);
            this.gbIndicators.TabIndex = 10;
            this.gbIndicators.TabStop = false;
            this.gbIndicators.Text = "Показатели";
            // 
            // treeIndicators
            // 
            this.treeIndicators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeIndicators.Location = new System.Drawing.Point(3, 16);
            this.treeIndicators.Name = "treeIndicators";
            this.treeIndicators.Size = new System.Drawing.Size(298, 331);
            this.treeIndicators.TabIndex = 0;
            this.treeIndicators.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_Indicators_AfterSelect);
            // 
            // gbDocuments
            // 
            this.gbDocuments.Controls.Add(this.btnDeleteDocument);
            this.gbDocuments.Controls.Add(this.btnEditDocument);
            this.gbDocuments.Controls.Add(this.btnAddDocument);
            this.gbDocuments.Controls.Add(this.dgvDocuments);
            this.gbDocuments.Location = new System.Drawing.Point(325, 125);
            this.gbDocuments.Name = "gbDocuments";
            this.gbDocuments.Size = new System.Drawing.Size(610, 350);
            this.gbDocuments.TabIndex = 11;
            this.gbDocuments.TabStop = false;
            this.gbDocuments.Text = "Документы";
            // 
            // btnDeleteDocument
            // 
            this.btnDeleteDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDocument.Image")));
            this.btnDeleteDocument.Location = new System.Drawing.Point(554, 128);
            this.btnDeleteDocument.Name = "btnDeleteDocument";
            this.btnDeleteDocument.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteDocument.TabIndex = 3;
            this.btnDeleteDocument.UseVisualStyleBackColor = true;
            this.btnDeleteDocument.Click += new System.EventHandler(this.Btn_DeleteDocument_Click);
            // 
            // btnEditDocument
            // 
            this.btnEditDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDocument.Image")));
            this.btnEditDocument.Location = new System.Drawing.Point(554, 72);
            this.btnEditDocument.Name = "btnEditDocument";
            this.btnEditDocument.Size = new System.Drawing.Size(50, 50);
            this.btnEditDocument.TabIndex = 3;
            this.btnEditDocument.UseVisualStyleBackColor = true;
            this.btnEditDocument.Click += new System.EventHandler(this.Btn_EditDocument_Click);
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDocument.Image")));
            this.btnAddDocument.Location = new System.Drawing.Point(554, 16);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(50, 50);
            this.btnAddDocument.TabIndex = 3;
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.Btn_AddDocument_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AllowUserToResizeColumns = false;
            this.dgvDocuments.AllowUserToResizeRows = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.DocumentName,
            this.FileName,
            this.Formula,
            this.Points});
            this.dgvDocuments.Location = new System.Drawing.Point(3, 16);
            this.dgvDocuments.MaximumSize = new System.Drawing.Size(545, 331);
            this.dgvDocuments.MinimumSize = new System.Drawing.Size(545, 331);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersVisible = false;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.Size = new System.Drawing.Size(545, 331);
            this.dgvDocuments.TabIndex = 1;
            // 
            // DocumentId
            // 
            this.DocumentId.HeaderText = "DocumentId";
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.ReadOnly = true;
            this.DocumentId.Visible = false;
            // 
            // DocumentName
            // 
            this.DocumentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocumentName.HeaderText = "Название";
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "Имя файла";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Formula
            // 
            this.Formula.HeaderText = "Расчет баллов";
            this.Formula.Name = "Formula";
            this.Formula.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.HeaderText = "Набрано баллов";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // EditRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 487);
            this.Controls.Add(this.gbDocuments);
            this.Controls.Add(this.gbIndicators);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRegisterUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpRegisterDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRegisterName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(963, 526);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(963, 526);
            this.Name = "EditRegisterForm";
            this.Text = "Редактирование реестра";
            this.Load += new System.EventHandler(this.Form_Load);
            this.gbIndicators.ResumeLayout(false);
            this.gbDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpRegisterDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbIndicators;
        private System.Windows.Forms.GroupBox gbDocuments;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnDeleteDocument;
        private System.Windows.Forms.Button btnEditDocument;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.TreeView treeIndicators;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
    }
}