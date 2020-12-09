namespace FormMDI
{
    partial class FrmPenjat
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.incog0 = new System.Windows.Forms.Label();
            this.incog1 = new System.Windows.Forms.Label();
            this.incog2 = new System.Windows.Forms.Label();
            this.incog3 = new System.Windows.Forms.Label();
            this.incog4 = new System.Windows.Forms.Label();
            this.imgColgado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgColgado)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tb1.Location = new System.Drawing.Point(172, 509);
            this.tb1.MaxLength = 5;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(163, 30);
            this.tb1.TabIndex = 5;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bt1.Location = new System.Drawing.Point(195, 545);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(109, 39);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "Comprobar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // incog0
            // 
            this.incog0.AutoSize = true;
            this.incog0.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.incog0.Location = new System.Drawing.Point(196, 429);
            this.incog0.Name = "incog0";
            this.incog0.Size = new System.Drawing.Size(20, 28);
            this.incog0.TabIndex = 9;
            this.incog0.Text = "-";
            // 
            // incog1
            // 
            this.incog1.AutoSize = true;
            this.incog1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.incog1.Location = new System.Drawing.Point(222, 429);
            this.incog1.Name = "incog1";
            this.incog1.Size = new System.Drawing.Size(20, 28);
            this.incog1.TabIndex = 10;
            this.incog1.Text = "-";
            // 
            // incog2
            // 
            this.incog2.AutoSize = true;
            this.incog2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.incog2.Location = new System.Drawing.Point(248, 429);
            this.incog2.Name = "incog2";
            this.incog2.Size = new System.Drawing.Size(20, 28);
            this.incog2.TabIndex = 11;
            this.incog2.Text = "-";
            // 
            // incog3
            // 
            this.incog3.AutoSize = true;
            this.incog3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.incog3.Location = new System.Drawing.Point(274, 429);
            this.incog3.Name = "incog3";
            this.incog3.Size = new System.Drawing.Size(20, 28);
            this.incog3.TabIndex = 12;
            this.incog3.Text = "-";
            // 
            // incog4
            // 
            this.incog4.AutoSize = true;
            this.incog4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.incog4.Location = new System.Drawing.Point(300, 429);
            this.incog4.Name = "incog4";
            this.incog4.Size = new System.Drawing.Size(20, 28);
            this.incog4.TabIndex = 13;
            this.incog4.Text = "-";
            // 
            // imgColgado
            // 
            this.imgColgado.BackgroundImage = global::FormMDI.Properties.Resources.Intento1;
            this.imgColgado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgColgado.Location = new System.Drawing.Point(122, 27);
            this.imgColgado.Name = "imgColgado";
            this.imgColgado.Size = new System.Drawing.Size(287, 323);
            this.imgColgado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgColgado.TabIndex = 14;
            this.imgColgado.TabStop = false;
            // 
            // FrmPenjat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(552, 601);
            this.Controls.Add(this.imgColgado);
            this.Controls.Add(this.incog4);
            this.Controls.Add(this.incog3);
            this.Controls.Add(this.incog2);
            this.Controls.Add(this.incog1);
            this.Controls.Add(this.incog0);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb1);
            this.Name = "FrmPenjat";
            this.Text = "El Penjat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPenjat_FormClosing);
            this.Load += new System.EventHandler(this.FrmPenjat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgColgado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label incog0;
        private System.Windows.Forms.Label incog1;
        private System.Windows.Forms.Label incog2;
        private System.Windows.Forms.Label incog3;
        private System.Windows.Forms.Label incog4;
        private System.Windows.Forms.PictureBox imgColgado;
    }
}