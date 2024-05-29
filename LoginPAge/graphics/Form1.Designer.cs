namespace graphics
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
            this.roundbut1 = new graphics.roundbut();
            this.roufh1 = new graphics.Roufh();
            this.SuspendLayout();
            // 
            // roundbut1
            // 
            this.roundbut1.Location = new System.Drawing.Point(183, 148);
            this.roundbut1.Name = "roundbut1";
            this.roundbut1.Size = new System.Drawing.Size(740, 228);
            this.roundbut1.TabIndex = 0;
            this.roundbut1.Text = "roundbut1";
            this.roundbut1.UseVisualStyleBackColor = true;
            // 
            // roufh1
            // 
            this.roufh1.Location = new System.Drawing.Point(380, 45);
            this.roufh1.Name = "roufh1";
            this.roufh1.Size = new System.Drawing.Size(76, 60);
            this.roufh1.TabIndex = 1;
            this.roufh1.Text = "roufh1";
            this.roufh1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 566);
            this.Controls.Add(this.roufh1);
            this.Controls.Add(this.roundbut1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private roundbut roundbut1;
        private Roufh roufh1;
    }
}

