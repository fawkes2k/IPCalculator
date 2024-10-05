namespace sem7_prijvis
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            adresIP = new Label();
            maska = new Label();
            adresSieci = new Label();
            adresRozgloszeniowy = new Label();
            minimalnyHost = new Label();
            maksymalnyHost = new Label();
            liczbaHostow = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adres IP / Sieci";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(12, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 67);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Maska adresu";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(435, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(liczbaHostow);
            groupBox3.Controls.Add(maksymalnyHost);
            groupBox3.Controls.Add(minimalnyHost);
            groupBox3.Controls.Add(adresRozgloszeniowy);
            groupBox3.Controls.Add(adresSieci);
            groupBox3.Controls.Add(maska);
            groupBox3.Controls.Add(adresIP);
            groupBox3.Location = new Point(12, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(451, 205);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wynik";
            // 
            // adresIP
            // 
            adresIP.AutoSize = true;
            adresIP.Location = new Point(6, 19);
            adresIP.Name = "adresIP";
            adresIP.Size = new Size(360, 15);
            adresIP.TabIndex = 0;
            adresIP.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Adres IP";
            // 
            // maska
            // 
            maska.AutoSize = true;
            maska.Location = new Point(6, 43);
            maska.Name = "maska";
            maska.Size = new Size(351, 15);
            maska.TabIndex = 1;
            maska.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Maska";
            // 
            // adresSieci
            // 
            adresSieci.AutoSize = true;
            adresSieci.Location = new Point(6, 71);
            adresSieci.Name = "adresSieci";
            adresSieci.Size = new Size(373, 15);
            adresSieci.TabIndex = 2;
            adresSieci.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Adres sieci";
            // 
            // adresRozgloszeniowy
            // 
            adresRozgloszeniowy.AutoSize = true;
            adresRozgloszeniowy.Location = new Point(6, 96);
            adresRozgloszeniowy.Name = "adresRozgloszeniowy";
            adresRozgloszeniowy.Size = new Size(431, 15);
            adresRozgloszeniowy.TabIndex = 3;
            adresRozgloszeniowy.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Adres rozgłoszeniowy";
            adresRozgloszeniowy.Click += label4_Click;
            // 
            // minimalnyHost
            // 
            minimalnyHost.AutoSize = true;
            minimalnyHost.Location = new Point(6, 125);
            minimalnyHost.Name = "minimalnyHost";
            minimalnyHost.Size = new Size(400, 15);
            minimalnyHost.TabIndex = 4;
            minimalnyHost.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Minimalny host";
            // 
            // maksymalnyHost
            // 
            maksymalnyHost.AutoSize = true;
            maksymalnyHost.Location = new Point(6, 154);
            maksymalnyHost.Name = "maksymalnyHost";
            maksymalnyHost.Size = new Size(410, 15);
            maksymalnyHost.TabIndex = 5;
            maksymalnyHost.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Maksymalny host";
            // 
            // liczbaHostow
            // 
            liczbaHostow.AutoSize = true;
            liczbaHostow.Location = new Point(6, 178);
            liczbaHostow.Name = "liczbaHostow";
            liczbaHostow.Size = new Size(110, 15);
            liczbaHostow.TabIndex = 6;
            liczbaHostow.Text = "Hostów w sieci: 510";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 381);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Kalkulator adresów IPv4";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private Label adresRozgloszeniowy;
        private Label adresSieci;
        private Label maska;
        private Label adresIP;
        private Label liczbaHostow;
        private Label maksymalnyHost;
        private Label minimalnyHost;
    }
}
