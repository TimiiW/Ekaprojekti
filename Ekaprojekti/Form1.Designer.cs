namespace Ekaprojekti
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
            this.tekstilb = new System.Windows.Forms.Label();
            this.muutabt = new System.Windows.Forms.Button();
            this.muutabt2 = new System.Windows.Forms.Button();
            this.Tekstitb = new System.Windows.Forms.TextBox();
            this.tekstitb2 = new System.Windows.Forms.TextBox();
            this.näytäbt = new System.Windows.Forms.Button();
            this.tekstitb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tekstilb
            // 
            this.tekstilb.AutoSize = true;
            this.tekstilb.Location = new System.Drawing.Point(515, 183);
            this.tekstilb.Name = "tekstilb";
            this.tekstilb.Size = new System.Drawing.Size(69, 29);
            this.tekstilb.TabIndex = 0;
            this.tekstilb.Text = "teksti";
            // 
            // muutabt
            // 
            this.muutabt.Location = new System.Drawing.Point(420, 183);
            this.muutabt.Name = "muutabt";
            this.muutabt.Size = new System.Drawing.Size(89, 36);
            this.muutabt.TabIndex = 1;
            this.muutabt.Text = "muuta teksti";
            this.muutabt.UseVisualStyleBackColor = true;
            this.muutabt.Click += new System.EventHandler(this.muutabt_Click);
            // 
            // muutabt2
            // 
            this.muutabt2.Location = new System.Drawing.Point(590, 183);
            this.muutabt2.Name = "muutabt2";
            this.muutabt2.Size = new System.Drawing.Size(156, 36);
            this.muutabt2.TabIndex = 2;
            this.muutabt2.Text = "Muuta takas";
            this.muutabt2.UseVisualStyleBackColor = true;
            this.muutabt2.Click += new System.EventHandler(this.muutabt2_Click);
            // 
            // Tekstitb
            // 
            this.Tekstitb.Location = new System.Drawing.Point(447, 272);
            this.Tekstitb.Name = "Tekstitb";
            this.Tekstitb.Size = new System.Drawing.Size(156, 35);
            this.Tekstitb.TabIndex = 3;
            this.Tekstitb.Text = "minun nimi on";
            // 
            // tekstitb2
            // 
            this.tekstitb2.Location = new System.Drawing.Point(609, 272);
            this.tekstitb2.Name = "tekstitb2";
            this.tekstitb2.Size = new System.Drawing.Size(100, 35);
            this.tekstitb2.TabIndex = 4;
            this.tekstitb2.Text = "timi";
            this.tekstitb2.Visible = false;
            // 
            // näytäbt
            // 
            this.näytäbt.Location = new System.Drawing.Point(529, 347);
            this.näytäbt.Name = "näytäbt";
            this.näytäbt.Size = new System.Drawing.Size(155, 36);
            this.näytäbt.TabIndex = 5;
            this.näytäbt.Text = "paljasta nimi";
            this.näytäbt.UseVisualStyleBackColor = true;
            this.näytäbt.Click += new System.EventHandler(this.näytäbt_Click);
            // 
            // tekstitb3
            // 
            this.tekstitb3.Location = new System.Drawing.Point(467, 408);
            this.tekstitb3.Name = "tekstitb3";
            this.tekstitb3.Size = new System.Drawing.Size(252, 35);
            this.tekstitb3.TabIndex = 6;
            this.tekstitb3.Text = "onpa sulla hieno nimi";
            this.tekstitb3.Visible = false;
            this.tekstitb3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 830);
            this.Controls.Add(this.tekstitb3);
            this.Controls.Add(this.näytäbt);
            this.Controls.Add(this.tekstitb2);
            this.Controls.Add(this.Tekstitb);
            this.Controls.Add(this.muutabt2);
            this.Controls.Add(this.muutabt);
            this.Controls.Add(this.tekstilb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "teksti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tekstilb;
        private System.Windows.Forms.Button muutabt;
        private System.Windows.Forms.Button muutabt2;
        private System.Windows.Forms.TextBox Tekstitb;
        private System.Windows.Forms.TextBox tekstitb2;
        private System.Windows.Forms.Button näytäbt;
        private System.Windows.Forms.TextBox tekstitb3;
    }
}

