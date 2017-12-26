namespace MobileFormWinForm {
    partial class MobilePhoneForm {
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
            this.applyButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.radioButtoniPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonSamsung = new System.Windows.Forms.RadioButton();
            this.radioButtonNoNameHeadset = new System.Windows.Forms.RadioButton();
            this.radioButtonPhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(197, 137);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 166);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(284, 95);
            this.listBox.TabIndex = 1;
            // 
            // radioButtoniPhone
            // 
            this.radioButtoniPhone.AutoSize = true;
            this.radioButtoniPhone.Location = new System.Drawing.Point(21, 41);
            this.radioButtoniPhone.Name = "radioButtoniPhone";
            this.radioButtoniPhone.Size = new System.Drawing.Size(101, 17);
            this.radioButtoniPhone.TabIndex = 2;
            this.radioButtoniPhone.TabStop = true;
            this.radioButtoniPhone.Text = "iPhone Headset";
            this.radioButtoniPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonSamsung
            // 
            this.radioButtonSamsung.AutoSize = true;
            this.radioButtonSamsung.Location = new System.Drawing.Point(21, 64);
            this.radioButtonSamsung.Name = "radioButtonSamsung";
            this.radioButtonSamsung.Size = new System.Drawing.Size(112, 17);
            this.radioButtonSamsung.TabIndex = 3;
            this.radioButtonSamsung.TabStop = true;
            this.radioButtonSamsung.Text = "Samsung Headset";
            this.radioButtonSamsung.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoNameHeadset
            // 
            this.radioButtonNoNameHeadset.AutoSize = true;
            this.radioButtonNoNameHeadset.Location = new System.Drawing.Point(21, 87);
            this.radioButtonNoNameHeadset.Name = "radioButtonNoNameHeadset";
            this.radioButtonNoNameHeadset.Size = new System.Drawing.Size(113, 17);
            this.radioButtonNoNameHeadset.TabIndex = 4;
            this.radioButtonNoNameHeadset.TabStop = true;
            this.radioButtonNoNameHeadset.Text = "No Name Headset";
            this.radioButtonNoNameHeadset.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhoneSpeaker
            // 
            this.radioButtonPhoneSpeaker.AutoSize = true;
            this.radioButtonPhoneSpeaker.Location = new System.Drawing.Point(21, 110);
            this.radioButtonPhoneSpeaker.Name = "radioButtonPhoneSpeaker";
            this.radioButtonPhoneSpeaker.Size = new System.Drawing.Size(99, 17);
            this.radioButtonPhoneSpeaker.TabIndex = 5;
            this.radioButtonPhoneSpeaker.TabStop = true;
            this.radioButtonPhoneSpeaker.Text = "Phone Speaker";
            this.radioButtonPhoneSpeaker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select playback component";
            // 
            // MobilePhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonPhoneSpeaker);
            this.Controls.Add(this.radioButtonNoNameHeadset);
            this.Controls.Add(this.radioButtonSamsung);
            this.Controls.Add(this.radioButtoniPhone);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.applyButton);
            this.Name = "MobilePhoneForm";
            this.Text = "MobilePhone";
            this.Load += new System.EventHandler(this.MobilePhoneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.RadioButton radioButtoniPhone;
        private System.Windows.Forms.RadioButton radioButtonSamsung;
        private System.Windows.Forms.RadioButton radioButtonNoNameHeadset;
        private System.Windows.Forms.RadioButton radioButtonPhoneSpeaker;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox;
    }
}

