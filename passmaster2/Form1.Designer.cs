namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fio = new System.Windows.Forms.TextBox();
            this.fioTranslite = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.passMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passGitea = new System.Windows.Forms.TextBox();
            this.passJenkins = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.trackerOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OnlyFirstName = new System.Windows.Forms.TextBox();
            this.OnlySecondName = new System.Windows.Forms.TextBox();
            this.shortMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbDev = new System.Windows.Forms.CheckBox();
            this.tbxGiteaLogin = new System.Windows.Forms.TextBox();
            this.tbxJenkinsLogin = new System.Windows.Forms.TextBox();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio.Location = new System.Drawing.Point(9, 15);
            this.fio.Margin = new System.Windows.Forms.Padding(2);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(245, 24);
            this.fio.TabIndex = 0;
            this.fio.Text = "Фамилия Имя";
            this.fio.Click += new System.EventHandler(this.fio_Click);
            this.fio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fio_MouseClick);
            this.fio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fio.DoubleClick += new System.EventHandler(this.fio_DoubleClick);
            // 
            // fioTranslite
            // 
            this.fioTranslite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fioTranslite.Location = new System.Drawing.Point(10, 84);
            this.fioTranslite.Margin = new System.Windows.Forms.Padding(2);
            this.fioTranslite.Name = "fioTranslite";
            this.fioTranslite.Size = new System.Drawing.Size(158, 19);
            this.fioTranslite.TabIndex = 1;
            this.fioTranslite.Text = "Familiya Imya";
            this.fioTranslite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(10, 157);
            this.mail.Margin = new System.Windows.Forms.Padding(2);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(245, 26);
            this.mail.TabIndex = 2;
            this.mail.Text = "@yandex.ru";
            this.mail.Click += new System.EventHandler(this.mail_Click);
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // passMail
            // 
            this.passMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passMail.Location = new System.Drawing.Point(10, 186);
            this.passMail.Margin = new System.Windows.Forms.Padding(2);
            this.passMail.Name = "passMail";
            this.passMail.Size = new System.Drawing.Size(245, 26);
            this.passMail.TabIndex = 3;
            this.passMail.Text = "password";
            this.passMail.Click += new System.EventHandler(this.passMail_Click);
            this.passMail.TextChanged += new System.EventHandler(this.passMail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Почта";
            // 
            // passGitea
            // 
            this.passGitea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passGitea.Location = new System.Drawing.Point(9, 266);
            this.passGitea.Margin = new System.Windows.Forms.Padding(2);
            this.passGitea.Name = "passGitea";
            this.passGitea.Size = new System.Drawing.Size(245, 26);
            this.passGitea.TabIndex = 8;
            this.passGitea.Visible = false;
            this.passGitea.Click += new System.EventHandler(this.passFD_Click);
            this.passGitea.TextChanged += new System.EventHandler(this.passFD_TextChanged);
            // 
            // passJenkins
            // 
            this.passJenkins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passJenkins.Location = new System.Drawing.Point(8, 343);
            this.passJenkins.Margin = new System.Windows.Forms.Padding(2);
            this.passJenkins.Name = "passJenkins";
            this.passJenkins.Size = new System.Drawing.Size(245, 26);
            this.passJenkins.TabIndex = 10;
            this.passJenkins.Visible = false;
            this.passJenkins.Click += new System.EventHandler(this.passAmo_Click);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(185, 119);
            this.generate.Margin = new System.Windows.Forms.Padding(2);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(70, 34);
            this.generate.TabIndex = 11;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackerOut
            // 
            this.trackerOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackerOut.Location = new System.Drawing.Point(272, 46);
            this.trackerOut.Margin = new System.Windows.Forms.Padding(2);
            this.trackerOut.Multiline = true;
            this.trackerOut.Name = "trackerOut";
            this.trackerOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.trackerOut.Size = new System.Drawing.Size(248, 323);
            this.trackerOut.TabIndex = 16;
            this.trackerOut.Click += new System.EventHandler(this.trackerOut_Click);
            this.trackerOut.TextChanged += new System.EventHandler(this.trackerOut_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Код для трекера:";
            // 
            // OnlyFirstName
            // 
            this.OnlyFirstName.Location = new System.Drawing.Point(9, 46);
            this.OnlyFirstName.Name = "OnlyFirstName";
            this.OnlyFirstName.Size = new System.Drawing.Size(116, 20);
            this.OnlyFirstName.TabIndex = 19;
            this.OnlyFirstName.Click += new System.EventHandler(this.OnlyFirstName_Click);
            this.OnlyFirstName.TextChanged += new System.EventHandler(this.OnlyFirstName_TextChanged);
            // 
            // OnlySecondName
            // 
            this.OnlySecondName.Location = new System.Drawing.Point(131, 46);
            this.OnlySecondName.Name = "OnlySecondName";
            this.OnlySecondName.Size = new System.Drawing.Size(123, 20);
            this.OnlySecondName.TabIndex = 20;
            this.OnlySecondName.Click += new System.EventHandler(this.OnlySecondName_Click);
            this.OnlySecondName.TextChanged += new System.EventHandler(this.OnlySecondName_TextChanged);
            // 
            // shortMail
            // 
            this.shortMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortMail.Location = new System.Drawing.Point(9, 127);
            this.shortMail.Margin = new System.Windows.Forms.Padding(2);
            this.shortMail.Name = "shortMail";
            this.shortMail.Size = new System.Drawing.Size(144, 26);
            this.shortMail.TabIndex = 21;
            this.shortMail.Text = "short Email";
            this.shortMail.Click += new System.EventHandler(this.shortMail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gitea";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Jenkins";
            this.label4.Visible = false;
            // 
            // chkbDev
            // 
            this.chkbDev.AutoSize = true;
            this.chkbDev.Location = new System.Drawing.Point(444, 25);
            this.chkbDev.Name = "chkbDev";
            this.chkbDev.Size = new System.Drawing.Size(75, 17);
            this.chkbDev.TabIndex = 24;
            this.chkbDev.Text = "Developer";
            this.chkbDev.UseVisualStyleBackColor = true;
            this.chkbDev.CheckedChanged += new System.EventHandler(this.chkbDev_CheckedChanged);
            // 
            // tbxGiteaLogin
            // 
            this.tbxGiteaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGiteaLogin.Location = new System.Drawing.Point(8, 236);
            this.tbxGiteaLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGiteaLogin.Name = "tbxGiteaLogin";
            this.tbxGiteaLogin.Size = new System.Drawing.Size(245, 26);
            this.tbxGiteaLogin.TabIndex = 25;
            this.tbxGiteaLogin.Visible = false;
            this.tbxGiteaLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxGiteaLogin_MouseClick);
            this.tbxGiteaLogin.TextChanged += new System.EventHandler(this.tbxGiteaLogin_TextChanged);
            // 
            // tbxJenkinsLogin
            // 
            this.tbxJenkinsLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxJenkinsLogin.Location = new System.Drawing.Point(8, 313);
            this.tbxJenkinsLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxJenkinsLogin.Name = "tbxJenkinsLogin";
            this.tbxJenkinsLogin.Size = new System.Drawing.Size(245, 26);
            this.tbxJenkinsLogin.TabIndex = 26;
            this.tbxJenkinsLogin.Visible = false;
            this.tbxJenkinsLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxJenkinsLogin_MouseClick);
            this.tbxJenkinsLogin.TextChanged += new System.EventHandler(this.tbxJenkinsLogin_TextChanged);
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Items.AddRange(new object[] {
            "Гостиницы",
            "Контрактинг",
            "Поддержка",
            "Продажи",
            "Разработка",
            "Сопровождение"});
            this.cmbEmployeeType.Location = new System.Drawing.Point(187, 84);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(68, 21);
            this.cmbEmployeeType.Sorted = true;
            this.cmbEmployeeType.TabIndex = 27;
            this.cmbEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 398);
            this.Controls.Add(this.cmbEmployeeType);
            this.Controls.Add(this.tbxJenkinsLogin);
            this.Controls.Add(this.tbxGiteaLogin);
            this.Controls.Add(this.chkbDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shortMail);
            this.Controls.Add(this.OnlySecondName);
            this.Controls.Add(this.OnlyFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackerOut);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.passJenkins);
            this.Controls.Add(this.passGitea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passMail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.fioTranslite);
            this.Controls.Add(this.fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Master";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox fioTranslite;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox passMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passGitea;
        private System.Windows.Forms.TextBox passJenkins;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox trackerOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OnlyFirstName;
        private System.Windows.Forms.TextBox OnlySecondName;
        private System.Windows.Forms.TextBox shortMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbDev;
        private System.Windows.Forms.TextBox tbxGiteaLogin;
        private System.Windows.Forms.TextBox tbxJenkinsLogin;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
    }
}

