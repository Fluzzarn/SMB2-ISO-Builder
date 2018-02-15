namespace SMB2ISOBuilder
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SMB2_ISO_Browse = new System.Windows.Forms.Button();
            this.SMB2_ISO_textbox = new System.Windows.Forms.TextBox();
            this.SMB2ISOLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ZIP_Browse = new System.Windows.Forms.Button();
            this.ZIP_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OutputBrowse = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OututLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SMB2_ISO_Browse);
            this.panel2.Controls.Add(this.SMB2_ISO_textbox);
            this.panel2.Controls.Add(this.SMB2ISOLabel);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 30);
            this.panel2.TabIndex = 2;
            // 
            // SMB2_ISO_Browse
            // 
            this.SMB2_ISO_Browse.Location = new System.Drawing.Point(203, 1);
            this.SMB2_ISO_Browse.Name = "SMB2_ISO_Browse";
            this.SMB2_ISO_Browse.Size = new System.Drawing.Size(75, 23);
            this.SMB2_ISO_Browse.TabIndex = 2;
            this.SMB2_ISO_Browse.Text = "Browse...";
            this.SMB2_ISO_Browse.UseVisualStyleBackColor = true;
            this.SMB2_ISO_Browse.Click += new System.EventHandler(this.SMB2_ISO_Browse_Click);
            // 
            // SMB2_ISO_textbox
            // 
            this.SMB2_ISO_textbox.Location = new System.Drawing.Point(97, 3);
            this.SMB2_ISO_textbox.Name = "SMB2_ISO_textbox";
            this.SMB2_ISO_textbox.Size = new System.Drawing.Size(100, 20);
            this.SMB2_ISO_textbox.TabIndex = 1;
            // 
            // SMB2ISOLabel
            // 
            this.SMB2ISOLabel.AutoSize = true;
            this.SMB2ISOLabel.Location = new System.Drawing.Point(4, 7);
            this.SMB2ISOLabel.Name = "SMB2ISOLabel";
            this.SMB2ISOLabel.Size = new System.Drawing.Size(60, 13);
            this.SMB2ISOLabel.TabIndex = 0;
            this.SMB2ISOLabel.Text = "SMB2 ISO:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ZIP_Browse);
            this.panel3.Controls.Add(this.ZIP_textbox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 30);
            this.panel3.TabIndex = 3;
            // 
            // ZIP_Browse
            // 
            this.ZIP_Browse.Location = new System.Drawing.Point(203, 2);
            this.ZIP_Browse.Name = "ZIP_Browse";
            this.ZIP_Browse.Size = new System.Drawing.Size(75, 23);
            this.ZIP_Browse.TabIndex = 2;
            this.ZIP_Browse.Text = "Browse...";
            this.ZIP_Browse.UseVisualStyleBackColor = true;
            this.ZIP_Browse.Click += new System.EventHandler(this.ZIP_Browse_Click);
            // 
            // ZIP_textbox
            // 
            this.ZIP_textbox.Location = new System.Drawing.Point(97, 4);
            this.ZIP_textbox.Name = "ZIP_textbox";
            this.ZIP_textbox.Size = new System.Drawing.Size(100, 20);
            this.ZIP_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ZIP File:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(109, 156);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(100, 23);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.OutputBrowse);
            this.panel4.Controls.Add(this.OutputTextBox);
            this.panel4.Controls.Add(this.OututLabel);
            this.panel4.Location = new System.Drawing.Point(13, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 30);
            this.panel4.TabIndex = 4;
            // 
            // OutputBrowse
            // 
            this.OutputBrowse.Location = new System.Drawing.Point(203, 2);
            this.OutputBrowse.Name = "OutputBrowse";
            this.OutputBrowse.Size = new System.Drawing.Size(75, 23);
            this.OutputBrowse.TabIndex = 2;
            this.OutputBrowse.Text = "Browse...";
            this.OutputBrowse.UseVisualStyleBackColor = true;
            this.OutputBrowse.Click += new System.EventHandler(this.OutputBrowse_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(97, 4);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputTextBox.TabIndex = 1;
            // 
            // OututLabel
            // 
            this.OututLabel.AutoSize = true;
            this.OututLabel.Location = new System.Drawing.Point(4, 7);
            this.OututLabel.Name = "OututLabel";
            this.OututLabel.Size = new System.Drawing.Size(74, 13);
            this.OututLabel.TabIndex = 0;
            this.OututLabel.Text = "Output Folder:";
            // 
            // logTextBox
            // 
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(13, 185);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(274, 253);
            this.logTextBox.TabIndex = 5;
            this.logTextBox.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nameBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(12, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 30);
            this.panel5.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(97, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "SMB2ISO";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SMB2_ISO_Browse;
        private System.Windows.Forms.TextBox SMB2_ISO_textbox;
        private System.Windows.Forms.Label SMB2ISOLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ZIP_Browse;
        private System.Windows.Forms.TextBox ZIP_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button OutputBrowse;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label OututLabel;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}

