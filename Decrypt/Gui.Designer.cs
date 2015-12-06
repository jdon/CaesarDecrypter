namespace Decrypt
{
    partial class Gui
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
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarCipherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedCipherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarCipherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedCipherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextOutput
            // 
            this.TextOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextOutput.DetectUrls = false;
            this.TextOutput.ForeColor = System.Drawing.SystemColors.Menu;
            this.TextOutput.Location = new System.Drawing.Point(12, 27);
            this.TextOutput.MinimumSize = new System.Drawing.Size(379, 547);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextOutput.Size = new System.Drawing.Size(379, 547);
            this.TextOutput.TabIndex = 2;
            this.TextOutput.Text = "";
            this.TextOutput.TextChanged += new System.EventHandler(this.TextOutput_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.runToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptedTextToolStripMenuItem,
            this.encryptedTextToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // decryptedTextToolStripMenuItem
            // 
            this.decryptedTextToolStripMenuItem.Name = "decryptedTextToolStripMenuItem";
            this.decryptedTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decryptedTextToolStripMenuItem.Text = "Decrypted Text";
            this.decryptedTextToolStripMenuItem.Click += new System.EventHandler(this.decryptedTextToolStripMenuItem_Click);
            // 
            // encryptedTextToolStripMenuItem
            // 
            this.encryptedTextToolStripMenuItem.Name = "encryptedTextToolStripMenuItem";
            this.encryptedTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encryptedTextToolStripMenuItem.Text = "Encrypted Text";
            this.encryptedTextToolStripMenuItem.Click += new System.EventHandler(this.encryptedTextToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptToolStripMenuItem,
            this.encryptToolStripMenuItem});
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem1.Text = "Run";
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caesarCipherToolStripMenuItem1,
            this.advancedCipherToolStripMenuItem1});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            // 
            // caesarCipherToolStripMenuItem1
            // 
            this.caesarCipherToolStripMenuItem1.Name = "caesarCipherToolStripMenuItem1";
            this.caesarCipherToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.caesarCipherToolStripMenuItem1.Text = "Caesar Cipher";
            this.caesarCipherToolStripMenuItem1.Click += new System.EventHandler(this.caesarCipherToolStripMenuItem1_Click);
            // 
            // advancedCipherToolStripMenuItem1
            // 
            this.advancedCipherToolStripMenuItem1.Name = "advancedCipherToolStripMenuItem1";
            this.advancedCipherToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.advancedCipherToolStripMenuItem1.Text = "Advanced Cipher ";
            this.advancedCipherToolStripMenuItem1.Click += new System.EventHandler(this.advancedCipherToolStripMenuItem1_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caesarCipherToolStripMenuItem2,
            this.advancedCipherToolStripMenuItem2});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            // 
            // caesarCipherToolStripMenuItem2
            // 
            this.caesarCipherToolStripMenuItem2.Name = "caesarCipherToolStripMenuItem2";
            this.caesarCipherToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.caesarCipherToolStripMenuItem2.Text = "Caesar Cipher ";
            this.caesarCipherToolStripMenuItem2.Click += new System.EventHandler(this.caesarCipherToolStripMenuItem2_Click);
            // 
            // advancedCipherToolStripMenuItem2
            // 
            this.advancedCipherToolStripMenuItem2.Name = "advancedCipherToolStripMenuItem2";
            this.advancedCipherToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.advancedCipherToolStripMenuItem2.Text = "Advanced Cipher ";
            this.advancedCipherToolStripMenuItem2.Click += new System.EventHandler(this.advancedCipherToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearConsoleToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearConsoleToolStripMenuItem
            // 
            this.clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            this.clearConsoleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.clearConsoleToolStripMenuItem.Text = "Clear Console";
            this.clearConsoleToolStripMenuItem.Click += new System.EventHandler(this.clearConsoleToolStripMenuItem_Click);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 586);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Gui";
            this.Text = "Decrypt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesarCipherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem advancedCipherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesarCipherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem advancedCipherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptedTextToolStripMenuItem;
    }
}

