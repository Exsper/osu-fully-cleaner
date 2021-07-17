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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
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
            this.label2 = new System.Windows.Forms.Label();
            this.creatorsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // elementList
            // 
            this.elementList.CheckOnClick = true;
            this.elementList.FormattingEnabled = true;
            resources.ApplyResources(this.elementList, "elementList");
            this.elementList.Name = "elementList";
            this.elementList.SelectedIndexChanged += new System.EventHandler(this.elementList_SelectedIndexChanged);
            // 
            // directoryLabel
            // 
            resources.ApplyResources(this.directoryLabel, "directoryLabel");
            this.directoryLabel.Name = "directoryLabel";
            // 
            // directoryPath
            // 
            resources.ApplyResources(this.directoryPath, "directoryPath");
            this.directoryPath.Name = "directoryPath";
            // 
            // directorySelectButton
            // 
            resources.ApplyResources(this.directorySelectButton, "directorySelectButton");
            this.directorySelectButton.Name = "directorySelectButton";
            this.directorySelectButton.UseVisualStyleBackColor = true;
            this.directorySelectButton.Click += new System.EventHandler(this.directorySelectButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // findButton
            // 
            resources.ApplyResources(this.findButton, "findButton");
            this.findButton.Name = "findButton";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // DeletePermanentlyCheckbox
            // 
            this.DeletePermanentlyCheckbox.Checked = true;
            this.DeletePermanentlyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.DeletePermanentlyCheckbox, "DeletePermanentlyCheckbox");
            this.DeletePermanentlyCheckbox.Name = "DeletePermanentlyCheckbox";
            this.DeletePermanentlyCheckbox.UseVisualStyleBackColor = true;
            this.DeletePermanentlyCheckbox.CheckedChanged += new System.EventHandler(this.DeletePermanentlyCheckbox_CheckedChanged);
            // 
            // selectAllButton
            // 
            resources.ApplyResources(this.selectAllButton, "selectAllButton");
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllButton
            // 
            resources.ApplyResources(this.deselectAllButton, "deselectAllButton");
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.UseVisualStyleBackColor = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // filesSizeLabel
            // 
            resources.ApplyResources(this.filesSizeLabel, "filesSizeLabel");
            this.filesSizeLabel.Name = "filesSizeLabel";
            // 
            // forRemovalSizeLabel
            // 
            resources.ApplyResources(this.forRemovalSizeLabel, "forRemovalSizeLabel");
            this.forRemovalSizeLabel.Name = "forRemovalSizeLabel";
            // 
            // backgroundKeepCheckbox
            // 
            resources.ApplyResources(this.backgroundKeepCheckbox, "backgroundKeepCheckbox");
            this.backgroundKeepCheckbox.Checked = true;
            this.backgroundKeepCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backgroundKeepCheckbox.Name = "backgroundKeepCheckbox";
            this.backgroundKeepCheckbox.UseVisualStyleBackColor = true;
            // 
            // moveCheckBox
            // 
            resources.ApplyResources(this.moveCheckBox, "moveCheckBox");
            this.moveCheckBox.Name = "moveCheckBox";
            this.moveCheckBox.UseVisualStyleBackColor = true;
            this.moveCheckBox.CheckedChanged += new System.EventHandler(this.moveCheckBox_CheckedChanged);
            // 
            // wavFileKeepCheckbox
            // 
            resources.ApplyResources(this.wavFileKeepCheckbox, "wavFileKeepCheckbox");
            this.wavFileKeepCheckbox.Name = "wavFileKeepCheckbox";
            this.wavFileKeepCheckbox.UseVisualStyleBackColor = true;
            // 
            // FindProgressBar
            // 
            resources.ApplyResources(this.FindProgressBar, "FindProgressBar");
            this.FindProgressBar.Name = "FindProgressBar";
            this.FindProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backgroundReplaceCheckBox
            // 
            resources.ApplyResources(this.backgroundReplaceCheckBox, "backgroundReplaceCheckBox");
            this.backgroundReplaceCheckBox.Name = "backgroundReplaceCheckBox";
            this.backgroundReplaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeEmptyFolderCheckBox
            // 
            resources.ApplyResources(this.removeEmptyFolderCheckBox, "removeEmptyFolderCheckBox");
            this.removeEmptyFolderCheckBox.Checked = true;
            this.removeEmptyFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeEmptyFolderCheckBox.Name = "removeEmptyFolderCheckBox";
            this.removeEmptyFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // creatorsTextBox
            // 
            resources.ApplyResources(this.creatorsTextBox, "creatorsTextBox");
            this.creatorsTextBox.Name = "creatorsTextBox";
            // 
            // MainApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creatorsTextBox);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creatorsTextBox;
    }
}

