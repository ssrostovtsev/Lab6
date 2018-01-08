namespace SimCorp.IMS.MobilePhoneWithThreadingTasks {
    partial class MobilePhoneWithTreadingTasksForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.SMSTextLabel = new System.Windows.Forms.Label();
            this.SMSNumberLabel = new System.Windows.Forms.Label();
            this.OrCheckBox = new System.Windows.Forms.CheckBox();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SMSTextTextBox = new System.Windows.Forms.TextBox();
            this.SMSNumberComboBox = new System.Windows.Forms.ComboBox();
            this.ChargeButton = new System.Windows.Forms.Button();
            this.ChargeProgressBar = new System.Windows.Forms.ProgressBar();
            this.ChargeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // MessageListBox
            // 
            this.MessageListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.Location = new System.Drawing.Point(0, 187);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(499, 134);
            this.MessageListBox.TabIndex = 0;
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Location = new System.Drawing.Point(337, 97);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(20, 13);
            this.ToDateLabel.TabIndex = 21;
            this.ToDateLabel.Text = "To";
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Location = new System.Drawing.Point(174, 97);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(30, 13);
            this.FromDateLabel.TabIndex = 20;
            this.FromDateLabel.Text = "From";
            // 
            // SMSTextLabel
            // 
            this.SMSTextLabel.AutoSize = true;
            this.SMSTextLabel.Location = new System.Drawing.Point(174, 60);
            this.SMSTextLabel.Name = "SMSTextLabel";
            this.SMSTextLabel.Size = new System.Drawing.Size(113, 13);
            this.SMSTextLabel.TabIndex = 19;
            this.SMSTextLabel.Text = "Message text contains";
            // 
            // SMSNumberLabel
            // 
            this.SMSNumberLabel.AutoSize = true;
            this.SMSNumberLabel.Location = new System.Drawing.Point(174, 19);
            this.SMSNumberLabel.Name = "SMSNumberLabel";
            this.SMSNumberLabel.Size = new System.Drawing.Size(129, 13);
            this.SMSNumberLabel.TabIndex = 18;
            this.SMSNumberLabel.Text = "Sender number starts with";
            // 
            // OrCheckBox
            // 
            this.OrCheckBox.AutoSize = true;
            this.OrCheckBox.Location = new System.Drawing.Point(177, 130);
            this.OrCheckBox.Name = "OrCheckBox";
            this.OrCheckBox.Size = new System.Drawing.Size(223, 17);
            this.OrCheckBox.TabIndex = 17;
            this.OrCheckBox.Text = "Use OR instead of AND in filter conditions";
            this.OrCheckBox.UseVisualStyleBackColor = true;
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Location = new System.Drawing.Point(177, 159);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilterButton.TabIndex = 16;
            this.ApplyFilterButton.Text = "Apply filter";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(363, 95);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.ToDateTimePicker.TabIndex = 15;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(210, 95);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FromDateTimePicker.TabIndex = 14;
            // 
            // SMSTextTextBox
            // 
            this.SMSTextTextBox.Location = new System.Drawing.Point(315, 57);
            this.SMSTextTextBox.Name = "SMSTextTextBox";
            this.SMSTextTextBox.Size = new System.Drawing.Size(169, 20);
            this.SMSTextTextBox.TabIndex = 13;
            // 
            // SMSNumberComboBox
            // 
            this.SMSNumberComboBox.FormattingEnabled = true;
            this.SMSNumberComboBox.Location = new System.Drawing.Point(315, 19);
            this.SMSNumberComboBox.Name = "SMSNumberComboBox";
            this.SMSNumberComboBox.Size = new System.Drawing.Size(169, 21);
            this.SMSNumberComboBox.TabIndex = 12;
            // 
            // ChargeButton
            // 
            this.ChargeButton.Location = new System.Drawing.Point(21, 57);
            this.ChargeButton.Name = "ChargeButton";
            this.ChargeButton.Size = new System.Drawing.Size(134, 23);
            this.ChargeButton.TabIndex = 22;
            this.ChargeButton.Text = "Charge";
            this.ChargeButton.UseVisualStyleBackColor = true;
            this.ChargeButton.Click += new System.EventHandler(this.ChargeButton_Click);
            // 
            // ChargeProgressBar
            // 
            this.ChargeProgressBar.Location = new System.Drawing.Point(12, 19);
            this.ChargeProgressBar.Name = "ChargeProgressBar";
            this.ChargeProgressBar.Size = new System.Drawing.Size(156, 23);
            this.ChargeProgressBar.TabIndex = 24;
            // 
            // ChargeBackgroundWorker
            // 
            this.ChargeBackgroundWorker.WorkerReportsProgress = true;
            this.ChargeBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ChargeBackgroundWorker_DoWork);
            this.ChargeBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ChargeBackgroundWorker_ProgressChanged);
            // 
            // MobilePhoneWithTreadingTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 321);
            this.Controls.Add(this.ChargeProgressBar);
            this.Controls.Add(this.ChargeButton);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.SMSTextLabel);
            this.Controls.Add(this.SMSNumberLabel);
            this.Controls.Add(this.OrCheckBox);
            this.Controls.Add(this.ApplyFilterButton);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.SMSTextTextBox);
            this.Controls.Add(this.SMSNumberComboBox);
            this.Controls.Add(this.MessageListBox);
            this.Name = "MobilePhoneWithTreadingTasksForm";
            this.Text = "Mobile phone with Threading and Tasks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MobilePhoneWithTreadingTasksForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label SMSTextLabel;
        private System.Windows.Forms.Label SMSNumberLabel;
        private System.Windows.Forms.CheckBox OrCheckBox;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.TextBox SMSTextTextBox;
        private System.Windows.Forms.ComboBox SMSNumberComboBox;
        private System.Windows.Forms.Button ChargeButton;
        private System.Windows.Forms.ProgressBar ChargeProgressBar;
        private System.ComponentModel.BackgroundWorker ChargeBackgroundWorker;
    }
}

