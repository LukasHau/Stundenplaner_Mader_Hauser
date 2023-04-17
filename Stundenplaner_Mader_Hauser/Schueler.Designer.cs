namespace Stundenplaner_Mader_Hauser
{
    partial class Schueler
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
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_studentSurname = new System.Windows.Forms.Label();
            this.lbl_studentAdress = new System.Windows.Forms.Label();
            this.lbl_studentBirth = new System.Windows.Forms.Label();
            this.lbl_studentClass = new System.Windows.Forms.Label();
            this.tb_studentName = new System.Windows.Forms.TextBox();
            this.tb_studentSurname = new System.Windows.Forms.TextBox();
            this.tb_studentAdress = new System.Windows.Forms.TextBox();
            this.dtp_studentBirth = new System.Windows.Forms.DateTimePicker();
            this.cb_studentAdd = new System.Windows.Forms.CheckBox();
            this.btn_studentBack = new System.Windows.Forms.Button();
            this.btn_studentSave = new System.Windows.Forms.Button();
            this.btn_studentDelete = new System.Windows.Forms.Button();
            this.btn_studentLoad = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tB_email = new System.Windows.Forms.TextBox();
            this.dG_student = new System.Windows.Forms.DataGridView();
            this.tb_searchDatabase = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.cB_sex = new System.Windows.Forms.ComboBox();
            this.cB_class = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dG_student)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Location = new System.Drawing.Point(9, 51);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(42, 15);
            this.lbl_studentName.TabIndex = 0;
            this.lbl_studentName.Text = "Name:";
            // 
            // lbl_studentSurname
            // 
            this.lbl_studentSurname.AutoSize = true;
            this.lbl_studentSurname.Location = new System.Drawing.Point(9, 85);
            this.lbl_studentSurname.Name = "lbl_studentSurname";
            this.lbl_studentSurname.Size = new System.Drawing.Size(68, 15);
            this.lbl_studentSurname.TabIndex = 1;
            this.lbl_studentSurname.Text = "Nachname:";
            // 
            // lbl_studentAdress
            // 
            this.lbl_studentAdress.AutoSize = true;
            this.lbl_studentAdress.Location = new System.Drawing.Point(12, 212);
            this.lbl_studentAdress.Name = "lbl_studentAdress";
            this.lbl_studentAdress.Size = new System.Drawing.Size(51, 15);
            this.lbl_studentAdress.TabIndex = 2;
            this.lbl_studentAdress.Text = "Adresse:";
            // 
            // lbl_studentBirth
            // 
            this.lbl_studentBirth.AutoSize = true;
            this.lbl_studentBirth.Location = new System.Drawing.Point(9, 119);
            this.lbl_studentBirth.Name = "lbl_studentBirth";
            this.lbl_studentBirth.Size = new System.Drawing.Size(86, 15);
            this.lbl_studentBirth.TabIndex = 3;
            this.lbl_studentBirth.Text = "Geburtsdatum:";
            // 
            // lbl_studentClass
            // 
            this.lbl_studentClass.AutoSize = true;
            this.lbl_studentClass.Location = new System.Drawing.Point(12, 292);
            this.lbl_studentClass.Name = "lbl_studentClass";
            this.lbl_studentClass.Size = new System.Drawing.Size(42, 15);
            this.lbl_studentClass.TabIndex = 4;
            this.lbl_studentClass.Text = "Klasse:";
            // 
            // tb_studentName
            // 
            this.tb_studentName.Location = new System.Drawing.Point(105, 48);
            this.tb_studentName.Name = "tb_studentName";
            this.tb_studentName.Size = new System.Drawing.Size(216, 23);
            this.tb_studentName.TabIndex = 6;
            // 
            // tb_studentSurname
            // 
            this.tb_studentSurname.Location = new System.Drawing.Point(105, 82);
            this.tb_studentSurname.Name = "tb_studentSurname";
            this.tb_studentSurname.Size = new System.Drawing.Size(216, 23);
            this.tb_studentSurname.TabIndex = 7;
            // 
            // tb_studentAdress
            // 
            this.tb_studentAdress.Location = new System.Drawing.Point(105, 209);
            this.tb_studentAdress.Multiline = true;
            this.tb_studentAdress.Name = "tb_studentAdress";
            this.tb_studentAdress.Size = new System.Drawing.Size(216, 74);
            this.tb_studentAdress.TabIndex = 9;
            // 
            // dtp_studentBirth
            // 
            this.dtp_studentBirth.Location = new System.Drawing.Point(105, 113);
            this.dtp_studentBirth.Name = "dtp_studentBirth";
            this.dtp_studentBirth.Size = new System.Drawing.Size(216, 23);
            this.dtp_studentBirth.TabIndex = 11;
            // 
            // cb_studentAdd
            // 
            this.cb_studentAdd.AutoSize = true;
            this.cb_studentAdd.Location = new System.Drawing.Point(12, 12);
            this.cb_studentAdd.Name = "cb_studentAdd";
            this.cb_studentAdd.Size = new System.Drawing.Size(166, 19);
            this.cb_studentAdd.TabIndex = 12;
            this.cb_studentAdd.Text = "Neuen Schüler hinzufügen";
            this.cb_studentAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cb_studentAdd.UseVisualStyleBackColor = true;
            this.cb_studentAdd.CheckedChanged += new System.EventHandler(this.cb_studentAdd_CheckedChanged);
            // 
            // btn_studentBack
            // 
            this.btn_studentBack.Location = new System.Drawing.Point(9, 329);
            this.btn_studentBack.Name = "btn_studentBack";
            this.btn_studentBack.Size = new System.Drawing.Size(89, 28);
            this.btn_studentBack.TabIndex = 13;
            this.btn_studentBack.Text = "Zurück";
            this.btn_studentBack.UseVisualStyleBackColor = true;
            this.btn_studentBack.Click += new System.EventHandler(this.btn_studentBack_Click);
            // 
            // btn_studentSave
            // 
            this.btn_studentSave.Location = new System.Drawing.Point(584, 329);
            this.btn_studentSave.Name = "btn_studentSave";
            this.btn_studentSave.Size = new System.Drawing.Size(89, 28);
            this.btn_studentSave.TabIndex = 14;
            this.btn_studentSave.Text = "Speichern";
            this.btn_studentSave.UseVisualStyleBackColor = true;
            this.btn_studentSave.Click += new System.EventHandler(this.btn_studentSave_Click);
            // 
            // btn_studentDelete
            // 
            this.btn_studentDelete.Location = new System.Drawing.Point(489, 329);
            this.btn_studentDelete.Name = "btn_studentDelete";
            this.btn_studentDelete.Size = new System.Drawing.Size(89, 28);
            this.btn_studentDelete.TabIndex = 16;
            this.btn_studentDelete.Text = "Löschen";
            this.btn_studentDelete.UseVisualStyleBackColor = true;
            this.btn_studentDelete.Click += new System.EventHandler(this.btn_studentDelete_Click);
            // 
            // btn_studentLoad
            // 
            this.btn_studentLoad.Location = new System.Drawing.Point(394, 329);
            this.btn_studentLoad.Name = "btn_studentLoad";
            this.btn_studentLoad.Size = new System.Drawing.Size(89, 28);
            this.btn_studentLoad.TabIndex = 17;
            this.btn_studentLoad.Text = "Laden";
            this.btn_studentLoad.UseVisualStyleBackColor = true;
            this.btn_studentLoad.Click += new System.EventHandler(this.btn_studentLoad_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 183);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 15);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "E-Mail:";
            // 
            // tB_email
            // 
            this.tB_email.Location = new System.Drawing.Point(105, 180);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(216, 23);
            this.tB_email.TabIndex = 19;
            // 
            // dG_student
            // 
            this.dG_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_student.Location = new System.Drawing.Point(375, 48);
            this.dG_student.Name = "dG_student";
            this.dG_student.ReadOnly = true;
            this.dG_student.RowTemplate.Height = 25;
            this.dG_student.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dG_student.Size = new System.Drawing.Size(298, 264);
            this.dG_student.TabIndex = 20;
            this.dG_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_student_CellClick);
            this.dG_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_student_CellContentClick);
            // 
            // tb_searchDatabase
            // 
            this.tb_searchDatabase.Location = new System.Drawing.Point(430, 19);
            this.tb_searchDatabase.Name = "tb_searchDatabase";
            this.tb_searchDatabase.Size = new System.Drawing.Size(243, 23);
            this.tb_searchDatabase.TabIndex = 21;
            this.tb_searchDatabase.TextChanged += new System.EventHandler(this.tb_searchDatabase_TextChanged);
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(9, 149);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(68, 15);
            this.lbl_sex.TabIndex = 23;
            this.lbl_sex.Text = "Geschlecht:";
            this.lbl_sex.Click += new System.EventHandler(this.label1_Click);
            // 
            // cB_sex
            // 
            this.cB_sex.FormattingEnabled = true;
            this.cB_sex.Items.AddRange(new object[] {
            "m",
            "w"});
            this.cB_sex.Location = new System.Drawing.Point(105, 146);
            this.cB_sex.Name = "cB_sex";
            this.cB_sex.Size = new System.Drawing.Size(73, 23);
            this.cB_sex.TabIndex = 24;
            this.cB_sex.SelectedIndexChanged += new System.EventHandler(this.cB_sex_SelectedIndexChanged);
            // 
            // cB_class
            // 
            this.cB_class.FormattingEnabled = true;
            this.cB_class.Location = new System.Drawing.Point(105, 289);
            this.cB_class.Name = "cB_class";
            this.cB_class.Size = new System.Drawing.Size(216, 23);
            this.cB_class.TabIndex = 25;
            this.cB_class.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(375, 22);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(49, 15);
            this.lbl_search.TabIndex = 26;
            this.lbl_search.Text = "Suchen:";
            // 
            // Schueler
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 364);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.cB_class);
            this.Controls.Add(this.cB_sex);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.tb_searchDatabase);
            this.Controls.Add(this.dG_student);
            this.Controls.Add(this.tB_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_studentLoad);
            this.Controls.Add(this.btn_studentDelete);
            this.Controls.Add(this.btn_studentSave);
            this.Controls.Add(this.btn_studentBack);
            this.Controls.Add(this.cb_studentAdd);
            this.Controls.Add(this.dtp_studentBirth);
            this.Controls.Add(this.tb_studentAdress);
            this.Controls.Add(this.tb_studentSurname);
            this.Controls.Add(this.tb_studentName);
            this.Controls.Add(this.lbl_studentClass);
            this.Controls.Add(this.lbl_studentBirth);
            this.Controls.Add(this.lbl_studentAdress);
            this.Controls.Add(this.lbl_studentSurname);
            this.Controls.Add(this.lbl_studentName);
            this.MaximizeBox = false;
            this.Name = "Schueler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Schueler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dG_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lbl_studentName;
        private Label lbl_studentSurname;
        private Label lbl_studentAdress;
        private Label lbl_studentBirth;
        private Label lbl_studentClass;
        private TextBox tb_studentName;
        private TextBox tb_studentSurname;
        private TextBox tb_studentAdress;
        private DateTimePicker dtp_studentBirth;
        private CheckBox cb_studentAdd;
        private Button btn_studentBack;
        private Button btn_studentSave;
        private Button btn_studentDelete;
        private Button btn_studentLoad;
        private Label lbl_email;
        private TextBox tB_email;
        private DataGridView dG_student;
        private TextBox tb_searchDatabase;
        private Label lbl_sex;
        protected ComboBox cB_sex;
        protected ComboBox cB_class;
        private Label lbl_search;
    }
}