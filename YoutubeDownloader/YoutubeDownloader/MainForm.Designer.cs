namespace YoutubeDownloader
{
    partial class MainForm
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
            this.urlInfoTextBox = new System.Windows.Forms.TextBox();
            this.urlSearchTextBox = new System.Windows.Forms.TextBox();
            this.urlSearchButton = new System.Windows.Forms.Button();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.savePathComboBox = new System.Windows.Forms.ComboBox();
            this.savePathSearchButton = new System.Windows.Forms.Button();
            this.youtubeGroupBox = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.userGroupBox.SuspendLayout();
            this.youtubeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlInfoTextBox
            // 
            this.urlInfoTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.urlInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlInfoTextBox.Location = new System.Drawing.Point(6, 24);
            this.urlInfoTextBox.Name = "urlInfoTextBox";
            this.urlInfoTextBox.Size = new System.Drawing.Size(76, 14);
            this.urlInfoTextBox.TabIndex = 0;
            this.urlInfoTextBox.Text = "URL";
            // 
            // urlSearchTextBox
            // 
            this.urlSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlSearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.urlSearchTextBox.Location = new System.Drawing.Point(88, 17);
            this.urlSearchTextBox.Name = "urlSearchTextBox";
            this.urlSearchTextBox.Size = new System.Drawing.Size(231, 21);
            this.urlSearchTextBox.TabIndex = 3;
            // 
            // urlSearchButton
            // 
            this.urlSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.urlSearchButton.Location = new System.Drawing.Point(325, 15);
            this.urlSearchButton.Name = "urlSearchButton";
            this.urlSearchButton.Size = new System.Drawing.Size(77, 23);
            this.urlSearchButton.TabIndex = 4;
            this.urlSearchButton.Text = "검색";
            this.urlSearchButton.UseVisualStyleBackColor = true;
            // 
            // userGroupBox
            // 
            this.userGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGroupBox.Controls.Add(this.savePathSearchButton);
            this.userGroupBox.Controls.Add(this.savePathComboBox);
            this.userGroupBox.Controls.Add(this.textBox1);
            this.userGroupBox.Location = new System.Drawing.Point(12, 12);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(408, 47);
            this.userGroupBox.TabIndex = 3;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "사용자정보";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "저장경로";
            // 
            // savePathComboBox
            // 
            this.savePathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePathComboBox.FormattingEnabled = true;
            this.savePathComboBox.Location = new System.Drawing.Point(88, 17);
            this.savePathComboBox.Name = "savePathComboBox";
            this.savePathComboBox.Size = new System.Drawing.Size(231, 20);
            this.savePathComboBox.TabIndex = 1;
            // 
            // savePathSearchButton
            // 
            this.savePathSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePathSearchButton.Location = new System.Drawing.Point(325, 15);
            this.savePathSearchButton.Name = "savePathSearchButton";
            this.savePathSearchButton.Size = new System.Drawing.Size(77, 23);
            this.savePathSearchButton.TabIndex = 2;
            this.savePathSearchButton.Text = "경로추가";
            this.savePathSearchButton.UseVisualStyleBackColor = true;
            // 
            // youtubeGroupBox
            // 
            this.youtubeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.youtubeGroupBox.Controls.Add(this.urlSearchButton);
            this.youtubeGroupBox.Controls.Add(this.urlInfoTextBox);
            this.youtubeGroupBox.Controls.Add(this.urlSearchTextBox);
            this.youtubeGroupBox.Location = new System.Drawing.Point(12, 66);
            this.youtubeGroupBox.Name = "youtubeGroupBox";
            this.youtubeGroupBox.Size = new System.Drawing.Size(408, 172);
            this.youtubeGroupBox.TabIndex = 4;
            this.youtubeGroupBox.TabStop = false;
            this.youtubeGroupBox.Text = "유투브 검색";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(12, 244);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(408, 237);
            this.logTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 493);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.youtubeGroupBox);
            this.Name = "MainForm";
            this.Text = "YoutubeDownloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.youtubeGroupBox.ResumeLayout(false);
            this.youtubeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlInfoTextBox;
        private System.Windows.Forms.TextBox urlSearchTextBox;
        private System.Windows.Forms.Button urlSearchButton;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Button savePathSearchButton;
        private System.Windows.Forms.ComboBox savePathComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox youtubeGroupBox;
        private System.Windows.Forms.TextBox logTextBox;
    }
}

