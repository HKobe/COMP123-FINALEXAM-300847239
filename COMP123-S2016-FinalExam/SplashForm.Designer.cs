namespace COMP123_S2016_FinalExam
{
    partial class SplashForm
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
            this.SplashScreenProgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashScreenProgressBar
            // 
            this.SplashScreenProgressBar.Location = new System.Drawing.Point(74, 227);
            this.SplashScreenProgressBar.MarqueeAnimationSpeed = 300;
            this.SplashScreenProgressBar.Maximum = 1000;
            this.SplashScreenProgressBar.Name = "SplashScreenProgressBar";
            this.SplashScreenProgressBar.Size = new System.Drawing.Size(437, 33);
            this.SplashScreenProgressBar.Step = 100;
            this.SplashScreenProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SplashScreenProgressBar.TabIndex = 0;
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Interval = 1000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_S2016_FinalExam.Properties.Resources.splashSceen;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar SplashScreenProgressBar;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}