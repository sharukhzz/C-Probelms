namespace progressbar
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
            this.Mains = new System.Windows.Forms.Panel();
            this.Progress = new progressbar.UserControl1();
            this.SuspendLayout();
            // 
            // Mains
            // 
            this.Mains.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mains.Location = new System.Drawing.Point(0, 0);
            this.Mains.Name = "Mains";
            this.Mains.Size = new System.Drawing.Size(800, 450);
            this.Mains.TabIndex = 1;
            this.Mains.Resize += new System.EventHandler(this.Panel1Resize);
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Progress.Dock = System.Windows.Forms.DockStyle.Right;
            this.Progress.HeightsShow = 0;
            this.Progress.Location = new System.Drawing.Point(416, 0);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(384, 450);
            this.Progress.TabIndex = 2;
            this.Progress.WidthsShow = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Mains);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Mains;
        private UserControl1 Progress;
    }
}

