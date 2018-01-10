namespace SimCorp.IMS.MobilePhoneCalls {
    partial class MobilePhoneCallsForm {
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
            this.SortButton = new System.Windows.Forms.Button();
            this.UnsortedCallsListBox = new System.Windows.Forms.ListBox();
            this.UnsortedCallsLabel = new System.Windows.Forms.Label();
            this.SortedCallsLabel = new System.Windows.Forms.Label();
            this.SortedCallsListBox = new System.Windows.Forms.ListBox();
            this.GropCallsLabel = new System.Windows.Forms.Label();
            this.GroupCallsListBox = new System.Windows.Forms.ListBox();
            this.GrouCallsButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(339, 214);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Sort Calls";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // UnsortedCallsListBox
            // 
            this.UnsortedCallsListBox.FormattingEnabled = true;
            this.UnsortedCallsListBox.Location = new System.Drawing.Point(12, 63);
            this.UnsortedCallsListBox.Name = "UnsortedCallsListBox";
            this.UnsortedCallsListBox.Size = new System.Drawing.Size(310, 134);
            this.UnsortedCallsListBox.TabIndex = 0;
            // 
            // UnsortedCallsLabel
            // 
            this.UnsortedCallsLabel.AutoSize = true;
            this.UnsortedCallsLabel.Location = new System.Drawing.Point(12, 33);
            this.UnsortedCallsLabel.Name = "UnsortedCallsLabel";
            this.UnsortedCallsLabel.Size = new System.Drawing.Size(75, 13);
            this.UnsortedCallsLabel.TabIndex = 2;
            this.UnsortedCallsLabel.Text = "Unsorted Calls";
            // 
            // SortedCallsLabel
            // 
            this.SortedCallsLabel.AutoSize = true;
            this.SortedCallsLabel.Location = new System.Drawing.Point(336, 33);
            this.SortedCallsLabel.Name = "SortedCallsLabel";
            this.SortedCallsLabel.Size = new System.Drawing.Size(192, 13);
            this.SortedCallsLabel.TabIndex = 4;
            this.SortedCallsLabel.Text = "Sorted Calls (by Number, by Time desc)";
            // 
            // SortedCallsListBox
            // 
            this.SortedCallsListBox.FormattingEnabled = true;
            this.SortedCallsListBox.Location = new System.Drawing.Point(339, 63);
            this.SortedCallsListBox.Name = "SortedCallsListBox";
            this.SortedCallsListBox.Size = new System.Drawing.Size(316, 134);
            this.SortedCallsListBox.TabIndex = 3;
            // 
            // GropCallsLabel
            // 
            this.GropCallsLabel.AutoSize = true;
            this.GropCallsLabel.Location = new System.Drawing.Point(671, 33);
            this.GropCallsLabel.Name = "GropCallsLabel";
            this.GropCallsLabel.Size = new System.Drawing.Size(73, 13);
            this.GropCallsLabel.TabIndex = 6;
            this.GropCallsLabel.Text = "Grouped Calls";
            // 
            // GroupCallsListBox
            // 
            this.GroupCallsListBox.FormattingEnabled = true;
            this.GroupCallsListBox.Location = new System.Drawing.Point(674, 63);
            this.GroupCallsListBox.Name = "GroupCallsListBox";
            this.GroupCallsListBox.Size = new System.Drawing.Size(316, 134);
            this.GroupCallsListBox.TabIndex = 5;
            // 
            // GrouCallsButton
            // 
            this.GrouCallsButton.Location = new System.Drawing.Point(674, 214);
            this.GrouCallsButton.Name = "GrouCallsButton";
            this.GrouCallsButton.Size = new System.Drawing.Size(75, 23);
            this.GrouCallsButton.TabIndex = 7;
            this.GrouCallsButton.Text = "Group Calls";
            this.GrouCallsButton.UseVisualStyleBackColor = true;
            this.GrouCallsButton.Click += new System.EventHandler(this.GrouCallsButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(12, 214);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(310, 23);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop Generation and Load Demonstrative Example";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MobilePhoneCallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 319);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.GrouCallsButton);
            this.Controls.Add(this.GropCallsLabel);
            this.Controls.Add(this.GroupCallsListBox);
            this.Controls.Add(this.SortedCallsLabel);
            this.Controls.Add(this.SortedCallsListBox);
            this.Controls.Add(this.UnsortedCallsLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.UnsortedCallsListBox);
            this.Name = "MobilePhoneCallsForm";
            this.Text = "Mobile Phone Calls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MobilePhoneCallsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ListBox UnsortedCallsListBox;
        private System.Windows.Forms.Label UnsortedCallsLabel;
        private System.Windows.Forms.Label SortedCallsLabel;
        private System.Windows.Forms.ListBox SortedCallsListBox;
        private System.Windows.Forms.Label GropCallsLabel;
        private System.Windows.Forms.ListBox GroupCallsListBox;
        private System.Windows.Forms.Button GrouCallsButton;
        private System.Windows.Forms.Button StopButton;
    }
}

