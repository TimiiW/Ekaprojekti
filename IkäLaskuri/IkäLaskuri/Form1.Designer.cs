namespace IkäLaskuri
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.ikkaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Syntynyt";
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(238, 188);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(75, 23);
            this.laskeBT.TabIndex = 2;
            this.laskeBT.Text = "Laske ikä";
            this.laskeBT.UseVisualStyleBackColor = true;
            // 
            // ikkaTB
            // 
            this.ikkaTB.Location = new System.Drawing.Point(238, 218);
            this.ikkaTB.Name = "ikkaTB";
            this.ikkaTB.Size = new System.Drawing.Size(100, 20);
            this.ikkaTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(877, 491);
            this.Controls.Add(this.ikkaTB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LaskeikaBT;
        private System.Windows.Forms.DateTimePicker syntymaDTP;
        private System.Windows.Forms.DateTimePicker nykyhetkiDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ikaTB;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button laskeBT;
        private System.Windows.Forms.TextBox ikkaTB;
    }
}

