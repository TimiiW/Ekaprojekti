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
            this.synttariDTP = new System.Windows.Forms.DateTimePicker();
            this.laskeikäbt = new System.Windows.Forms.Button();
            this.vuosinalb = new System.Windows.Forms.Label();
            this.kuukausinalb = new System.Windows.Forms.Label();
            this.tunteinalb = new System.Windows.Forms.Label();
            this.päivinälb = new System.Windows.Forms.Label();
            this.minuutteinalb = new System.Windows.Forms.Label();
            this.sekuntteinalb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // synttariDTP
            // 
            this.synttariDTP.Location = new System.Drawing.Point(69, 50);
            this.synttariDTP.Name = "synttariDTP";
            this.synttariDTP.Size = new System.Drawing.Size(200, 20);
            this.synttariDTP.TabIndex = 0;
            this.synttariDTP.ValueChanged += new System.EventHandler(this.synttariDTP_ValueChanged);
            // 
            // laskeikäbt
            // 
            this.laskeikäbt.Location = new System.Drawing.Point(295, 50);
            this.laskeikäbt.Name = "laskeikäbt";
            this.laskeikäbt.Size = new System.Drawing.Size(75, 23);
            this.laskeikäbt.TabIndex = 1;
            this.laskeikäbt.Text = "Laske";
            this.laskeikäbt.UseVisualStyleBackColor = true;
            this.laskeikäbt.Click += new System.EventHandler(this.laskeikäbt_Click);
            // 
            // vuosinalb
            // 
            this.vuosinalb.AutoSize = true;
            this.vuosinalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vuosinalb.Location = new System.Drawing.Point(69, 86);
            this.vuosinalb.Name = "vuosinalb";
            this.vuosinalb.Size = new System.Drawing.Size(75, 24);
            this.vuosinalb.TabIndex = 2;
            this.vuosinalb.Text = "vuosina";
            this.vuosinalb.Visible = false;
            // 
            // kuukausinalb
            // 
            this.kuukausinalb.AutoSize = true;
            this.kuukausinalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuukausinalb.Location = new System.Drawing.Point(69, 127);
            this.kuukausinalb.Name = "kuukausinalb";
            this.kuukausinalb.Size = new System.Drawing.Size(105, 24);
            this.kuukausinalb.TabIndex = 3;
            this.kuukausinalb.Text = "kuukausina";
            this.kuukausinalb.Visible = false;
            // 
            // tunteinalb
            // 
            this.tunteinalb.AutoSize = true;
            this.tunteinalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunteinalb.Location = new System.Drawing.Point(69, 216);
            this.tunteinalb.Name = "tunteinalb";
            this.tunteinalb.Size = new System.Drawing.Size(76, 24);
            this.tunteinalb.TabIndex = 4;
            this.tunteinalb.Text = "tunteina";
            this.tunteinalb.Visible = false;
            // 
            // päivinälb
            // 
            this.päivinälb.AutoSize = true;
            this.päivinälb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.päivinälb.Location = new System.Drawing.Point(69, 168);
            this.päivinälb.Name = "päivinälb";
            this.päivinälb.Size = new System.Drawing.Size(69, 24);
            this.päivinälb.TabIndex = 5;
            this.päivinälb.Text = "päivinä";
            this.päivinälb.Visible = false;
            // 
            // minuutteinalb
            // 
            this.minuutteinalb.AutoSize = true;
            this.minuutteinalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuutteinalb.Location = new System.Drawing.Point(69, 263);
            this.minuutteinalb.Name = "minuutteinalb";
            this.minuutteinalb.Size = new System.Drawing.Size(107, 24);
            this.minuutteinalb.TabIndex = 6;
            this.minuutteinalb.Text = "minuutteina";
            this.minuutteinalb.Visible = false;
            // 
            // sekuntteinalb
            // 
            this.sekuntteinalb.AutoSize = true;
            this.sekuntteinalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekuntteinalb.Location = new System.Drawing.Point(69, 313);
            this.sekuntteinalb.Name = "sekuntteinalb";
            this.sekuntteinalb.Size = new System.Drawing.Size(105, 24);
            this.sekuntteinalb.TabIndex = 7;
            this.sekuntteinalb.Text = "sekuntteina";
            this.sekuntteinalb.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(435, 366);
            this.Controls.Add(this.sekuntteinalb);
            this.Controls.Add(this.minuutteinalb);
            this.Controls.Add(this.päivinälb);
            this.Controls.Add(this.tunteinalb);
            this.Controls.Add(this.kuukausinalb);
            this.Controls.Add(this.vuosinalb);
            this.Controls.Add(this.laskeikäbt);
            this.Controls.Add(this.synttariDTP);
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
        private System.Windows.Forms.DateTimePicker synttariDTP;
        private System.Windows.Forms.Button laskeikäbt;
        private System.Windows.Forms.Label vuosinalb;
        private System.Windows.Forms.Label kuukausinalb;
        private System.Windows.Forms.Label tunteinalb;
        private System.Windows.Forms.Label päivinälb;
        private System.Windows.Forms.Label minuutteinalb;
        private System.Windows.Forms.Label sekuntteinalb;
    }
}

