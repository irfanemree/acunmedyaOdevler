namespace ArabaBilgi
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
            cmbMarka = new ComboBox();
            cmbKapi = new ComboBox();
            label2 = new Label();
            cmbPencere = new ComboBox();
            label3 = new Label();
            cmbRenk = new ComboBox();
            label4 = new Label();
            cmbModel = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btnBilgiGoster = new Button();
            txtYakit = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleDescription = "lblMarka";
            label1.AutoSize = true;
            label1.Location = new Point(137, 85);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Marka : ";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(185, 82);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(160, 23);
            cmbMarka.TabIndex = 9;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            cmbMarka.MouseHover += cmbMarka_MouseHover;
            // 
            // cmbKapi
            // 
            cmbKapi.FormattingEnabled = true;
            cmbKapi.Items.AddRange(new object[] { "5", "3" });
            cmbKapi.Location = new Point(185, 251);
            cmbKapi.Name = "cmbKapi";
            cmbKapi.Size = new Size(160, 23);
            cmbKapi.TabIndex = 11;
            cmbKapi.SelectedIndexChanged += cmbKapi_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AccessibleDescription = "lblMarka";
            label2.AutoSize = true;
            label2.Location = new Point(115, 251);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 10;
            label2.Text = "Kapı Sayısı : ";
            // 
            // cmbPencere
            // 
            cmbPencere.FormattingEnabled = true;
            cmbPencere.Items.AddRange(new object[] { "6", "4" });
            cmbPencere.Location = new Point(185, 214);
            cmbPencere.Name = "cmbPencere";
            cmbPencere.Size = new Size(160, 23);
            cmbPencere.TabIndex = 13;
            cmbPencere.SelectedIndexChanged += cmbPencere_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AccessibleDescription = "lblMarka";
            label3.AutoSize = true;
            label3.Location = new Point(99, 214);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 12;
            label3.Text = "Pencere Sayısı :";
            // 
            // cmbRenk
            // 
            cmbRenk.FormattingEnabled = true;
            cmbRenk.Items.AddRange(new object[] { "Mavi", "Beyaz", "Kırmızı", "Siyah", "Gri", "Yeşil", "Metalik" });
            cmbRenk.Location = new Point(185, 171);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(160, 23);
            cmbRenk.TabIndex = 15;
            cmbRenk.SelectedIndexChanged += cmbRenk_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AccessibleDescription = "lblMarka";
            label4.AutoSize = true;
            label4.Location = new Point(147, 174);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Renk :";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(185, 125);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(160, 23);
            cmbModel.TabIndex = 17;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AccessibleDescription = "lblMarka";
            label5.AutoSize = true;
            label5.Location = new Point(139, 128);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 16;
            label5.Text = "Model :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 290);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 18;
            label6.Text = "Yakıt Tüketimi :";
            // 
            // btnBilgiGoster
            // 
            btnBilgiGoster.Location = new Point(185, 334);
            btnBilgiGoster.Name = "btnBilgiGoster";
            btnBilgiGoster.Size = new Size(201, 52);
            btnBilgiGoster.TabIndex = 20;
            btnBilgiGoster.Text = "BİLGİLERİ GÖSTER";
            btnBilgiGoster.UseVisualStyleBackColor = true;
            btnBilgiGoster.Visible = false;
            btnBilgiGoster.Click += btnBilgiGoster_Click;
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(185, 287);
            txtYakit.Name = "txtYakit";
            txtYakit.Size = new Size(160, 23);
            txtYakit.TabIndex = 21;
            txtYakit.TextChanged += txtYakit_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 425);
            Controls.Add(txtYakit);
            Controls.Add(btnBilgiGoster);
            Controls.Add(label6);
            Controls.Add(cmbModel);
            Controls.Add(label5);
            Controls.Add(cmbRenk);
            Controls.Add(label4);
            Controls.Add(cmbPencere);
            Controls.Add(label3);
            Controls.Add(cmbKapi);
            Controls.Add(label2);
            Controls.Add(cmbMarka);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMarka;
        private ComboBox cmbKapi;
        private Label label2;
        private ComboBox cmbPencere;
        private Label label3;
        private ComboBox cmbRenk;
        private Label label4;
        private ComboBox cmbModel;
        private Label label5;
        private Label label6;
        private ComboBox cmbYakit;
        private Button btnBilgiGoster;
        private TextBox txtYakit;
    }
}
