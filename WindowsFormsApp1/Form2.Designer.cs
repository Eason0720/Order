﻿namespace WindowsFormsApp1
{
    partial class Begin
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 60F);
            this.label1.Location = new System.Drawing.Point(253, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎進入點餐系統";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 30F);
            this.button1.Location = new System.Drawing.Point(324, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 134);
            this.button1.TabIndex = 1;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 30F);
            this.button2.Location = new System.Drawing.Point(731, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 134);
            this.button2.TabIndex = 2;
            this.button2.Text = "訪客";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1356, 778);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Begin";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}