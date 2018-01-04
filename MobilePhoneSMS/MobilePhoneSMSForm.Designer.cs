namespace MobilePhoneSMS {
    partial class MobilePhoneSMSForm {
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
            this.components = new System.ComponentModel.Container();
            this.AddSMSTmer = new System.Windows.Forms.Timer(this.components);
            this.FmtComboBox = new System.Windows.Forms.ComboBox();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.SMSFormatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddSMSTmer
            // 
            this.AddSMSTmer.Enabled = true;
            this.AddSMSTmer.Interval = 1000;
            this.AddSMSTmer.Tick += new System.EventHandler(this.AddSMSTimer_Tick_1);
            // 
            // FmtComboBox
            // 
            this.FmtComboBox.FormattingEnabled = true;
            this.FmtComboBox.Location = new System.Drawing.Point(12, 25);
            this.FmtComboBox.Name = "FmtComboBox";
            this.FmtComboBox.Size = new System.Drawing.Size(260, 21);
            this.FmtComboBox.TabIndex = 3;
            this.FmtComboBox.SelectedValueChanged += new System.EventHandler(this.FmtComboBox_SelectedValueChanged);
            // 
            // MessageListBox
            // 
            this.MessageListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.Location = new System.Drawing.Point(0, 75);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(284, 186);
            this.MessageListBox.TabIndex = 4;
            // 
            // SMSFormatLabel
            // 
            this.SMSFormatLabel.AutoSize = true;
            this.SMSFormatLabel.Location = new System.Drawing.Point(12, 9);
            this.SMSFormatLabel.Name = "SMSFormatLabel";
            this.SMSFormatLabel.Size = new System.Drawing.Size(115, 13);
            this.SMSFormatLabel.TabIndex = 5;
            this.SMSFormatLabel.Text = "Select SMS formatting:";
            // 
            // MobilePhoneSMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SMSFormatLabel);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.FmtComboBox);
            this.Name = "MobilePhoneSMSForm";
            this.Text = "Mobile Phone SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer AddSMSTmer;
        private System.Windows.Forms.ComboBox FmtComboBox;
        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Label SMSFormatLabel;
    }
}

