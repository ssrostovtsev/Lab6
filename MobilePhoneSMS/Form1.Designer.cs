namespace MobilePhoneSMS {
    partial class Form1 {
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FmtComboBox = new System.Windows.Forms.ComboBox();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select SMS formatting:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.FmtComboBox);
            this.Name = "Form1";
            this.Text = "Mobile Phone SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox FmtComboBox;
        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Label label1;
    }
}

