namespace WinFormsApp1
{
    partial class frmMain
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
            gboxPerson = new GroupBox();
            pickerBOD = new DateTimePicker();
            lblBirthDate = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtName = new TextBox();
            lblName = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            gBoxPersons = new GroupBox();
            dgvPersons = new DataGridView();
            btnClear = new Button();
            gboxPerson.SuspendLayout();
            gBoxPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // gboxPerson
            // 
            gboxPerson.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gboxPerson.Controls.Add(pickerBOD);
            gboxPerson.Controls.Add(lblBirthDate);
            gboxPerson.Controls.Add(txtDni);
            gboxPerson.Controls.Add(lblDni);
            gboxPerson.Controls.Add(txtName);
            gboxPerson.Controls.Add(lblName);
            gboxPerson.Location = new Point(14, 16);
            gboxPerson.Margin = new Padding(3, 4, 3, 4);
            gboxPerson.Name = "gboxPerson";
            gboxPerson.Padding = new Padding(3, 4, 3, 4);
            gboxPerson.Size = new Size(341, 301);
            gboxPerson.TabIndex = 0;
            gboxPerson.TabStop = false;
            gboxPerson.Text = "Person data:";
            // 
            // pickerBOD
            // 
            pickerBOD.CustomFormat = "";
            pickerBOD.Format = DateTimePickerFormat.Short;
            pickerBOD.Location = new Point(17, 187);
            pickerBOD.Margin = new Padding(3, 4, 3, 4);
            pickerBOD.Name = "pickerBOD";
            pickerBOD.Size = new Size(209, 27);
            pickerBOD.TabIndex = 2;
            pickerBOD.Value = new DateTime(2023, 10, 19, 0, 0, 0, 0);
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(17, 163);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(74, 20);
            lblBirthDate.TabIndex = 4;
            lblBirthDate.Text = "Birth date";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(17, 128);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(114, 27);
            txtDni.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(17, 104);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "Dni";
            // 
            // txtName
            // 
            txtName.Location = new Point(17, 69);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 40;
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(269, 325);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(174, 327);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gBoxPersons
            // 
            gBoxPersons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gBoxPersons.Controls.Add(dgvPersons);
            gBoxPersons.Location = new Point(361, 16);
            gBoxPersons.Margin = new Padding(3, 4, 3, 4);
            gBoxPersons.Name = "gBoxPersons";
            gBoxPersons.Padding = new Padding(3, 4, 3, 4);
            gBoxPersons.Size = new Size(483, 341);
            gBoxPersons.TabIndex = 3;
            gBoxPersons.TabStop = false;
            gBoxPersons.Text = "List of Persons";
            // 
            // dgvPersons
            // 
            dgvPersons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPersons.Location = new Point(7, 29);
            dgvPersons.Margin = new Padding(3, 4, 3, 4);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.RowHeadersWidth = 51;
            dgvPersons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPersons.RowTemplate.Height = 25;
            dgvPersons.Size = new Size(470, 304);
            dgvPersons.TabIndex = 3;
            dgvPersons.RowHeaderMouseClick += dgvPersons_RowHeaderMouseClick;
            // 
            // btnClear
            // 
            btnClear.Enabled = false;
            btnClear.Location = new Point(81, 327);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 373);
            Controls.Add(btnClear);
            Controls.Add(gBoxPersons);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(gboxPerson);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person App";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            gboxPerson.ResumeLayout(false);
            gboxPerson.PerformLayout();
            gBoxPersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxPerson;
        private DateTimePicker pickerBOD;
        private Label lblBirthDate;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtName;
        private Label lblName;
        private Button btnSave;
        private Button btnDelete;
        private GroupBox gBoxPersons;
        private DataGridView dgvPersons;
        private Button btnClear;
    }
}