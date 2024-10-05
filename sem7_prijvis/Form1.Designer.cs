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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(451, 205);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wynik";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(360, 15);
            label1.TabIndex = 0;
            label1.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Adres IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(351, 15);
            label2.TabIndex = 1;
            label2.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Maska";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(373, 15);
            label3.TabIndex = 2;
            label3.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Adres sieci";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(431, 15);
            label4.TabIndex = 3;
            label4.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Adres rozgłoszeniowy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 125);
            label5.Name = "label5";
            label5.Size = new Size(400, 15);
            label5.TabIndex = 4;
            label5.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Minimalny host";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 154);
            label6.Name = "label6";
            label6.Size = new Size(410, 15);
            label6.TabIndex = 5;
            label6.Text = " 11111111.11111111.11111111.11111111 - 255.255.255.255  - Maksymalny host";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 179);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Hostów w sieci: 510";
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
