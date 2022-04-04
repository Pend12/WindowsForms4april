
namespace WindowsForms4april
{
    partial class FormPraktikum
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
            this.labelInput = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelJadi = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.textBoxJadi = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonNoConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(13, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(130, 17);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Masukkan Kalimat :";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(13, 71);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(123, 17);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf : ";
            // 
            // labelJadi
            // 
            this.labelJadi.AutoSize = true;
            this.labelJadi.Location = new System.Drawing.Point(322, 71);
            this.labelJadi.Name = "labelJadi";
            this.labelJadi.Size = new System.Drawing.Size(65, 17);
            this.labelJadi.TabIndex = 2;
            this.labelJadi.Text = "Menjadi :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(150, 13);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(638, 22);
            this.textBoxInput.TabIndex = 3;
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.Location = new System.Drawing.Point(142, 71);
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(173, 22);
            this.textBoxHuruf.TabIndex = 4;
            // 
            // textBoxJadi
            // 
            this.textBoxJadi.Location = new System.Drawing.Point(394, 70);
            this.textBoxJadi.Name = "textBoxJadi";
            this.textBoxJadi.Size = new System.Drawing.Size(184, 22);
            this.textBoxJadi.TabIndex = 5;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(249, 181);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(250, 35);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Konversi!";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(57, 241);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(94, 32);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil :";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(157, 241);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 32);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "...";
            // 
            // buttonNoConvert
            // 
            this.buttonNoConvert.Location = new System.Drawing.Point(249, 134);
            this.buttonNoConvert.Name = "buttonNoConvert";
            this.buttonNoConvert.Size = new System.Drawing.Size(250, 41);
            this.buttonNoConvert.TabIndex = 9;
            this.buttonNoConvert.Text = "Tanpa Konversi";
            this.buttonNoConvert.UseVisualStyleBackColor = true;
            this.buttonNoConvert.Click += new System.EventHandler(this.buttonNoConvert_Click);
            // 
            // FormPraktikum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNoConvert);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxJadi);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelJadi);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelInput);
            this.Name = "FormPraktikum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPraktikum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelJadi;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxHuruf;
        private System.Windows.Forms.TextBox textBoxJadi;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonNoConvert;
    }
}

