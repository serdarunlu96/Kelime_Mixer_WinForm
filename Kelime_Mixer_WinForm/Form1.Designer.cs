namespace Kelime_Mixer_WinForm
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
            txtKelime = new TextBox();
            lstKelimeler = new ListBox();
            btnEkle = new Button();
            btnKaristir = new Button();
            SuspendLayout();
            // 
            // txtKelime
            // 
            txtKelime.Location = new Point(28, 24);
            txtKelime.Name = "txtKelime";
            txtKelime.Size = new Size(123, 23);
            txtKelime.TabIndex = 0;
            // 
            // lstKelimeler
            // 
            lstKelimeler.FormattingEnabled = true;
            lstKelimeler.ItemHeight = 15;
            lstKelimeler.Location = new Point(28, 76);
            lstKelimeler.Name = "lstKelimeler";
            lstKelimeler.Size = new Size(205, 304);
            lstKelimeler.TabIndex = 1;
            lstKelimeler.KeyDown += lstKelimeler_KeyDown;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(172, 24);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(61, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnKaristir
            // 
            btnKaristir.Location = new Point(28, 398);
            btnKaristir.Name = "btnKaristir";
            btnKaristir.Size = new Size(193, 23);
            btnKaristir.TabIndex = 3;
            btnKaristir.Text = "SIL";
            btnKaristir.UseVisualStyleBackColor = true;
            btnKaristir.Click += btnKaristir_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(btnKaristir);
            Controls.Add(btnEkle);
            Controls.Add(lstKelimeler);
            Controls.Add(txtKelime);
            Name = "Form1";
            Text = "Kelime Mixer";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKelime;
        private ListBox lstKelimeler;
        private Button btnEkle;
        private Button btnKaristir;
    }
}