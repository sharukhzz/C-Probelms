namespace shapes
{
    partial class Form
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
            this.pol = new System.Windows.Forms.Button();
            this.cir = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pol
            // 
            this.pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol.Location = new System.Drawing.Point(362, 577);
            this.pol.Name = "pol";
            this.pol.Size = new System.Drawing.Size(104, 55);
            this.pol.TabIndex = 0;
            this.pol.Text = "Triangle";
            this.pol.UseVisualStyleBackColor = true;
            this.pol.Click += new System.EventHandler(this.TriClick);
            // 
            // cir
            // 
            this.cir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cir.Location = new System.Drawing.Point(178, 577);
            this.cir.Name = "cir";
            this.cir.Size = new System.Drawing.Size(104, 55);
            this.cir.TabIndex = 0;
            this.cir.Text = "Circle";
            this.cir.UseVisualStyleBackColor = true;
            this.cir.Click += new System.EventHandler(this.CirClick);
            // 
            // rec
            // 
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(25, 577);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(104, 55);
            this.rec.TabIndex = 0;
            this.rec.Text = "Rectangle";
            this.rec.UseVisualStyleBackColor = true;
            this.rec.Click += new System.EventHandler(this.RecClick);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(527, 577);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(104, 55);
            this.button.TabIndex = 0;
            this.button.Text = "Delete";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1446, 644);
            this.Controls.Add(this.pol);
            this.Controls.Add(this.button);
            this.Controls.Add(this.cir);
            this.Controls.Add(this.rec);
            this.Name = "Form";
            this.Text = "Shapes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cir;
        private System.Windows.Forms.Button pol;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button rec;
    }
}

