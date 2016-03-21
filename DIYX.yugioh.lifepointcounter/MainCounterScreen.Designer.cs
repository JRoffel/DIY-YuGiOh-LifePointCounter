namespace DIYX.yugioh.lifepointcounter
{
    partial class MainCounterScreen
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
            this.LifePointBar1 = new System.Windows.Forms.ProgressBar();
            this.LifePointBar3 = new System.Windows.Forms.ProgressBar();
            this.LifePointBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LifePointBar1
            // 
            this.LifePointBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LifePointBar1.Location = new System.Drawing.Point(180, 279);
            this.LifePointBar1.Name = "LifePointBar1";
            this.LifePointBar1.Size = new System.Drawing.Size(100, 23);
            this.LifePointBar1.TabIndex = 0;
            this.LifePointBar1.Value = 100;
            this.LifePointBar1.Click += new System.EventHandler(this.LifePointBar1_Click);
            // 
            // LifePointBar3
            // 
            this.LifePointBar3.Location = new System.Drawing.Point(773, 279);
            this.LifePointBar3.Name = "LifePointBar3";
            this.LifePointBar3.Size = new System.Drawing.Size(100, 23);
            this.LifePointBar3.TabIndex = 1;
            this.LifePointBar3.Value = 100;
            this.LifePointBar3.Click += new System.EventHandler(this.LifePointBar3_Click);
            // 
            // LifePointBar2
            // 
            this.LifePointBar2.Location = new System.Drawing.Point(466, 279);
            this.LifePointBar2.Name = "LifePointBar2";
            this.LifePointBar2.Size = new System.Drawing.Size(100, 23);
            this.LifePointBar2.TabIndex = 2;
            this.LifePointBar2.Value = 100;
            this.LifePointBar2.Click += new System.EventHandler(this.LifePointBar2_Click);
            // 
            // MainCounterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 588);
            this.Controls.Add(this.LifePointBar2);
            this.Controls.Add(this.LifePointBar3);
            this.Controls.Add(this.LifePointBar1);
            this.Name = "MainCounterScreen";
            this.Text = "YuGiOh LifePointCounter";
            this.Load += new System.EventHandler(this.MainCounterScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar LifePointBar1;
        private System.Windows.Forms.ProgressBar LifePointBar3;
        private System.Windows.Forms.ProgressBar LifePointBar2;
    }
}

