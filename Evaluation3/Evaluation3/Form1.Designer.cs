﻿namespace Evaluation3
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
            this.panelUserControl11 = new Evaluation3.PanelUserControl1();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelUserControl11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserControl11
            // 
            this.panelUserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserControl11.ColoumnDefinition = "*,*";
            this.panelUserControl11.ColoumnMargin = 10;
            this.panelUserControl11.ColoumnPadding = 10;
            this.panelUserControl11.Controls.Add(this.button3);
            this.panelUserControl11.Controls.Add(this.button2);
            this.panelUserControl11.Controls.Add(this.button1);
            this.panelUserControl11.Location = new System.Drawing.Point(170, 20);
            this.panelUserControl11.Margin = new System.Windows.Forms.Padding(10);
            this.panelUserControl11.Name = "panelUserControl11";
            this.panelUserControl11.Padding = new System.Windows.Forms.Padding(10);
            this.panelUserControl11.RowDefinition = "*,8*,*";
            this.panelUserControl11.RowMargin = 10;
            this.panelUserControl11.RowPadding = 10;
            this.panelUserControl11.Size = new System.Drawing.Size(400, 400);
            this.panelUserControl11.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 10);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(36, 185);
            this.button3.TabIndex = 11;
            this.button3.Text = "button4";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 220);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(36, 185);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(288, 185);
            this.button1.TabIndex = 11;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUserControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelUserControl11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelUserControl1 panelUserControl11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

