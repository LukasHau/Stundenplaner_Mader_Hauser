namespace Stundenplaner_Mader_Hauser
{
    partial class Lehrer
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
            this.tb_teacherSearchDatabase = new System.Windows.Forms.TextBox();
            this.dG_teacher = new System.Windows.Forms.DataGridView();
            this.tB_teacherEmail = new System.Windows.Forms.TextBox();
            this.lbl_teacherEmail = new System.Windows.Forms.Label();
            this.btn_teacherLoad = new System.Windows.Forms.Button();
            this.btn_teacherDelete = new System.Windows.Forms.Button();
            this.btn_teacherSave = new System.Windows.Forms.Button();
            this.btn_teacherBack = new System.Windows.Forms.Button();
            this.cb_teacherAdd = new System.Windows.Forms.CheckBox();
            this.dtp_teacherBirth = new System.Windows.Forms.DateTimePicker();
            this.tb_teacherAdress = new System.Windows.Forms.TextBox();
            this.tb_teacherSurname = new System.Windows.Forms.TextBox();
            this.tb_teacherName = new System.Windows.Forms.TextBox();
            this.lbl_teacherBirth = new System.Windows.Forms.Label();
            this.lbl_teacherAdress = new System.Windows.Forms.Label();
            this.lbl_teacherSurname = new System.Windows.Forms.Label();
            this.lbl_teacherName = new System.Windows.Forms.Label();
            this.cB_sex = new System.Windows.Forms.ComboBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.cLBTeacher = new System.Windows.Forms.CheckedListBox();
            this.lbl_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dG_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_teacherSearchDatabase
            // 
            this.tb_teacherSearchDatabase.Location = new System.Drawing.Point(665, 19);
            this.tb_teacherSearchDatabase.Name = "tb_teacherSearchDatabase";
            this.tb_teacherSearchDatabase.Size = new System.Drawing.Size(243, 23);
            this.tb_teacherSearchDatabase.TabIndex = 41;
            this.tb_teacherSearchDatabase.TextChanged += new System.EventHandler(this.tb_teacherSearchDatabase_TextChanged);
            // 
            // dG_teacher
            // 
            this.dG_teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_teacher.Location = new System.Drawing.Point(610, 48);
            this.dG_teacher.Name = "dG_teacher";
            this.dG_teacher.ReadOnly = true;
            this.dG_teacher.RowTemplate.Height = 25;
            this.dG_teacher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_teacher.Size = new System.Drawing.Size(298, 229);
            this.dG_teacher.TabIndex = 40;
            // 
            // tB_teacherEmail
            // 
            this.tB_teacherEmail.Location = new System.Drawing.Point(106, 174);
            this.tB_teacherEmail.Name = "tB_teacherEmail";
            this.tB_teacherEmail.Size = new System.Drawing.Size(216, 23);
            this.tB_teacherEmail.TabIndex = 39;
            // 
            // lbl_teacherEmail
            // 
            this.lbl_teacherEmail.AutoSize = true;
            this.lbl_teacherEmail.Location = new System.Drawing.Point(13, 177);
            this.lbl_teacherEmail.Name = "lbl_teacherEmail";
            this.lbl_teacherEmail.Size = new System.Drawing.Size(44, 15);
            this.lbl_teacherEmail.TabIndex = 38;
            this.lbl_teacherEmail.Text = "E-Mail:";
            // 
            // btn_teacherLoad
            // 
            this.btn_teacherLoad.Location = new System.Drawing.Point(629, 294);
            this.btn_teacherLoad.Name = "btn_teacherLoad";
            this.btn_teacherLoad.Size = new System.Drawing.Size(89, 28);
            this.btn_teacherLoad.TabIndex = 37;
            this.btn_teacherLoad.Text = "Laden";
            this.btn_teacherLoad.UseVisualStyleBackColor = true;
            this.btn_teacherLoad.Click += new System.EventHandler(this.btn_teacherLoad_Click);
            // 
            // btn_teacherDelete
            // 
            this.btn_teacherDelete.Location = new System.Drawing.Point(724, 294);
            this.btn_teacherDelete.Name = "btn_teacherDelete";
            this.btn_teacherDelete.Size = new System.Drawing.Size(89, 28);
            this.btn_teacherDelete.TabIndex = 36;
            this.btn_teacherDelete.Text = "Löschen";
            this.btn_teacherDelete.UseVisualStyleBackColor = true;
            this.btn_teacherDelete.Click += new System.EventHandler(this.btn_teacherDelete_Click);
            // 
            // btn_teacherSave
            // 
            this.btn_teacherSave.Location = new System.Drawing.Point(819, 294);
            this.btn_teacherSave.Name = "btn_teacherSave";
            this.btn_teacherSave.Size = new System.Drawing.Size(89, 28);
            this.btn_teacherSave.TabIndex = 35;
            this.btn_teacherSave.Text = "Speichern";
            this.btn_teacherSave.UseVisualStyleBackColor = true;
            this.btn_teacherSave.Click += new System.EventHandler(this.btn_teacherSave_Click);
            // 
            // btn_teacherBack
            // 
            this.btn_teacherBack.Location = new System.Drawing.Point(10, 294);
            this.btn_teacherBack.Name = "btn_teacherBack";
            this.btn_teacherBack.Size = new System.Drawing.Size(89, 28);
            this.btn_teacherBack.TabIndex = 34;
            this.btn_teacherBack.Text = "Zurück";
            this.btn_teacherBack.UseVisualStyleBackColor = true;
            this.btn_teacherBack.Click += new System.EventHandler(this.btn_teacherBack_Click);
            // 
            // cb_teacherAdd
            // 
            this.cb_teacherAdd.AutoSize = true;
            this.cb_teacherAdd.Location = new System.Drawing.Point(13, 12);
            this.cb_teacherAdd.Name = "cb_teacherAdd";
            this.cb_teacherAdd.Size = new System.Drawing.Size(160, 19);
            this.cb_teacherAdd.TabIndex = 33;
            this.cb_teacherAdd.Text = "Neuen Lehrer hinzufügen";
            this.cb_teacherAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cb_teacherAdd.UseVisualStyleBackColor = true;
            this.cb_teacherAdd.CheckedChanged += new System.EventHandler(this.cb_teacherAdd_CheckedChanged);
            // 
            // dtp_teacherBirth
            // 
            this.dtp_teacherBirth.Location = new System.Drawing.Point(106, 142);
            this.dtp_teacherBirth.Name = "dtp_teacherBirth";
            this.dtp_teacherBirth.Size = new System.Drawing.Size(216, 23);
            this.dtp_teacherBirth.TabIndex = 32;
            // 
            // tb_teacherAdress
            // 
            this.tb_teacherAdress.Location = new System.Drawing.Point(106, 203);
            this.tb_teacherAdress.Multiline = true;
            this.tb_teacherAdress.Name = "tb_teacherAdress";
            this.tb_teacherAdress.Size = new System.Drawing.Size(216, 74);
            this.tb_teacherAdress.TabIndex = 30;
            // 
            // tb_teacherSurname
            // 
            this.tb_teacherSurname.Location = new System.Drawing.Point(106, 82);
            this.tb_teacherSurname.Name = "tb_teacherSurname";
            this.tb_teacherSurname.Size = new System.Drawing.Size(216, 23);
            this.tb_teacherSurname.TabIndex = 29;
            // 
            // tb_teacherName
            // 
            this.tb_teacherName.Location = new System.Drawing.Point(106, 48);
            this.tb_teacherName.Name = "tb_teacherName";
            this.tb_teacherName.Size = new System.Drawing.Size(216, 23);
            this.tb_teacherName.TabIndex = 28;
            // 
            // lbl_teacherBirth
            // 
            this.lbl_teacherBirth.AutoSize = true;
            this.lbl_teacherBirth.Location = new System.Drawing.Point(10, 148);
            this.lbl_teacherBirth.Name = "lbl_teacherBirth";
            this.lbl_teacherBirth.Size = new System.Drawing.Size(86, 15);
            this.lbl_teacherBirth.TabIndex = 26;
            this.lbl_teacherBirth.Text = "Geburtsdatum:";
            // 
            // lbl_teacherAdress
            // 
            this.lbl_teacherAdress.AutoSize = true;
            this.lbl_teacherAdress.Location = new System.Drawing.Point(13, 206);
            this.lbl_teacherAdress.Name = "lbl_teacherAdress";
            this.lbl_teacherAdress.Size = new System.Drawing.Size(51, 15);
            this.lbl_teacherAdress.TabIndex = 25;
            this.lbl_teacherAdress.Text = "Adresse:";
            // 
            // lbl_teacherSurname
            // 
            this.lbl_teacherSurname.AutoSize = true;
            this.lbl_teacherSurname.Location = new System.Drawing.Point(10, 85);
            this.lbl_teacherSurname.Name = "lbl_teacherSurname";
            this.lbl_teacherSurname.Size = new System.Drawing.Size(68, 15);
            this.lbl_teacherSurname.TabIndex = 24;
            this.lbl_teacherSurname.Text = "Nachname:";
            // 
            // lbl_teacherName
            // 
            this.lbl_teacherName.AutoSize = true;
            this.lbl_teacherName.Location = new System.Drawing.Point(10, 51);
            this.lbl_teacherName.Name = "lbl_teacherName";
            this.lbl_teacherName.Size = new System.Drawing.Size(42, 15);
            this.lbl_teacherName.TabIndex = 23;
            this.lbl_teacherName.Text = "Name:";
            // 
            // cB_sex
            // 
            this.cB_sex.FormattingEnabled = true;
            this.cB_sex.Items.AddRange(new object[] {
            "m",
            "w"});
            this.cB_sex.Location = new System.Drawing.Point(106, 113);
            this.cB_sex.Name = "cB_sex";
            this.cB_sex.Size = new System.Drawing.Size(73, 23);
            this.cB_sex.TabIndex = 44;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(10, 116);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(68, 15);
            this.lbl_sex.TabIndex = 43;
            this.lbl_sex.Text = "Geschlecht:";
            // 
            // cLBTeacher
            // 
            this.cLBTeacher.FormattingEnabled = true;
            this.cLBTeacher.Location = new System.Drawing.Point(348, 12);
            this.cLBTeacher.Name = "cLBTeacher";
            this.cLBTeacher.Size = new System.Drawing.Size(230, 310);
            this.cLBTeacher.TabIndex = 45;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(610, 22);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(49, 15);
            this.lbl_search.TabIndex = 46;
            this.lbl_search.Text = "Suchen:";
            // 
            // Lehrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 334);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.cLBTeacher);
            this.Controls.Add(this.cB_sex);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.tb_teacherSearchDatabase);
            this.Controls.Add(this.dG_teacher);
            this.Controls.Add(this.tB_teacherEmail);
            this.Controls.Add(this.lbl_teacherEmail);
            this.Controls.Add(this.btn_teacherLoad);
            this.Controls.Add(this.btn_teacherDelete);
            this.Controls.Add(this.btn_teacherSave);
            this.Controls.Add(this.btn_teacherBack);
            this.Controls.Add(this.cb_teacherAdd);
            this.Controls.Add(this.dtp_teacherBirth);
            this.Controls.Add(this.tb_teacherAdress);
            this.Controls.Add(this.tb_teacherSurname);
            this.Controls.Add(this.tb_teacherName);
            this.Controls.Add(this.lbl_teacherBirth);
            this.Controls.Add(this.lbl_teacherAdress);
            this.Controls.Add(this.lbl_teacherSurname);
            this.Controls.Add(this.lbl_teacherName);
            this.MaximizeBox = false;
            this.Name = "Lehrer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lehrer";
            this.Load += new System.EventHandler(this.Lehrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dG_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_teacherSearchDatabase;
        private DataGridView dG_teacher;
        private TextBox tB_teacherEmail;
        private Label lbl_teacherEmail;
        private Button btn_teacherLoad;
        private Button btn_teacherDelete;
        private Button btn_teacherSave;
        private Button btn_teacherBack;
        private CheckBox cb_teacherAdd;
        private DateTimePicker dtp_teacherBirth;
        private TextBox tb_teacherAdress;
        private TextBox tb_teacherSurname;
        private TextBox tb_teacherName;
        private Label lbl_teacherBirth;
        private Label lbl_teacherAdress;
        private Label lbl_teacherSurname;
        private Label lbl_teacherName;
        protected ComboBox cB_sex;
        private Label lbl_sex;
        private CheckedListBox cLBTeacher;
        private Label lbl_search;
    }
}