namespace VirusAntivirusSimulasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnInfect = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.listLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // btnInfect (Virüs Butonu)
            this.btnInfect.BackColor = System.Drawing.Color.DarkRed;
            this.btnInfect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfect.ForeColor = System.Drawing.Color.White;
            this.btnInfect.Location = new System.Drawing.Point(30, 40);
            this.btnInfect.Name = "btnInfect";
            this.btnInfect.Size = new System.Drawing.Size(180, 60);
            this.btnInfect.TabIndex = 0;
            this.btnInfect.Text = "VİRÜSÜ ÇALIŞTIR\n(Fareyi Kilitle)";
            this.btnInfect.UseVisualStyleBackColor = false;
            this.btnInfect.Click += new System.EventHandler(this.btnInfect_Click);

            // btnClean (Antivirüs Butonu)
            this.btnClean.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(230, 40);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(180, 60);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "ANTİVİRÜS TARA\n(Sistemi Onar)";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(30, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "DURUM: Bekleniyor...";

            // listLog (Terminal Görünümü)
            this.listLog.BackColor = System.Drawing.Color.Black;
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.listLog.ForeColor = System.Drawing.Color.Lime;
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 14;
            this.listLog.Location = new System.Drawing.Point(30, 160);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(380, 142);
            this.listLog.TabIndex = 3;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnInfect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacker Mouse Lock Sim v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnInfect;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listLog;
    }
}
