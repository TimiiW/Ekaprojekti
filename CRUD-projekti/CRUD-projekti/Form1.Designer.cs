namespace CRUD_projekti
{
    partial class OtsikkoLB
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
            this.otsikko = new System.Windows.Forms.Label();
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikko
            // 
            this.otsikko.AutoSize = true;
            this.otsikko.Location = new System.Drawing.Point(352, 73);
            this.otsikko.Name = "otsikko";
            this.otsikko.Size = new System.Drawing.Size(43, 13);
            this.otsikko.TabIndex = 0;
            this.otsikko.Text = "Otsikko";
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Location = new System.Drawing.Point(320, 108);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(107, 23);
            this.VaihdaBT.TabIndex = 1;
            this.VaihdaBT.Text = "Vaihda Tekstia";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // OtsikkoLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VaihdaBT);
            this.Controls.Add(this.otsikko);
            this.Name = "OtsikkoLB";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikko;
        private System.Windows.Forms.Button VaihdaBT;
    }
}

