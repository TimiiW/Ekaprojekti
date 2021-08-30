namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            this.salasanapanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.tarkistaTB = new System.Windows.Forms.Button();
            this.virheviestiLB = new System.Windows.Forms.Label();
            this.salasanaokeinpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.salasanapanel.SuspendLayout();
            this.salasanaokeinpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanapanel
            // 
            this.salasanapanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanapanel.Controls.Add(this.virheviestiLB);
            this.salasanapanel.Controls.Add(this.tarkistaTB);
            this.salasanapanel.Controls.Add(this.salasanaTB);
            this.salasanapanel.Controls.Add(this.kayttajaTB);
            this.salasanapanel.Controls.Add(this.label2);
            this.salasanapanel.Controls.Add(this.label1);
            this.salasanapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanapanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanapanel.ForeColor = System.Drawing.Color.Gold;
            this.salasanapanel.Location = new System.Drawing.Point(0, 0);
            this.salasanapanel.Name = "salasanapanel";
            this.salasanapanel.Size = new System.Drawing.Size(507, 283);
            this.salasanapanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "salasana:";
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(246, 56);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(100, 35);
            this.kayttajaTB.TabIndex = 2;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(246, 102);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(100, 35);
            this.salasanaTB.TabIndex = 3;
            // 
            // tarkistaTB
            // 
            this.tarkistaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarkistaTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tarkistaTB.Location = new System.Drawing.Point(24, 102);
            this.tarkistaTB.Name = "tarkistaTB";
            this.tarkistaTB.Size = new System.Drawing.Size(92, 32);
            this.tarkistaTB.TabIndex = 4;
            this.tarkistaTB.Text = "Tarkista";
            this.tarkistaTB.UseVisualStyleBackColor = true;
            this.tarkistaTB.Click += new System.EventHandler(this.tarkistaTB_Click);
            // 
            // virheviestiLB
            // 
            this.virheviestiLB.AutoSize = true;
            this.virheviestiLB.Location = new System.Drawing.Point(29, 160);
            this.virheviestiLB.Name = "virheviestiLB";
            this.virheviestiLB.Size = new System.Drawing.Size(69, 29);
            this.virheviestiLB.TabIndex = 5;
            this.virheviestiLB.Text = "Virhe";
            this.virheviestiLB.Visible = false;
            // 
            // salasanaokeinpanel
            // 
            this.salasanaokeinpanel.BackColor = System.Drawing.Color.Maroon;
            this.salasanaokeinpanel.Controls.Add(this.label3);
            this.salasanaokeinpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaokeinpanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaokeinpanel.ForeColor = System.Drawing.Color.Snow;
            this.salasanaokeinpanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaokeinpanel.Name = "salasanaokeinpanel";
            this.salasanaokeinpanel.Size = new System.Drawing.Size(507, 283);
            this.salasanaokeinpanel.TabIndex = 1;
            this.salasanaokeinpanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 71);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa Sivulleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 283);
            this.Controls.Add(this.salasanaokeinpanel);
            this.Controls.Add(this.salasanapanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.salasanapanel.ResumeLayout(false);
            this.salasanapanel.PerformLayout();
            this.salasanaokeinpanel.ResumeLayout(false);
            this.salasanaokeinpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel salasanapanel;
        private System.Windows.Forms.Label virheviestiLB;
        private System.Windows.Forms.Button tarkistaTB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel salasanaokeinpanel;
        private System.Windows.Forms.Label label3;
    }
}

