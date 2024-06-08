namespace ISAD
{
    partial class Form2
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
            txtPro = new TextBox();
            txtCode = new TextBox();
            label2 = new Label();
            dgPro = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPro).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(163, 23);
            label5.Name = "label5";
            label5.Size = new Size(219, 31);
            label5.TabIndex = 22;
            label5.Text = "Product Information";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(405, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 82);
            label4.Name = "label4";
            label4.Size = new Size(31, 28);
            label4.TabIndex = 20;
            label4.Text = "ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(288, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(163, 180);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(40, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPro
            // 
            txtPro.Location = new Point(116, 130);
            txtPro.Name = "txtPro";
            txtPro.Size = new Size(334, 27);
            txtPro.TabIndex = 16;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(116, 82);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(334, 27);
            txtCode.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // dgPro
            // 
            dgPro.AllowUserToAddRows = false;
            dgPro.AllowUserToDeleteRows = false;
            dgPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPro.Location = new Point(1, 215);
            dgPro.Name = "dgPro";
            dgPro.ReadOnly = true;
            dgPro.RowHeadersWidth = 51;
            dgPro.RowTemplate.Height = 29;
            dgPro.Size = new Size(533, 319);
            dgPro.TabIndex = 13;
            dgPro.CellClick += dgPro_CellClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 534);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtPro);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(dgPro);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgPro).EndInit();
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
        private TextBox txtPro;
        private TextBox txtCode;
        private Label label2;
        private DataGridView dgPro;
    }
}