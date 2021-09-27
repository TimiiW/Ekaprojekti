namespace Sekuntti_kello
{
    partial class SekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.KäynnistäBT = new System.Windows.Forms.Button();
            this.TyhjennäBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.AjanottoTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Location = new System.Drawing.Point(63, 9);
            this.AikaLB.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(410, 73);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00.00.00.000";
            // 
            // KäynnistäBT
            // 
            this.KäynnistäBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KäynnistäBT.Location = new System.Drawing.Point(47, 89);
            this.KäynnistäBT.Name = "KäynnistäBT";
            this.KäynnistäBT.Size = new System.Drawing.Size(149, 65);
            this.KäynnistäBT.TabIndex = 1;
            this.KäynnistäBT.Text = "Käynnistä";
            this.KäynnistäBT.UseVisualStyleBackColor = true;
            this.KäynnistäBT.Click += new System.EventHandler(this.KäynnistäBT_Click);
            // 
            // TyhjennäBT
            // 
            this.TyhjennäBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennäBT.Location = new System.Drawing.Point(342, 89);
            this.TyhjennäBT.Name = "TyhjennäBT";
            this.TyhjennäBT.Size = new System.Drawing.Size(146, 65);
            this.TyhjennäBT.TabIndex = 2;
            this.TyhjennäBT.Text = "Tyhjennä";
            this.TyhjennäBT.UseVisualStyleBackColor = true;
            this.TyhjennäBT.Click += new System.EventHandler(this.TyhjennäBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopetaBT.Location = new System.Drawing.Point(196, 160);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(146, 65);
            this.LopetaBT.TabIndex = 3;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // AjanottoTM
            // 
            this.AjanottoTM.Enabled = true;
            this.AjanottoTM.Tick += new System.EventHandler(this.AjanottoTM_Tick);
            // 
            // SekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 717);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.TyhjennäBT);
            this.Controls.Add(this.KäynnistäBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Name = "SekkariForm";
            this.Text = "Sekunttikello";
            this.Load += new System.EventHandler(this.SekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button KäynnistäBT;
        private System.Windows.Forms.Button TyhjennäBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Timer AjanottoTM;
    }
}

