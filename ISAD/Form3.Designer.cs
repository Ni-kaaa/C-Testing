namespace ISAD
{
    partial class Form3
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
            label5 = new Label();
            btnDelete = new Button();
            label4 = new Label();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSup = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            dgSup = new DataGridView();
            label1 = new Label();
            txtAdd = new TextBox();
            label3 = new Label();
            txtCon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgSup).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(175, 27);
            label5.Name = "label5";
            label5.Size = new Size(224, 31);
            label5.TabIndex = 32;
            label5.Text = "Supplier Information";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(417, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 86);
            label4.Name = "label4";
            label4.Size = new Size(31, 28);
            label4.TabIndex = 30;
            label4.Text = "ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(300, 319);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(175, 319);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(52, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSup
            // 
            txtSup.Location = new Point(128, 134);
            txtSup.Name = "txtSup";
            txtSup.Size = new Size(334, 27);
            txtSup.TabIndex = 26;
            // 
            // txtID
            // 
            txtID.Location = new Point(128, 86);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(334, 27);
            txtID.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 137);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // dgSup
            // 
            dgSup.AllowUserToAddRows = false;
            dgSup.AllowUserToDeleteRows = false;
            dgSup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSup.Location = new Point(13, 354);
            dgSup.Name = "dgSup";
            dgSup.ReadOnly = true;
            dgSup.RowHeadersWidth = 51;
            dgSup.RowTemplate.Height = 29;
            dgSup.Size = new Size(533, 319);
            dgSup.TabIndex = 23;
            dgSup.CellClick += dgSup_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 187);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 24;
            label1.Text = "Address";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(128, 184);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(334, 27);
            txtAdd.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 240);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 24;
            label3.Text = "Contact";
            // 
            // txtCon
            // 
            txtCon.Location = new Point(128, 237);
            txtCon.Name = "txtCon";
            txtCon.Size = new Size(334, 27);
            txtCon.TabIndex = 26;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 687);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtCon);
            Controls.Add(txtAdd);
            Controls.Add(label3);
            Controls.Add(txtSup);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(dgSup);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgSup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnDelete;
        private Label label4;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private TextBox txtSup;
        private TextBox txtID;
        private Label label2;
        private DataGridView dgSup;
        private Label label1;
        private TextBox txtAdd;
        private Label label3;
        private TextBox txtCon;
    }
}