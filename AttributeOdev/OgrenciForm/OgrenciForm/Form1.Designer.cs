namespace OgrenciForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            txtAd = new TextBox();
            btnBilgileriDoğrula = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 68);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 103);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 136);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci Bölümü :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(233, 103);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 23);
            txtSoyad.TabIndex = 3;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(233, 136);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 23);
            txtBolum.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(233, 68);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 23);
            txtAd.TabIndex = 5;
            txtAd.Text = " ";
            // 
            // btnBilgileriDoğrula
            // 
            btnBilgileriDoğrula.Location = new Point(149, 205);
            btnBilgileriDoğrula.Name = "btnBilgileriDoğrula";
            btnBilgileriDoğrula.Size = new Size(185, 23);
            btnBilgileriDoğrula.TabIndex = 6;
            btnBilgileriDoğrula.Text = "BİLGİLERİ DOĞRULA";
            btnBilgileriDoğrula.UseVisualStyleBackColor = true;
            btnBilgileriDoğrula.Click += btnBilgileriDoğrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(227, 242);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 15);
            lblSonuc.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnBilgileriDoğrula);
            Controls.Add(txtAd);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private TextBox txtAd;
        private Button btnBilgileriDoğrula;
        private Label lblSonuc;
    }
}
