namespace Phonebook.Windowsform
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            lst_liste = new ListBox();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txt_phone1 = new TextBox();
            txt_address = new TextBox();
            txt_website = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txt_emailAdress = new TextBox();
            label6 = new Label();
            txt_phone3 = new TextBox();
            label5 = new Label();
            txt_phone2 = new TextBox();
            label4 = new Label();
            txt_surname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            txt_description = new TextBox();
            btn_register = new Button();
            btn_update = new Button();
            group = new GroupBox();
            button3 = new Button();
            btn_json = new Button();
            btn_csv = new Button();
            btn_xml_ver = new Button();
            lbl_durum = new Label();
            btn_delete = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            group.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lst_liste);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 480);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rehber Liste";
            // 
            // lst_liste
            // 
            lst_liste.FormattingEnabled = true;
            lst_liste.ItemHeight = 15;
            lst_liste.Location = new Point(6, 18);
            lst_liste.Name = "lst_liste";
            lst_liste.Size = new Size(188, 454);
            lst_liste.TabIndex = 0;
            lst_liste.DoubleClick += lst_liste_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(230, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(670, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Rehber Kaydı";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(664, 257);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txt_phone1);
            tabPage1.Controls.Add(txt_address);
            tabPage1.Controls.Add(txt_website);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txt_emailAdress);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_phone3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txt_phone2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txt_surname);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txt_name);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 229);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kişisel Bilgiler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_phone1
            // 
            txt_phone1.Location = new Point(70, 72);
            txt_phone1.Name = "txt_phone1";
            txt_phone1.Size = new Size(188, 23);
            txt_phone1.TabIndex = 2;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(291, 40);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(359, 184);
            txt_address.TabIndex = 1;
            // 
            // txt_website
            // 
            txt_website.Location = new Point(70, 188);
            txt_website.Name = "txt_website";
            txt_website.Size = new Size(188, 23);
            txt_website.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 22);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 0;
            label8.Text = "Adres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 191);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 0;
            label7.Text = "Web Site";
            // 
            // txt_emailAdress
            // 
            txt_emailAdress.Location = new Point(70, 159);
            txt_emailAdress.Name = "txt_emailAdress";
            txt_emailAdress.Size = new Size(188, 23);
            txt_emailAdress.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 162);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 0;
            label6.Text = "Email Adres";
            // 
            // txt_phone3
            // 
            txt_phone3.Location = new Point(70, 130);
            txt_phone3.Name = "txt_phone3";
            txt_phone3.Size = new Size(188, 23);
            txt_phone3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 133);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 0;
            label5.Text = "Telefon III";
            // 
            // txt_phone2
            // 
            txt_phone2.Location = new Point(70, 101);
            txt_phone2.Name = "txt_phone2";
            txt_phone2.Size = new Size(188, 23);
            txt_phone2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 104);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefon II";
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(70, 43);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(188, 23);
            txt_surname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefon I";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(70, 14);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(188, 23);
            txt_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txt_description);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(656, 229);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Açıklama Bilgisi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(6, 6);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(644, 220);
            txt_description.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(240, 295);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(660, 23);
            btn_register.TabIndex = 2;
            btn_register.Text = "Yeni Kayıt";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(240, 324);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(328, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Güncelle";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // group
            // 
            group.Controls.Add(button3);
            group.Controls.Add(btn_json);
            group.Controls.Add(btn_csv);
            group.Controls.Add(btn_xml_ver);
            group.Controls.Add(lbl_durum);
            group.Location = new Point(240, 358);
            group.Name = "group";
            group.Size = new Size(812, 128);
            group.TabIndex = 3;
            group.TabStop = false;
            group.Text = "Data AL/ Ver";
            // 
            // button3
            // 
            button3.Location = new Point(260, 37);
            button3.Name = "button3";
            button3.Size = new Size(75, 61);
            button3.TabIndex = 2;
            button3.Text = "XML AL";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_json
            // 
            btn_json.Location = new Point(179, 37);
            btn_json.Name = "btn_json";
            btn_json.Size = new Size(75, 61);
            btn_json.TabIndex = 2;
            btn_json.Text = "JSON VER";
            btn_json.UseVisualStyleBackColor = true;
            btn_json.Click += btn_json_Click;
            // 
            // btn_csv
            // 
            btn_csv.Location = new Point(98, 37);
            btn_csv.Name = "btn_csv";
            btn_csv.Size = new Size(75, 61);
            btn_csv.TabIndex = 2;
            btn_csv.Text = "CSV VER";
            btn_csv.UseVisualStyleBackColor = true;
            btn_csv.Click += btn_csv_Click;
            // 
            // btn_xml_ver
            // 
            btn_xml_ver.Location = new Point(17, 37);
            btn_xml_ver.Name = "btn_xml_ver";
            btn_xml_ver.Size = new Size(75, 61);
            btn_xml_ver.TabIndex = 2;
            btn_xml_ver.Text = "XML VER";
            btn_xml_ver.UseVisualStyleBackColor = true;
            btn_xml_ver.Click += btn_xml_ver_Click;
            // 
            // lbl_durum
            // 
            lbl_durum.AutoSize = true;
            lbl_durum.Font = new Font("Segoe UI", 10F);
            lbl_durum.Location = new Point(358, 47);
            lbl_durum.Name = "lbl_durum";
            lbl_durum.Size = new Size(122, 19);
            lbl_durum.TabIndex = 0;
            lbl_durum.Text = "Durum Beklemede";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(574, 324);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(328, 23);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Sil";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 498);
            Controls.Add(group);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_register);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            group.ResumeLayout(false);
            group.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txt_phone2;
        private Label label4;
        private TextBox txt_surname;
        private Label label2;
        private Label label3;
        private TextBox txt_name;
        private Label label1;
        private TextBox txt_emailAdress;
        private Label label6;
        private TextBox txt_phone3;
        private Label label5;
        private TextBox txt_address;
        private TextBox txt_website;
        private Label label8;
        private Label label7;
        private Button btn_register;
        private TextBox txt_description;
        private TextBox txt_phone1;
        private Button btn_update;
        private GroupBox group;
        private Button btn_xml_ver;
        private ListBox lst_liste;
        private Button button3;
        private Button btn_json;
        private Button btn_csv;
        private Label lbl_durum;
        private Button btn_delete;
    }
}