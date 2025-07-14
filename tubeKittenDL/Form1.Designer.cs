namespace tubeKittenDL
{
    partial class TubeKitten
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TubeKitten));
            urlTextBox = new TextBox();
            downloadButton = new Button();
            formatDropdown = new ComboBox();
            whiskerVisionLogo = new PictureBox();
            titlePanel = new Panel();
            whiskVisionTitleBar = new PictureBox();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)whiskerVisionLogo).BeginInit();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)whiskVisionTitleBar).BeginInit();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.BorderStyle = BorderStyle.None;
            urlTextBox.ForeColor = SystemColors.WindowFrame;
            urlTextBox.Location = new Point(230, 288);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "Enter URL";
            urlTextBox.Size = new Size(341, 16);
            urlTextBox.TabIndex = 1;
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(496, 309);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(75, 23);
            downloadButton.TabIndex = 2;
            downloadButton.Text = "download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // formatDropdown
            // 
            formatDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            formatDropdown.FormattingEnabled = true;
            formatDropdown.Items.AddRange(new object[] { "video", "audio" });
            formatDropdown.Location = new Point(230, 310);
            formatDropdown.Name = "formatDropdown";
            formatDropdown.Size = new Size(75, 23);
            formatDropdown.TabIndex = 3;
            // 
            // whiskerVisionLogo
            // 
            whiskerVisionLogo.BackgroundImage = Properties.Resources.android_chrome_512x512;
            whiskerVisionLogo.BackgroundImageLayout = ImageLayout.Stretch;
            whiskerVisionLogo.Location = new Point(300, 30);
            whiskerVisionLogo.Name = "whiskerVisionLogo";
            whiskerVisionLogo.Size = new Size(200, 200);
            whiskerVisionLogo.TabIndex = 4;
            whiskerVisionLogo.TabStop = false;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(35, 35, 35);
            titlePanel.Controls.Add(whiskVisionTitleBar);
            titlePanel.Controls.Add(closeButton);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(800, 25);
            titlePanel.TabIndex = 5;
            titlePanel.MouseDown += titlePanel_MouseDown;
            // 
            // whiskVisionTitleBar
            // 
            whiskVisionTitleBar.BackgroundImage = Properties.Resources.android_chrome_512x512;
            whiskVisionTitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            whiskVisionTitleBar.InitialImage = Properties.Resources.android_chrome_512x512;
            whiskVisionTitleBar.Location = new Point(3, 0);
            whiskVisionTitleBar.Name = "whiskVisionTitleBar";
            whiskVisionTitleBar.Size = new Size(25, 25);
            whiskVisionTitleBar.TabIndex = 6;
            whiskVisionTitleBar.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 8F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(772, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 25);
            closeButton.TabIndex = 0;
            closeButton.Text = "🗙";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += button1_Click;
            // 
            // TubeKitten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(titlePanel);
            Controls.Add(whiskerVisionLogo);
            Controls.Add(formatDropdown);
            Controls.Add(downloadButton);
            Controls.Add(urlTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TubeKitten";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)whiskerVisionLogo).EndInit();
            titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)whiskVisionTitleBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox urlTextBox;
        private Button downloadButton;
        private ComboBox formatDropdown;
        private PictureBox whiskerVisionLogo;
        private Panel titlePanel;
        private Button closeButton;
        private PictureBox whiskVisionTitleBar;
    }
}
