namespace ISAD
{
    partial class Form4
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
            label3 = new Label();
            txtStaff = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            dgStaff = new DataGridView();
            label6 = new Label();
            txtPos = new TextBox();
            label7 = new Label();
            txtSal = new TextBox();
            label8 = new Label();
            dtp = new DateTimePicker();
            rdbF = new RadioButton();
            rdbM = new RadioButton();
            ckb = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(303, 14);
            label5.Name = "label5";
            label5.Size = new Size(184, 31);
            label5.TabIndex = 46;
            label5.Text = "Staff Information";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(590, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 73);
            label4.Name = "label4";
            label4.Size = new Size(31, 28);
            label4.TabIndex = 44;
            label4.Text = "ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(590, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(590, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(590, 72);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 217);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 34;
            label3.Text = "DOB";
            // 
            // txtStaff
            // 
            txtStaff.Location = new Point(239, 121);
            txtStaff.Name = "txtStaff";
            txtStaff.Size = new Size(314, 27);
            txtStaff.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 174);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 35;
            label1.Text = "Gender";
            // 
            // txtID
            // 
            txtID.Location = new Point(239, 73);
            txtID.Name = "txtID";
            txtID.Size = new Size(314, 27);
            txtID.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 124);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 36;
            label2.Text = "Name";
            // 
            // dgStaff
            // 
            dgStaff.AllowUserToAddRows = false;
            dgStaff.AllowUserToDeleteRows = false;
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStaff.Location = new Point(-1, 391);
            dgStaff.Name = "dgStaff";
            dgStaff.ReadOnly = true;
            dgStaff.RowHeadersWidth = 51;
            dgStaff.RowTemplate.Height = 29;
            dgStaff.Size = new Size(771, 319);
            dgStaff.TabIndex = 33;
            dgStaff.CellClick += dgStaff_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 262);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 34;
            label6.Text = "Position";
            // 
            // txtPos
            // 
            txtPos.Location = new Point(239, 259);
            txtPos.Name = "txtPos";
            txtPos.Size = new Size(314, 27);
            txtPos.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(67, 302);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 34;
            label7.Text = "Salary";
            // 
            // txtSal
            // 
            txtSal.Location = new Point(239, 299);
            txtSal.Name = "txtSal";
            txtSal.Size = new Size(314, 27);
            txtSal.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(67, 346);
            label8.Name = "label8";
            label8.Size = new Size(96, 28);
            label8.TabIndex = 34;
            label8.Text = "Stopwork";
            // 
            // dtp
            // 
            dtp.CustomFormat = "MM/dd/yyyy";
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(237, 218);
            dtp.Name = "dtp";
            dtp.Size = new Size(134, 27);
            dtp.TabIndex = 47;
            // 
            // rdbF
            // 
            rdbF.AutoSize = true;
            rdbF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbF.Location = new Point(237, 172);
            rdbF.Name = "rdbF";
            rdbF.Size = new Size(95, 32);
            rdbF.TabIndex = 48;
            rdbF.TabStop = true;
            rdbF.Text = "Female";
            rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            rdbM.AutoSize = true;
            rdbM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbM.Location = new Point(378, 172);
            rdbM.Name = "rdbM";
            rdbM.Size = new Size(76, 32);
            rdbM.TabIndex = 49;
            rdbM.TabStop = true;
            rdbM.Text = "Male";
            rdbM.UseVisualStyleBackColor = true;
            // 
            // ckb
            // 
            ckb.AutoSize = true;
            ckb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb.Location = new Point(353, 352);
            ckb.Name = "ckb";
            ckb.Size = new Size(18, 17);
            ckb.TabIndex = 50;
            ckb.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 709);
            Controls.Add(ckb);
            Controls.Add(rdbM);
            Controls.Add(rdbF);
            Controls.Add(dtp);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSal);
            Controls.Add(txtPos);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtStaff);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(dgStaff);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
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
        private Label label3;
        private TextBox txtStaff;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private DataGridView dgStaff;
        private Label label6;
        private TextBox txtPos;
        private Label label7;
        private TextBox txtSal;
        private Label label8;
        private DateTimePicker dtp;
        private RadioButton rdbF;
        private RadioButton rdbM;
        private CheckBox ckb;
    }
}