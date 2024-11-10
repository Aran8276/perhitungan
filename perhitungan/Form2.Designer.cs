namespace perhitungan
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tNilai1 = new TextBox();
            tNilai2 = new TextBox();
            tHasil = new TextBox();
            bTambah = new Button();
            bKurang = new Button();
            bKali = new Button();
            bBagi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 47);
            label1.Name = "label1";
            label1.Size = new Size(266, 41);
            label1.TabIndex = 0;
            label1.Text = "Perhitungan Nilai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 143);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Nilai 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 207);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Nilai 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 303);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Hasil";
            // 
            // tNilai1
            // 
            tNilai1.Location = new Point(168, 143);
            tNilai1.Name = "tNilai1";
            tNilai1.Size = new Size(161, 27);
            tNilai1.TabIndex = 4;
            // 
            // tNilai2
            // 
            tNilai2.Location = new Point(168, 207);
            tNilai2.Name = "tNilai2";
            tNilai2.Size = new Size(161, 27);
            tNilai2.TabIndex = 5;
            // 
            // tHasil
            // 
            tHasil.Location = new Point(168, 303);
            tHasil.Name = "tHasil";
            tHasil.Size = new Size(161, 27);
            tHasil.TabIndex = 6;
            // 
            // bTambah
            // 
            bTambah.Location = new Point(118, 255);
            bTambah.Name = "bTambah";
            bTambah.Size = new Size(35, 29);
            bTambah.TabIndex = 7;
            bTambah.Text = "+";
            bTambah.UseVisualStyleBackColor = true;
            bTambah.Click += bTambah_Click;
            // 
            // bKurang
            // 
            bKurang.Location = new Point(168, 255);
            bKurang.Name = "bKurang";
            bKurang.Size = new Size(35, 29);
            bKurang.TabIndex = 8;
            bKurang.Text = "-";
            bKurang.UseVisualStyleBackColor = true;
            bKurang.Click += bKurang_Click;
            // 
            // bKali
            // 
            bKali.Location = new Point(220, 255);
            bKali.Name = "bKali";
            bKali.Size = new Size(35, 29);
            bKali.TabIndex = 9;
            bKali.Text = "x";
            bKali.UseVisualStyleBackColor = true;
            bKali.Click += bKali_Click;
            // 
            // bBagi
            // 
            bBagi.Location = new Point(274, 255);
            bBagi.Name = "bBagi";
            bBagi.Size = new Size(35, 29);
            bBagi.TabIndex = 10;
            bBagi.Text = "/";
            bBagi.UseVisualStyleBackColor = true;
            bBagi.Click += bBagi_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(454, 450);
            Controls.Add(bBagi);
            Controls.Add(bKali);
            Controls.Add(bKurang);
            Controls.Add(bTambah);
            Controls.Add(tHasil);
            Controls.Add(tNilai2);
            Controls.Add(tNilai1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tNilai1;
        private TextBox tNilai2;
        private TextBox tHasil;
        private Button bTambah;
        private Button bKurang;
        private Button bKali;
        private Button bBagi;
    }
}