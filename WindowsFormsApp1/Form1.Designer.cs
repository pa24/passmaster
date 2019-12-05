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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passFD = new System.Windows.Forms.TextBox();
            this.passAmo = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.chkFD = new System.Windows.Forms.CheckBox();
            this.chkAmo = new System.Windows.Forms.CheckBox();
            this.trackerOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio.Location = new System.Drawing.Point(12, 19);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(325, 28);
            this.fio.TabIndex = 0;
            this.fio.Text = "Фамилия Имя";
            this.fio.Click += new System.EventHandler(this.fio_Click);
            this.fio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fioTranslite
            // 
            this.fioTranslite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fioTranslite.Location = new System.Drawing.Point(12, 57);
            this.fioTranslite.Name = "fioTranslite";
            this.fioTranslite.Size = new System.Drawing.Size(209, 22);
            this.fioTranslite.TabIndex = 1;
            this.fioTranslite.Text = "Familiya Imya";
            this.fioTranslite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(12, 111);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(325, 30);
            this.mail.TabIndex = 2;
            this.mail.Text = "@yandex.ru";
            this.mail.Click += new System.EventHandler(this.mail_Click);
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // passMail
            // 
            this.passMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passMail.Location = new System.Drawing.Point(12, 147);
            this.passMail.Name = "passMail";
            this.passMail.Size = new System.Drawing.Size(325, 30);
            this.passMail.TabIndex = 3;
            this.passMail.Text = "password";
            this.passMail.Click += new System.EventHandler(this.passMail_Click);
            this.passMail.TextChanged += new System.EventHandler(this.passMail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "FreshDesk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "AmoCRM";
            // 
            // passFD
            // 
            this.passFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passFD.Location = new System.Drawing.Point(12, 218);
            this.passFD.Name = "passFD";
            this.passFD.Size = new System.Drawing.Size(325, 30);
            this.passFD.TabIndex = 8;
            this.passFD.Click += new System.EventHandler(this.passFD_Click);
            this.passFD.TextChanged += new System.EventHandler(this.passFD_TextChanged);
            // 
            // passAmo
            // 
            this.passAmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAmo.Location = new System.Drawing.Point(12, 273);
            this.passAmo.Name = "passAmo";
            this.passAmo.Size = new System.Drawing.Size(325, 30);
            this.passAmo.TabIndex = 10;
            this.passAmo.Click += new System.EventHandler(this.passAmo_Click);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(244, 57);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(93, 42);
            this.generate.TabIndex = 11;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkFD
            // 
            this.chkFD.AutoSize = true;
            this.chkFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFD.Location = new System.Drawing.Point(559, 30);
            this.chkFD.Name = "chkFD";
            this.chkFD.Size = new System.Drawing.Size(48, 21);
            this.chkFD.TabIndex = 12;
            this.chkFD.Text = "FD";
            this.chkFD.UseVisualStyleBackColor = true;
            this.chkFD.CheckedChanged += new System.EventHandler(this.chkFD_CheckedChanged);
            // 
            // chkAmo
            // 
            this.chkAmo.AutoSize = true;
            this.chkAmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAmo.Location = new System.Drawing.Point(613, 30);
            this.chkAmo.Name = "chkAmo";
            this.chkAmo.Size = new System.Drawing.Size(58, 21);
            this.chkAmo.TabIndex = 14;
            this.chkAmo.Text = "Amo";
            this.chkAmo.UseVisualStyleBackColor = true;
            this.chkAmo.CheckedChanged += new System.EventHandler(this.chkAmo_CheckedChanged);
            this.chkAmo.Click += new System.EventHandler(this.chkAmo_Click);
            // 
            // trackerOut
            // 
            this.trackerOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackerOut.Location = new System.Drawing.Point(363, 57);
            this.trackerOut.Multiline = true;
            this.trackerOut.Name = "trackerOut";
            this.trackerOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.trackerOut.Size = new System.Drawing.Size(330, 246);
            this.trackerOut.TabIndex = 16;
            this.trackerOut.Click += new System.EventHandler(this.trackerOut_Click);
            this.trackerOut.TextChanged += new System.EventHandler(this.trackerOut_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Код для трекера:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(489, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Email";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 318);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackerOut);
            this.Controls.Add(this.chkAmo);
            this.Controls.Add(this.chkFD);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.passAmo);
            this.Controls.Add(this.passFD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passMail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.fioTranslite);
            this.Controls.Add(this.fio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passFD;
        private System.Windows.Forms.TextBox passAmo;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.CheckBox chkFD;
        private System.Windows.Forms.CheckBox chkAmo;
        private System.Windows.Forms.TextBox trackerOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

