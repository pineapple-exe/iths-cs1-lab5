namespace JohannasLab5
{
    partial class IMGHunterForm
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
            this.components = new System.ComponentModel.Container();
            this.URLEaterTextBox = new System.Windows.Forms.TextBox();
            this.SaveImgsButton = new System.Windows.Forms.Button();
            this.HowManyIMGLinksLabel = new System.Windows.Forms.Label();
            this.LinksFoundTitleLabel = new System.Windows.Forms.Label();
            this.EnteURLLabel = new System.Windows.Forms.Label();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.ImageLinksTextBox = new System.Windows.Forms.TextBox();
            this.InvalidURILabel = new System.Windows.Forms.Label();
            this.InvalidURITimer = new System.Windows.Forms.Timer(this.components);
            this.ChooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.EmptyLinkLabel = new System.Windows.Forms.Label();
            this.DownloadCompletedLabel = new System.Windows.Forms.Label();
            this.DownloadCompletedTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // URLEaterTextBox
            // 
            this.URLEaterTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLEaterTextBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.URLEaterTextBox.Location = new System.Drawing.Point(50, 69);
            this.URLEaterTextBox.Name = "URLEaterTextBox";
            this.URLEaterTextBox.Size = new System.Drawing.Size(276, 24);
            this.URLEaterTextBox.TabIndex = 0;
            this.URLEaterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.URLEaterTextBox_KeyPress);
            // 
            // SaveImgsButton
            // 
            this.SaveImgsButton.Enabled = false;
            this.SaveImgsButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveImgsButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SaveImgsButton.Location = new System.Drawing.Point(50, 219);
            this.SaveImgsButton.Name = "SaveImgsButton";
            this.SaveImgsButton.Size = new System.Drawing.Size(93, 27);
            this.SaveImgsButton.TabIndex = 1;
            this.SaveImgsButton.Text = "Save Images";
            this.SaveImgsButton.UseVisualStyleBackColor = true;
            this.SaveImgsButton.Click += new System.EventHandler(this.SaveImgsButton_Click);
            // 
            // HowManyIMGLinksLabel
            // 
            this.HowManyIMGLinksLabel.AutoSize = true;
            this.HowManyIMGLinksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowManyIMGLinksLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HowManyIMGLinksLabel.Location = new System.Drawing.Point(206, 172);
            this.HowManyIMGLinksLabel.Name = "HowManyIMGLinksLabel";
            this.HowManyIMGLinksLabel.Size = new System.Drawing.Size(17, 19);
            this.HowManyIMGLinksLabel.TabIndex = 2;
            this.HowManyIMGLinksLabel.Text = "0";
            // 
            // LinksFoundTitleLabel
            // 
            this.LinksFoundTitleLabel.AutoSize = true;
            this.LinksFoundTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinksFoundTitleLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LinksFoundTitleLabel.Location = new System.Drawing.Point(46, 172);
            this.LinksFoundTitleLabel.Name = "LinksFoundTitleLabel";
            this.LinksFoundTitleLabel.Size = new System.Drawing.Size(196, 19);
            this.LinksFoundTitleLabel.TabIndex = 3;
            this.LinksFoundTitleLabel.Text = "Number of image links found:";
            // 
            // EnteURLLabel
            // 
            this.EnteURLLabel.AutoSize = true;
            this.EnteURLLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteURLLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.EnteURLLabel.Location = new System.Drawing.Point(46, 45);
            this.EnteURLLabel.Name = "EnteURLLabel";
            this.EnteURLLabel.Size = new System.Drawing.Size(77, 19);
            this.EnteURLLabel.TabIndex = 4;
            this.EnteURLLabel.Text = "Insert URL:";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ExtractButton.Location = new System.Drawing.Point(334, 68);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(59, 24);
            this.ExtractButton.TabIndex = 5;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // ImageLinksTextBox
            // 
            this.ImageLinksTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ImageLinksTextBox.Location = new System.Drawing.Point(440, 54);
            this.ImageLinksTextBox.Multiline = true;
            this.ImageLinksTextBox.Name = "ImageLinksTextBox";
            this.ImageLinksTextBox.ReadOnly = true;
            this.ImageLinksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ImageLinksTextBox.Size = new System.Drawing.Size(390, 496);
            this.ImageLinksTextBox.TabIndex = 6;
            // 
            // InvalidURILabel
            // 
            this.InvalidURILabel.AutoSize = true;
            this.InvalidURILabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidURILabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.InvalidURILabel.Location = new System.Drawing.Point(248, 97);
            this.InvalidURILabel.Name = "InvalidURILabel";
            this.InvalidURILabel.Size = new System.Drawing.Size(85, 19);
            this.InvalidURILabel.TabIndex = 7;
            this.InvalidURILabel.Text = "Invalid URL!";
            this.InvalidURILabel.Visible = false;
            // 
            // InvalidURITimer
            // 
            this.InvalidURITimer.Interval = 3000;
            this.InvalidURITimer.Tick += new System.EventHandler(this.InvalidURITimer_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(50, 263);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(276, 23);
            this.ProgressBar.TabIndex = 8;
            this.ProgressBar.Visible = false;
            // 
            // EmptyLinkLabel
            // 
            this.EmptyLinkLabel.AutoSize = true;
            this.EmptyLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyLinkLabel.Location = new System.Drawing.Point(46, 196);
            this.EmptyLinkLabel.Name = "EmptyLinkLabel";
            this.EmptyLinkLabel.Size = new System.Drawing.Size(136, 19);
            this.EmptyLinkLabel.TabIndex = 9;
            this.EmptyLinkLabel.Text = "Empty links: <num>";
            this.EmptyLinkLabel.Visible = false;
            // 
            // DownloadCompletedLabel
            // 
            this.DownloadCompletedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadCompletedLabel.Location = new System.Drawing.Point(153, 405);
            this.DownloadCompletedLabel.Name = "DownloadCompletedLabel";
            this.DownloadCompletedLabel.Size = new System.Drawing.Size(119, 19);
            this.DownloadCompletedLabel.TabIndex = 10;
            this.DownloadCompletedLabel.Text = "100% Completed!";
            this.DownloadCompletedLabel.Visible = false;
            // 
            // DownloadCompletedTimer
            // 
            this.DownloadCompletedTimer.Interval = 5000;
            this.DownloadCompletedTimer.Tick += new System.EventHandler(this.DownloadCompletedTimer_Tick);
            // 
            // IMGHunterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(883, 612);
            this.Controls.Add(this.DownloadCompletedLabel);
            this.Controls.Add(this.EmptyLinkLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.InvalidURILabel);
            this.Controls.Add(this.ImageLinksTextBox);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.EnteURLLabel);
            this.Controls.Add(this.LinksFoundTitleLabel);
            this.Controls.Add(this.HowManyIMGLinksLabel);
            this.Controls.Add(this.SaveImgsButton);
            this.Controls.Add(this.URLEaterTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IMGHunterForm";
            this.Text = "IMGHunter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLEaterTextBox;
        private System.Windows.Forms.Button SaveImgsButton;
        private System.Windows.Forms.Label HowManyIMGLinksLabel;
        private System.Windows.Forms.Label LinksFoundTitleLabel;
        private System.Windows.Forms.Label EnteURLLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox ImageLinksTextBox;
        private System.Windows.Forms.Label InvalidURILabel;
        private System.Windows.Forms.Timer InvalidURITimer;
        private System.Windows.Forms.FolderBrowserDialog ChooseFolderDialog;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label EmptyLinkLabel;
        private System.Windows.Forms.Timer DownloadCompletedTimer;
        private System.Windows.Forms.Label DownloadCompletedLabel;
    }
}

