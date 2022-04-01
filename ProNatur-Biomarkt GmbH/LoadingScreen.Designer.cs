
namespace ProNatur_Biomarkt_GmbH
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoaProgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadingProgressBar.Location = new System.Drawing.Point(12, 326);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(760, 23);
            this.loadingProgressBar.TabIndex = 1;
            this.loadingProgressBar.Value = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(334, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading";
            // 
            // lblLoaProgress
            // 
            this.lblLoaProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoaProgress.AutoSize = true;
            this.lblLoaProgress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoaProgress.Location = new System.Drawing.Point(424, 310);
            this.lblLoaProgress.Name = "lblLoaProgress";
            this.lblLoaProgress.Size = new System.Drawing.Size(21, 13);
            this.lblLoaProgress.TabIndex = 3;
            this.lblLoaProgress.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 295);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Interval = 40;
            this.loadingbarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLoaProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingProgressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNatur-Biomarkt-GmbH";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoaProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}

