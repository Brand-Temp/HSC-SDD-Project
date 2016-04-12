namespace WindowsFormsApplication1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptFromFileButton = new System.Windows.Forms.Button();
            this.decryptFromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(110, 14);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(279, 20);
            this.inputBox.TabIndex = 0;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(110, 41);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(279, 20);
            this.keyBox.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(110, 67);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outputBox.Size = new System.Drawing.Size(279, 77);
            this.outputBox.TabIndex = 2;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(46, 150);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(125, 59);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 14);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(65, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Enter String:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(12, 41);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(81, 13);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Encryption Key:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 67);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(88, 13);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Encrypted String:";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(226, 150);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(125, 59);
            this.decryptButton.TabIndex = 7;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptFromFileButton
            // 
            this.encryptFromFileButton.Location = new System.Drawing.Point(46, 215);
            this.encryptFromFileButton.Name = "encryptFromFileButton";
            this.encryptFromFileButton.Size = new System.Drawing.Size(125, 59);
            this.encryptFromFileButton.TabIndex = 8;
            this.encryptFromFileButton.Text = "Encrypt From File";
            this.encryptFromFileButton.UseVisualStyleBackColor = true;
            this.encryptFromFileButton.Click += new System.EventHandler(this.encryptFromFileButton_Click);
            // 
            // decryptFromFileButton
            // 
            this.decryptFromFileButton.Location = new System.Drawing.Point(226, 216);
            this.decryptFromFileButton.Name = "decryptFromFileButton";
            this.decryptFromFileButton.Size = new System.Drawing.Size(125, 58);
            this.decryptFromFileButton.TabIndex = 9;
            this.decryptFromFileButton.Text = "Decrypt From File";
            this.decryptFromFileButton.UseVisualStyleBackColor = true;
            this.decryptFromFileButton.Click += new System.EventHandler(this.decryptFromFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 314);
            this.Controls.Add(this.decryptFromFileButton);
            this.Controls.Add(this.encryptFromFileButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptFromFileButton;
        private System.Windows.Forms.Button decryptFromFileButton;
    }
}

