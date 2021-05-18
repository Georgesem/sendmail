namespace sendmail
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
            this.TbEmailFrom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNameFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbEmailTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbSmtpSever = new System.Windows.Forms.TextBox();
            this.TbSmtpPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbAvtName = new System.Windows.Forms.TextBox();
            this.TbAvtPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TbTema = new System.Windows.Forms.TextBox();
            this.TbMessage = new System.Windows.Forms.RichTextBox();
            this.CbSSL = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbEmailFrom
            // 
            this.TbEmailFrom.Location = new System.Drawing.Point(51, 30);
            this.TbEmailFrom.Name = "TbEmailFrom";
            this.TbEmailFrom.Size = new System.Drawing.Size(145, 20);
            this.TbEmailFrom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "отправитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "e-mail";
            // 
            // TbNameFrom
            // 
            this.TbNameFrom.Location = new System.Drawing.Point(51, 59);
            this.TbNameFrom.Name = "TbNameFrom";
            this.TbNameFrom.Size = new System.Drawing.Size(147, 20);
            this.TbNameFrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "e-mail";
            // 
            // TbEmailTo
            // 
            this.TbEmailTo.Location = new System.Drawing.Point(51, 118);
            this.TbEmailTo.Name = "TbEmailTo";
            this.TbEmailTo.Size = new System.Drawing.Size(145, 20);
            this.TbEmailTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Получатель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SMTP Server";
            // 
            // TbSmtpSever
            // 
            this.TbSmtpSever.Location = new System.Drawing.Point(276, 33);
            this.TbSmtpSever.Name = "TbSmtpSever";
            this.TbSmtpSever.Size = new System.Drawing.Size(145, 20);
            this.TbSmtpSever.TabIndex = 10;
            // 
            // TbSmtpPort
            // 
            this.TbSmtpPort.Location = new System.Drawing.Point(492, 34);
            this.TbSmtpPort.Name = "TbSmtpPort";
            this.TbSmtpPort.Size = new System.Drawing.Size(83, 20);
            this.TbSmtpPort.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "SMTP Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Авторизация";
            // 
            // TbAvtName
            // 
            this.TbAvtName.Location = new System.Drawing.Point(276, 102);
            this.TbAvtName.Name = "TbAvtName";
            this.TbAvtName.Size = new System.Drawing.Size(145, 20);
            this.TbAvtName.TabIndex = 14;
            // 
            // TbAvtPass
            // 
            this.TbAvtPass.Location = new System.Drawing.Point(430, 102);
            this.TbAvtPass.Name = "TbAvtPass";
            this.TbAvtPass.Size = new System.Drawing.Size(145, 20);
            this.TbAvtPass.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Логин";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Пароль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Тема письма";
            // 
            // TbTema
            // 
            this.TbTema.Location = new System.Drawing.Point(89, 156);
            this.TbTema.Name = "TbTema";
            this.TbTema.Size = new System.Drawing.Size(145, 20);
            this.TbTema.TabIndex = 19;
            // 
            // TbMessage
            // 
            this.TbMessage.Location = new System.Drawing.Point(2, 207);
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(599, 75);
            this.TbMessage.TabIndex = 21;
            this.TbMessage.Text = "";
            // 
            // CbSSL
            // 
            this.CbSSL.AutoSize = true;
            this.CbSSL.Location = new System.Drawing.Point(382, 66);
            this.CbSSL.Name = "CbSSL";
            this.CbSSL.Size = new System.Drawing.Size(46, 17);
            this.CbSSL.TabIndex = 22;
            this.CbSSL.Text = "SSL";
            this.CbSSL.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CbSSL);
            this.Controls.Add(this.TbMessage);
            this.Controls.Add(this.TbTema);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbAvtPass);
            this.Controls.Add(this.TbAvtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbSmtpPort);
            this.Controls.Add(this.TbSmtpSever);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbEmailTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbNameFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbEmailFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbEmailFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNameFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbEmailTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbSmtpSever;
        private System.Windows.Forms.TextBox TbSmtpPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbAvtName;
        private System.Windows.Forms.TextBox TbAvtPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbTema;
        private System.Windows.Forms.RichTextBox TbMessage;
        private System.Windows.Forms.CheckBox CbSSL;
        private System.Windows.Forms.Button button2;
    }
}

