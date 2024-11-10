namespace perhitungan
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
            bYa = new Button();
            bTidak = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 105);
            label1.Name = "label1";
            label1.Size = new Size(641, 41);
            label1.TabIndex = 0;
            label1.Text = "Apakah anda ingin melakukan perhitungan?";
            // 
            // bYa
            // 
            bYa.Location = new Point(149, 252);
            bYa.Name = "bYa";
            bYa.Size = new Size(94, 29);
            bYa.TabIndex = 1;
            bYa.Text = "Ya";
            bYa.UseVisualStyleBackColor = true;
            bYa.Click += bYa_Click;
            // 
            // bTidak
            // 
            bTidak.Location = new Point(534, 252);
            bTidak.Name = "bTidak";
            bTidak.Size = new Size(94, 29);
            bTidak.TabIndex = 2;
            bTidak.Text = "Tidak";
            bTidak.UseVisualStyleBackColor = true;
            bTidak.Click += bTidak_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(bTidak);
            Controls.Add(bYa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bYa;
        private Button bTidak;
    }
}
