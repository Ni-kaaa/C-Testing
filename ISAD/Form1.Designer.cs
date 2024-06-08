namespace ISAD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgCus = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtCus = new TextBox();
            btnSave = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            label4 = new Label();
            btnDelete = new Button();
            label5 = new Label();
            label3 = new Label();
            txtCon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgCus).BeginInit();
            SuspendLayout();
            // 
            // dgCus
            // 
            dgCus.AllowUserToAddRows = false;
            dgCus.AllowUserToDeleteRows = false;
            dgCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCus.Location = new Point(0, 266);
            dgCus.Name = "dgCus";
            dgCus.ReadOnly = true;
            dgCus.RowHeadersWidth = 51;
            dgCus.RowTemplate.Height = 29;
            dgCus.Size = new Size(533, 266);
            dgCus.TabIndex = 0;
            dgCus.CellClick += dgCus_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 131);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(115, 80);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(334, 27);
            txtID.TabIndex = 4;
            // 
            // txtCus
            // 
            txtCus.Location = new Point(115, 128);
            txtCus.Name = "txtCus";
            txtCus.Size = new Size(334, 27);
            txtCus.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(39, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(162, 216);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(287, 216);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 80);
            label4.Name = "label4";
            label4.Size = new Size(31, 28);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(404, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(162, 21);
            label5.Name = "label5";
            label5.Size = new Size(237, 31);
            label5.TabIndex = 12;
            label5.Text = "Customer Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 172);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 2;
            label3.Text = "Contact";
            // 
            // txtCon
            // 
            txtCon.Location = new Point(115, 169);
            txtCon.Name = "txtCon";
            txtCon.Size = new Size(334, 27);
            txtCon.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 532);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtCon);
            Controls.Add(txtCus);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgCus);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCus;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtCus;
        private Button btnSave;
        private Button btnSearch;
        private Button btnUpdate;
        private Label label4;
        private Button btnDelete;
        private Label label5;
        private Label label3;
        private TextBox txtCon;
    }
}