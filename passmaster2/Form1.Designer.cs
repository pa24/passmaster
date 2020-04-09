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
            this.passFD = new System.Windows.Forms.TextBox();
            this.passAmo = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.trackerOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OnlyFirstName = new System.Windows.Forms.TextBox();
            this.OnlySecondName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio.Location = new System.Drawing.Point(9, 15);
            this.fio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(245, 24);
            this.fio.TabIndex = 0;
            this.fio.Text = "Фамилия Имя";
            this.fio.Click += new System.EventHandler(this.fio_Click);
            this.fio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fioTranslite
            // 
            this.fioTranslite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fioTranslite.Location = new System.Drawing.Point(10, 84);
            this.fioTranslite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fioTranslite.Name = "fioTranslite";
            this.fioTranslite.Size = new System.Drawing.Size(158, 19);
            this.fioTranslite.TabIndex = 1;
            this.fioTranslite.Text = "Familiya Imya";
            this.fioTranslite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(10, 128);
            this.mail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.passMail.Location = new System.Drawing.Point(10, 157);
            this.passMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // passFD
            // 
            this.passFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passFD.Location = new System.Drawing.Point(11, 196);
            this.passFD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passFD.Name = "passFD";
            this.passFD.Size = new System.Drawing.Size(245, 26);
            this.passFD.TabIndex = 8;
            this.passFD.Click += new System.EventHandler(this.passFD_Click);
            this.passFD.TextChanged += new System.EventHandler(this.passFD_TextChanged);
            // 
            // passAmo
            // 
            this.passAmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAmo.Location = new System.Drawing.Point(12, 226);
            this.passAmo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passAmo.Name = "passAmo";
            this.passAmo.Size = new System.Drawing.Size(245, 26);
            this.passAmo.TabIndex = 10;
            this.passAmo.Click += new System.EventHandler(this.passAmo_Click);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(184, 84);
            this.generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.trackerOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackerOut.Multiline = true;
            this.trackerOut.Name = "trackerOut";
            this.trackerOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.trackerOut.Size = new System.Drawing.Size(248, 206);
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
            // Form1
            // 
            this.AcceptButton = this.generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.Controls.Add(this.OnlySecondName);
            this.Controls.Add(this.OnlyFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackerOut);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.passAmo);
            this.Controls.Add(this.passFD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passMail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.fioTranslite);
            this.Controls.Add(this.fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox passFD;
        private System.Windows.Forms.TextBox passAmo;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox trackerOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OnlyFirstName;
        private System.Windows.Forms.TextBox OnlySecondName;
    }
}

