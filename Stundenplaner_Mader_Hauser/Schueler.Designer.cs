﻿namespace Stundenplaner_Mader_Hauser
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
            this.tb_studentClass = new System.Windows.Forms.TextBox();
            this.dtp_studentBirth = new System.Windows.Forms.DateTimePicker();
            this.cb_studentAdd = new System.Windows.Forms.CheckBox();
            this.btn_studentBack = new System.Windows.Forms.Button();
            this.btn_studentSave = new System.Windows.Forms.Button();
            this.btn_studentAdd = new System.Windows.Forms.Button();
            this.btn_studentDelete = new System.Windows.Forms.Button();
            this.btn_studentLoad = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tB_email = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lbl_studentAdress.Location = new System.Drawing.Point(12, 177);
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
            this.lbl_studentClass.Location = new System.Drawing.Point(12, 257);
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
            this.tb_studentAdress.Location = new System.Drawing.Point(105, 174);
            this.tb_studentAdress.Multiline = true;
            this.tb_studentAdress.Name = "tb_studentAdress";
            this.tb_studentAdress.Size = new System.Drawing.Size(216, 74);
            this.tb_studentAdress.TabIndex = 9;
            // 
            // tb_studentClass
            // 
            this.tb_studentClass.Location = new System.Drawing.Point(105, 254);
            this.tb_studentClass.Name = "tb_studentClass";
            this.tb_studentClass.Size = new System.Drawing.Size(216, 23);
            this.tb_studentClass.TabIndex = 10;
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
            // 
            // btn_studentBack
            // 
            this.btn_studentBack.Location = new System.Drawing.Point(9, 334);
            this.btn_studentBack.Name = "btn_studentBack";
            this.btn_studentBack.Size = new System.Drawing.Size(89, 28);
            this.btn_studentBack.TabIndex = 13;
            this.btn_studentBack.Text = "Zurück";
            this.btn_studentBack.UseVisualStyleBackColor = true;
            this.btn_studentBack.Click += new System.EventHandler(this.btn_studentBack_Click);
            // 
            // btn_studentSave
            // 
            this.btn_studentSave.Location = new System.Drawing.Point(541, 334);
            this.btn_studentSave.Name = "btn_studentSave";
            this.btn_studentSave.Size = new System.Drawing.Size(89, 28);
            this.btn_studentSave.TabIndex = 14;
            this.btn_studentSave.Text = "Speichern";
            this.btn_studentSave.UseVisualStyleBackColor = true;
            // 
            // btn_studentAdd
            // 
            this.btn_studentAdd.Location = new System.Drawing.Point(446, 334);
            this.btn_studentAdd.Name = "btn_studentAdd";
            this.btn_studentAdd.Size = new System.Drawing.Size(89, 28);
            this.btn_studentAdd.TabIndex = 15;
            this.btn_studentAdd.Text = "Hinzufügen";
            this.btn_studentAdd.UseVisualStyleBackColor = true;
            // 
            // btn_studentDelete
            // 
            this.btn_studentDelete.Location = new System.Drawing.Point(541, 300);
            this.btn_studentDelete.Name = "btn_studentDelete";
            this.btn_studentDelete.Size = new System.Drawing.Size(89, 28);
            this.btn_studentDelete.TabIndex = 16;
            this.btn_studentDelete.Text = "Löschen";
            this.btn_studentDelete.UseVisualStyleBackColor = true;
            // 
            // btn_studentLoad
            // 
            this.btn_studentLoad.Location = new System.Drawing.Point(446, 300);
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
            this.lbl_email.Location = new System.Drawing.Point(12, 148);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 15);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "E-Mail:";
            // 
            // tB_email
            // 
            this.tB_email.Location = new System.Drawing.Point(105, 145);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(216, 23);
            this.tB_email.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(255, 229);
            this.dataGridView1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 23);
            this.textBox1.TabIndex = 21;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(541, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 28);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "Suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // Schueler
            // 
            this.ClientSize = new System.Drawing.Size(642, 368);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tB_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_studentLoad);
            this.Controls.Add(this.btn_studentDelete);
            this.Controls.Add(this.btn_studentAdd);
            this.Controls.Add(this.btn_studentSave);
            this.Controls.Add(this.btn_studentBack);
            this.Controls.Add(this.cb_studentAdd);
            this.Controls.Add(this.dtp_studentBirth);
            this.Controls.Add(this.tb_studentClass);
            this.Controls.Add(this.tb_studentAdress);
            this.Controls.Add(this.tb_studentSurname);
            this.Controls.Add(this.tb_studentName);
            this.Controls.Add(this.lbl_studentClass);
            this.Controls.Add(this.lbl_studentBirth);
            this.Controls.Add(this.lbl_studentAdress);
            this.Controls.Add(this.lbl_studentSurname);
            this.Controls.Add(this.lbl_studentName);
            this.Name = "Schueler";
            this.Load += new System.EventHandler(this.Schueler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private TextBox tb_studentClass;
        private DateTimePicker dtp_studentBirth;
        private CheckBox cb_studentAdd;
        private Button btn_studentBack;
        private Button btn_studentSave;
        private Button btn_studentAdd;
        private Button btn_studentDelete;
        private Button btn_studentLoad;
        private Label lbl_email;
        private TextBox tB_email;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btn_search;
    }
}