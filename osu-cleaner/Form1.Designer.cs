namespace osu_cleaner
{
    partial class MainApp
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
            this.elementList = new System.Windows.Forms.CheckedListBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryPath = new System.Windows.Forms.TextBox();
            this.directorySelectButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.DeletePermanentlyCheckbox = new System.Windows.Forms.CheckBox();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.filesSizeLabel = new System.Windows.Forms.Label();
            this.forRemovalSizeLabel = new System.Windows.Forms.Label();
            this.backgroundKeepCheckbox = new System.Windows.Forms.CheckBox();
            this.moveCheckBox = new System.Windows.Forms.CheckBox();
            this.wavFileKeepCheckbox = new System.Windows.Forms.CheckBox();
            this.FindProgressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundReplaceCheckBox = new System.Windows.Forms.CheckBox();
            this.removeEmptyFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elementList
            // 
            this.elementList.CheckOnClick = true;
            this.elementList.FormattingEnabled = true;
            this.elementList.Location = new System.Drawing.Point(9, 138);
            this.elementList.Name = "elementList";
            this.elementList.Size = new System.Drawing.Size(728, 324);
            this.elementList.TabIndex = 9;
            this.elementList.SelectedIndexChanged += new System.EventHandler(this.elementList_SelectedIndexChanged);
            // 
            // directoryLabel
            // 
            this.directoryLabel.Location = new System.Drawing.Point(12, 9);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(100, 21);
            this.directoryLabel.TabIndex = 8;
            this.directoryLabel.Text = "osu! directory path:";
            // 
            // directoryPath
            // 
            this.directoryPath.Location = new System.Drawing.Point(115, 6);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(460, 21);
            this.directoryPath.TabIndex = 7;
            // 
            // directorySelectButton
            // 
            this.directorySelectButton.Location = new System.Drawing.Point(581, 5);
            this.directorySelectButton.Name = "directorySelectButton";
            this.directorySelectButton.Size = new System.Drawing.Size(75, 22);
            this.directorySelectButton.TabIndex = 6;
            this.directorySelectButton.Text = "Browse";
            this.directorySelectButton.UseVisualStyleBackColor = true;
            this.directorySelectButton.Click += new System.EventHandler(this.directorySelectButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(665, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 21);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(581, 106);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 21);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // DeletePermanentlyCheckbox
            // 
            this.DeletePermanentlyCheckbox.Checked = true;
            this.DeletePermanentlyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeletePermanentlyCheckbox.Location = new System.Drawing.Point(12, 538);
            this.DeletePermanentlyCheckbox.Name = "DeletePermanentlyCheckbox";
            this.DeletePermanentlyCheckbox.Size = new System.Drawing.Size(281, 22);
            this.DeletePermanentlyCheckbox.TabIndex = 0;
            this.DeletePermanentlyCheckbox.Text = "Delete permanently instead of moving to Recycle Bin";
            this.DeletePermanentlyCheckbox.UseVisualStyleBackColor = true;
            this.DeletePermanentlyCheckbox.CheckedChanged += new System.EventHandler(this.DeletePermanentlyCheckbox_CheckedChanged);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(584, 511);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 21);
            this.selectAllButton.TabIndex = 10;
            this.selectAllButton.Text = "Select all";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.Location = new System.Drawing.Point(665, 511);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(75, 21);
            this.deselectAllButton.TabIndex = 11;
            this.deselectAllButton.Text = "Unselect all";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // filesSizeLabel
            // 
            this.filesSizeLabel.AutoSize = true;
            this.filesSizeLabel.Location = new System.Drawing.Point(9, 511);
            this.filesSizeLabel.Name = "filesSizeLabel";
            this.filesSizeLabel.Size = new System.Drawing.Size(71, 12);
            this.filesSizeLabel.TabIndex = 12;
            this.filesSizeLabel.Text = "Found: 0 MB";
            // 
            // forRemovalSizeLabel
            // 
            this.forRemovalSizeLabel.AutoSize = true;
            this.forRemovalSizeLabel.Location = new System.Drawing.Point(9, 523);
            this.forRemovalSizeLabel.Name = "forRemovalSizeLabel";
            this.forRemovalSizeLabel.Size = new System.Drawing.Size(155, 12);
            this.forRemovalSizeLabel.TabIndex = 13;
            this.forRemovalSizeLabel.Text = "Selected for removal: 0MB";
            // 
            // backgroundKeepCheckbox
            // 
            this.backgroundKeepCheckbox.AutoSize = true;
            this.backgroundKeepCheckbox.Checked = true;
            this.backgroundKeepCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backgroundKeepCheckbox.Location = new System.Drawing.Point(14, 45);
            this.backgroundKeepCheckbox.Name = "backgroundKeepCheckbox";
            this.backgroundKeepCheckbox.Size = new System.Drawing.Size(120, 16);
            this.backgroundKeepCheckbox.TabIndex = 14;
            this.backgroundKeepCheckbox.Text = "Keep backgrounds";
            this.backgroundKeepCheckbox.UseVisualStyleBackColor = true;
            // 
            // moveCheckBox
            // 
            this.moveCheckBox.AutoSize = true;
            this.moveCheckBox.Location = new System.Drawing.Point(12, 564);
            this.moveCheckBox.Name = "moveCheckBox";
            this.moveCheckBox.Size = new System.Drawing.Size(246, 16);
            this.moveCheckBox.TabIndex = 15;
            this.moveCheckBox.Text = "Move to \'Cleaned\' instead of removing";
            this.moveCheckBox.UseVisualStyleBackColor = true;
            this.moveCheckBox.CheckedChanged += new System.EventHandler(this.moveCheckBox_CheckedChanged);
            // 
            // wavFileKeepCheckbox
            // 
            this.wavFileKeepCheckbox.AutoSize = true;
            this.wavFileKeepCheckbox.Location = new System.Drawing.Point(14, 89);
            this.wavFileKeepCheckbox.Name = "wavFileKeepCheckbox";
            this.wavFileKeepCheckbox.Size = new System.Drawing.Size(114, 16);
            this.wavFileKeepCheckbox.TabIndex = 16;
            this.wavFileKeepCheckbox.Text = "Keep .wav files";
            this.wavFileKeepCheckbox.UseVisualStyleBackColor = true;
            // 
            // FindProgressBar
            // 
            this.FindProgressBar.Location = new System.Drawing.Point(9, 472);
            this.FindProgressBar.Name = "FindProgressBar";
            this.FindProgressBar.Size = new System.Drawing.Size(728, 21);
            this.FindProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FindProgressBar.TabIndex = 17;
            this.FindProgressBar.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(665, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 21);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backgroundReplaceCheckBox
            // 
            this.backgroundReplaceCheckBox.AutoSize = true;
            this.backgroundReplaceCheckBox.Location = new System.Drawing.Point(43, 67);
            this.backgroundReplaceCheckBox.Name = "backgroundReplaceCheckBox";
            this.backgroundReplaceCheckBox.Size = new System.Drawing.Size(138, 16);
            this.backgroundReplaceCheckBox.TabIndex = 19;
            this.backgroundReplaceCheckBox.Text = "Replace backgrounds";
            this.backgroundReplaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeEmptyFolderCheckBox
            // 
            this.removeEmptyFolderCheckBox.AutoSize = true;
            this.removeEmptyFolderCheckBox.Checked = true;
            this.removeEmptyFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeEmptyFolderCheckBox.Location = new System.Drawing.Point(14, 111);
            this.removeEmptyFolderCheckBox.Name = "removeEmptyFolderCheckBox";
            this.removeEmptyFolderCheckBox.Size = new System.Drawing.Size(138, 16);
            this.removeEmptyFolderCheckBox.TabIndex = 20;
            this.removeEmptyFolderCheckBox.Text = "Remove empty folder";
            this.removeEmptyFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Warning: Will delete all files except .osu and .mp3 files";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeEmptyFolderCheckBox);
            this.Controls.Add(this.backgroundReplaceCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.FindProgressBar);
            this.Controls.Add(this.wavFileKeepCheckbox);
            this.Controls.Add(this.moveCheckBox);
            this.Controls.Add(this.backgroundKeepCheckbox);
            this.Controls.Add(this.forRemovalSizeLabel);
            this.Controls.Add(this.filesSizeLabel);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.DeletePermanentlyCheckbox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.directorySelectButton);
            this.Controls.Add(this.directoryPath);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.elementList);
            this.Name = "MainApp";
            this.Text = "osu! Fully Cleaner v1.1";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryPath;
        private System.Windows.Forms.Button directorySelectButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.CheckBox DeletePermanentlyCheckbox;
        private System.Windows.Forms.CheckedListBox elementList;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button deselectAllButton;
        private System.Windows.Forms.Label filesSizeLabel;
        private System.Windows.Forms.Label forRemovalSizeLabel;
        private System.Windows.Forms.CheckBox backgroundKeepCheckbox;
        private System.Windows.Forms.CheckBox moveCheckBox;
        private System.Windows.Forms.CheckBox wavFileKeepCheckbox;
        private System.Windows.Forms.ProgressBar FindProgressBar;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox backgroundReplaceCheckBox;
        private System.Windows.Forms.CheckBox removeEmptyFolderCheckBox;
        private System.Windows.Forms.Label label1;
    }
}

