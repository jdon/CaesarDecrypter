﻿namespace Decrypt
{
    partial class InputDialog
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
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.Location = new System.Drawing.Point(148, 32);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_Button.TabIndex = 1;
            this.Encrypt_Button.Text = "Enter";
            this.Encrypt_Button.UseVisualStyleBackColor = true;
            this.Encrypt_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaskedTextBox
            // 
            this.MaskedTextBox.Location = new System.Drawing.Point(22, 32);
            this.MaskedTextBox.Mask = "00";
            this.MaskedTextBox.Name = "MaskedTextBox";
            this.MaskedTextBox.Size = new System.Drawing.Size(98, 20);
            this.MaskedTextBox.TabIndex = 2;
            this.MaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a number between 1 and 25";
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskedTextBox);
            this.Controls.Add(this.Encrypt_Button);
            this.Name = "InputDialog";
            this.Text = "Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox;
        private System.Windows.Forms.Label label1;
    }
}