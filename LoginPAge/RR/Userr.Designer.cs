namespace RR
{
    partial class Userr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AQ
            // 
            this.AQ.Location = new System.Drawing.Point(120, 212);
            this.AQ.Name = "AQ";
            this.AQ.Size = new System.Drawing.Size(75, 23);
            this.AQ.TabIndex = 0;
            this.AQ.Text = "Create";
            this.AQ.UseVisualStyleBackColor = true;
            this.AQ.Click += new System.EventHandler(this.AQ_Click);
            // 
            // Userr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AQ);
            this.Name = "Userr";
            this.Size = new System.Drawing.Size(326, 279);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AQ;
    }
}
