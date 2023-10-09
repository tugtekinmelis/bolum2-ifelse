namespace bolum2_if_else_kullanımı1
{
    partial class Form1
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
            this.btnDegistir = new System.Windows.Forms.Button();
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.lblYaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(29, 108);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(143, 44);
            this.btnDegistir.TabIndex = 0;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Location = new System.Drawing.Point(43, 55);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(52, 17);
            this.cbMavi.TabIndex = 1;
            this.cbMavi.Text = "MAVİ";
            this.cbMavi.UseVisualStyleBackColor = true;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Location = new System.Drawing.Point(261, 55);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(35, 13);
            this.lblYaz.TabIndex = 3;
            this.lblYaz.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.btnDegistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.Label lblYaz;
    }
}

