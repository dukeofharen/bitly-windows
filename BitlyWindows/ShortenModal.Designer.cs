namespace BitlyWindows
{
    partial class ShortenModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortenModal));
            this.label1 = new System.Windows.Forms.Label();
            this.longURLBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shortURLBox = new System.Windows.Forms.TextBox();
            this.shortenURLButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Long URL";
            // 
            // longURLBox
            // 
            this.longURLBox.AcceptsReturn = true;
            this.longURLBox.Location = new System.Drawing.Point(13, 30);
            this.longURLBox.Name = "longURLBox";
            this.longURLBox.Size = new System.Drawing.Size(259, 20);
            this.longURLBox.TabIndex = 1;
            this.longURLBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.longURLBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Short URL";
            // 
            // shortURLBox
            // 
            this.shortURLBox.Location = new System.Drawing.Point(13, 108);
            this.shortURLBox.Name = "shortURLBox";
            this.shortURLBox.ReadOnly = true;
            this.shortURLBox.Size = new System.Drawing.Size(259, 20);
            this.shortURLBox.TabIndex = 3;
            this.shortURLBox.DoubleClick += new System.EventHandler(this.shortURLBox_DoubleClick);
            // 
            // shortenURLButton
            // 
            this.shortenURLButton.Location = new System.Drawing.Point(12, 56);
            this.shortenURLButton.Name = "shortenURLButton";
            this.shortenURLButton.Size = new System.Drawing.Size(93, 23);
            this.shortenURLButton.TabIndex = 4;
            this.shortenURLButton.Text = "Shorten URL";
            this.shortenURLButton.UseVisualStyleBackColor = true;
            this.shortenURLButton.Click += new System.EventHandler(this.shortenURLButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Double click the \"Short URL\" box to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "copy the link to the clipboard.";
            // 
            // ShortenModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shortenURLButton);
            this.Controls.Add(this.shortURLBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.longURLBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortenModal";
            this.Text = "Shorten a URL";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox longURLBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortURLBox;
        private System.Windows.Forms.Button shortenURLButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

