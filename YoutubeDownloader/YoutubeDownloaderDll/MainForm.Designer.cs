namespace YoutubeDownloaderDll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.urlInfoTextBox = new System.Windows.Forms.TextBox();
            this.urlSearchTextBox = new System.Windows.Forms.TextBox();
            this.urlSearchButton = new System.Windows.Forms.Button();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.searchDownloadPathButton = new System.Windows.Forms.Button();
            this.downloadPathComboBox = new System.Windows.Forms.ComboBox();
            this.downloadPathInfoTextBox = new System.Windows.Forms.TextBox();
            this.youtubeGroupBox = new System.Windows.Forms.GroupBox();
            this.downloadingPanel = new System.Windows.Forms.Panel();
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
            this.urlSearchTextBox.Size = new System.Drawing.Size(397, 21);
            this.urlSearchTextBox.TabIndex = 3;
            // 
            // urlSearchButton
            // 
            this.urlSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.urlSearchButton.Location = new System.Drawing.Point(491, 15);
            this.urlSearchButton.Name = "urlSearchButton";
            this.urlSearchButton.Size = new System.Drawing.Size(77, 23);
            this.urlSearchButton.TabIndex = 4;
            this.urlSearchButton.Text = "검색";
            this.urlSearchButton.UseVisualStyleBackColor = true;
            this.urlSearchButton.Click += new System.EventHandler(this.urlSearchButton_Click);
            // 
            // userGroupBox
            // 
            this.userGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGroupBox.Controls.Add(this.searchDownloadPathButton);
            this.userGroupBox.Controls.Add(this.downloadPathComboBox);
            this.userGroupBox.Controls.Add(this.downloadPathInfoTextBox);
            this.userGroupBox.Location = new System.Drawing.Point(12, 12);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(574, 47);
            this.userGroupBox.TabIndex = 3;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "사용자정보";
            // 
            // searchDownloadPathButton
            // 
            this.searchDownloadPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDownloadPathButton.Location = new System.Drawing.Point(491, 15);
            this.searchDownloadPathButton.Name = "searchDownloadPathButton";
            this.searchDownloadPathButton.Size = new System.Drawing.Size(77, 23);
            this.searchDownloadPathButton.TabIndex = 2;
            this.searchDownloadPathButton.Text = "경로추가";
            this.searchDownloadPathButton.UseVisualStyleBackColor = true;
            this.searchDownloadPathButton.Click += new System.EventHandler(this.searchDownloadPathButton_Click);
            // 
            // downloadPathComboBox
            // 
            this.downloadPathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadPathComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadPathComboBox.FormattingEnabled = true;
            this.downloadPathComboBox.Location = new System.Drawing.Point(88, 17);
            this.downloadPathComboBox.Name = "downloadPathComboBox";
            this.downloadPathComboBox.Size = new System.Drawing.Size(397, 20);
            this.downloadPathComboBox.TabIndex = 1;
            this.downloadPathComboBox.SelectedIndexChanged += new System.EventHandler(this.downloadPathComboBox_SelectedIndexChanged);
            // 
            // downloadPathInfoTextBox
            // 
            this.downloadPathInfoTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.downloadPathInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.downloadPathInfoTextBox.Location = new System.Drawing.Point(6, 20);
            this.downloadPathInfoTextBox.Name = "downloadPathInfoTextBox";
            this.downloadPathInfoTextBox.Size = new System.Drawing.Size(76, 14);
            this.downloadPathInfoTextBox.TabIndex = 0;
            this.downloadPathInfoTextBox.Text = "저장경로";
            // 
            // youtubeGroupBox
            // 
            this.youtubeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.youtubeGroupBox.Controls.Add(this.downloadingPanel);
            this.youtubeGroupBox.Controls.Add(this.urlSearchButton);
            this.youtubeGroupBox.Controls.Add(this.urlInfoTextBox);
            this.youtubeGroupBox.Controls.Add(this.urlSearchTextBox);
            this.youtubeGroupBox.Location = new System.Drawing.Point(12, 66);
            this.youtubeGroupBox.Name = "youtubeGroupBox";
            this.youtubeGroupBox.Size = new System.Drawing.Size(574, 227);
            this.youtubeGroupBox.TabIndex = 4;
            this.youtubeGroupBox.TabStop = false;
            this.youtubeGroupBox.Text = "유투브 검색";
            // 
            // downloadingPanel
            // 
            this.downloadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadingPanel.AutoScroll = true;
            this.downloadingPanel.AutoSize = true;
            this.downloadingPanel.Location = new System.Drawing.Point(6, 44);
            this.downloadingPanel.Name = "downloadingPanel";
            this.downloadingPanel.Size = new System.Drawing.Size(562, 177);
            this.downloadingPanel.TabIndex = 5;
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(12, 299);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(574, 181);
            this.logTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 492);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.youtubeGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "유투브 다운로더";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.Button searchDownloadPathButton;
        private System.Windows.Forms.ComboBox downloadPathComboBox;
        private System.Windows.Forms.TextBox downloadPathInfoTextBox;
        private System.Windows.Forms.GroupBox youtubeGroupBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Panel downloadingPanel;
    }
}

