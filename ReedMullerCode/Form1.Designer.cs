namespace ReedMullerCode
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVector = new System.Windows.Forms.TabPage();
            this.vectorLengthErrorLabel = new System.Windows.Forms.Label();
            this.vectorStartAgainButton = new System.Windows.Forms.Button();
            this.decodedVectorText = new System.Windows.Forms.TextBox();
            this.decodedVectorLabel = new System.Windows.Forms.Label();
            this.vectorErrorCountLabel = new System.Windows.Forms.Label();
            this.vectorDecodeButton = new System.Windows.Forms.Button();
            this.vectorFromChannelText = new System.Windows.Forms.TextBox();
            this.vectorFromChannelLabel = new System.Windows.Forms.Label();
            this.vectorEncodeButton = new System.Windows.Forms.Button();
            this.encodedVectorText = new System.Windows.Forms.TextBox();
            this.encodedVectorLabel = new System.Windows.Forms.Label();
            this.vectorErrorRate = new System.Windows.Forms.TextBox();
            this.vectorErrorRateLabel = new System.Windows.Forms.Label();
            this.vectorSendButton = new System.Windows.Forms.Button();
            this.vectorTextBox = new System.Windows.Forms.TextBox();
            this.vectorLabel = new System.Windows.Forms.Label();
            this.mLengthVectorLabel = new System.Windows.Forms.Label();
            this.mVectorSubmit = new System.Windows.Forms.Button();
            this.mVectorTextBox = new System.Windows.Forms.TextBox();
            this.mLabelVectorTav = new System.Windows.Forms.Label();
            this.tabText = new System.Windows.Forms.TabPage();
            this.mTextSubmit = new System.Windows.Forms.Button();
            this.mText = new System.Windows.Forms.TextBox();
            this.mLabelTextTab = new System.Windows.Forms.Label();
            this.tabPicture = new System.Windows.Forms.TabPage();
            this.mPictureSubmit = new System.Windows.Forms.Button();
            this.mPictureText = new System.Windows.Forms.TextBox();
            this.mLabelPictureTab = new System.Windows.Forms.Label();
            this.vectorErrorValueLabel = new System.Windows.Forms.Label();
            this.vectorFromChannelError = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabVector.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVector);
            this.tabControl.Controls.Add(this.tabText);
            this.tabControl.Controls.Add(this.tabPicture);
            this.tabControl.Location = new System.Drawing.Point(3, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(795, 438);
            this.tabControl.TabIndex = 0;
            // 
            // tabVector
            // 
            this.tabVector.Controls.Add(this.vectorFromChannelError);
            this.tabVector.Controls.Add(this.vectorErrorValueLabel);
            this.tabVector.Controls.Add(this.vectorLengthErrorLabel);
            this.tabVector.Controls.Add(this.vectorStartAgainButton);
            this.tabVector.Controls.Add(this.decodedVectorText);
            this.tabVector.Controls.Add(this.decodedVectorLabel);
            this.tabVector.Controls.Add(this.vectorErrorCountLabel);
            this.tabVector.Controls.Add(this.vectorDecodeButton);
            this.tabVector.Controls.Add(this.vectorFromChannelText);
            this.tabVector.Controls.Add(this.vectorFromChannelLabel);
            this.tabVector.Controls.Add(this.vectorEncodeButton);
            this.tabVector.Controls.Add(this.encodedVectorText);
            this.tabVector.Controls.Add(this.encodedVectorLabel);
            this.tabVector.Controls.Add(this.vectorErrorRate);
            this.tabVector.Controls.Add(this.vectorErrorRateLabel);
            this.tabVector.Controls.Add(this.vectorSendButton);
            this.tabVector.Controls.Add(this.vectorTextBox);
            this.tabVector.Controls.Add(this.vectorLabel);
            this.tabVector.Controls.Add(this.mLengthVectorLabel);
            this.tabVector.Controls.Add(this.mVectorSubmit);
            this.tabVector.Controls.Add(this.mVectorTextBox);
            this.tabVector.Controls.Add(this.mLabelVectorTav);
            this.tabVector.Location = new System.Drawing.Point(4, 22);
            this.tabVector.Name = "tabVector";
            this.tabVector.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabVector.Size = new System.Drawing.Size(787, 412);
            this.tabVector.TabIndex = 0;
            this.tabVector.Text = "Vector";
            this.tabVector.UseVisualStyleBackColor = true;
            // 
            // vectorLengthErrorLabel
            // 
            this.vectorLengthErrorLabel.AutoSize = true;
            this.vectorLengthErrorLabel.Location = new System.Drawing.Point(360, 70);
            this.vectorLengthErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vectorLengthErrorLabel.Name = "vectorLengthErrorLabel";
            this.vectorLengthErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.vectorLengthErrorLabel.TabIndex = 22;
            // 
            // vectorStartAgainButton
            // 
            this.vectorStartAgainButton.Location = new System.Drawing.Point(356, 370);
            this.vectorStartAgainButton.Name = "vectorStartAgainButton";
            this.vectorStartAgainButton.Size = new System.Drawing.Size(75, 23);
            this.vectorStartAgainButton.TabIndex = 21;
            this.vectorStartAgainButton.Text = "Start again";
            this.vectorStartAgainButton.UseVisualStyleBackColor = true;
            this.vectorStartAgainButton.Visible = false;
            this.vectorStartAgainButton.Click += new System.EventHandler(this.vectorStartAgainButton_Click);
            // 
            // decodedVectorText
            // 
            this.decodedVectorText.Location = new System.Drawing.Point(250, 320);
            this.decodedVectorText.Name = "decodedVectorText";
            this.decodedVectorText.Size = new System.Drawing.Size(400, 20);
            this.decodedVectorText.TabIndex = 20;
            this.decodedVectorText.Visible = false;
            // 
            // decodedVectorLabel
            // 
            this.decodedVectorLabel.AutoSize = true;
            this.decodedVectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodedVectorLabel.Location = new System.Drawing.Point(11, 320);
            this.decodedVectorLabel.Name = "decodedVectorLabel";
            this.decodedVectorLabel.Size = new System.Drawing.Size(158, 24);
            this.decodedVectorLabel.TabIndex = 19;
            this.decodedVectorLabel.Text = "Decoded vector";
            this.decodedVectorLabel.Visible = false;
            // 
            // vectorErrorCountLabel
            // 
            this.vectorErrorCountLabel.AutoSize = true;
            this.vectorErrorCountLabel.Location = new System.Drawing.Point(300, 220);
            this.vectorErrorCountLabel.Name = "vectorErrorCountLabel";
            this.vectorErrorCountLabel.Size = new System.Drawing.Size(0, 13);
            this.vectorErrorCountLabel.TabIndex = 18;
            // 
            // vectorDecodeButton
            // 
            this.vectorDecodeButton.Location = new System.Drawing.Point(680, 250);
            this.vectorDecodeButton.Name = "vectorDecodeButton";
            this.vectorDecodeButton.Size = new System.Drawing.Size(75, 23);
            this.vectorDecodeButton.TabIndex = 17;
            this.vectorDecodeButton.Text = "Decode";
            this.vectorDecodeButton.UseVisualStyleBackColor = true;
            this.vectorDecodeButton.Visible = false;
            this.vectorDecodeButton.Click += new System.EventHandler(this.vectorDecodeButton_Click);
            // 
            // vectorFromChannelText
            // 
            this.vectorFromChannelText.Location = new System.Drawing.Point(250, 252);
            this.vectorFromChannelText.Name = "vectorFromChannelText";
            this.vectorFromChannelText.Size = new System.Drawing.Size(400, 20);
            this.vectorFromChannelText.TabIndex = 16;
            this.vectorFromChannelText.Visible = false;
            // 
            // vectorFromChannelLabel
            // 
            this.vectorFromChannelLabel.AutoSize = true;
            this.vectorFromChannelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorFromChannelLabel.Location = new System.Drawing.Point(11, 250);
            this.vectorFromChannelLabel.Name = "vectorFromChannelLabel";
            this.vectorFromChannelLabel.Size = new System.Drawing.Size(199, 24);
            this.vectorFromChannelLabel.TabIndex = 15;
            this.vectorFromChannelLabel.Text = "Vector from channel";
            this.vectorFromChannelLabel.Visible = false;
            // 
            // vectorEncodeButton
            // 
            this.vectorEncodeButton.Location = new System.Drawing.Point(680, 90);
            this.vectorEncodeButton.Name = "vectorEncodeButton";
            this.vectorEncodeButton.Size = new System.Drawing.Size(75, 23);
            this.vectorEncodeButton.TabIndex = 14;
            this.vectorEncodeButton.Text = "Encode";
            this.vectorEncodeButton.UseVisualStyleBackColor = true;
            this.vectorEncodeButton.Visible = false;
            this.vectorEncodeButton.Click += new System.EventHandler(this.vectorEncodeButton_Click);
            // 
            // encodedVectorText
            // 
            this.encodedVectorText.Location = new System.Drawing.Point(250, 132);
            this.encodedVectorText.Name = "encodedVectorText";
            this.encodedVectorText.Size = new System.Drawing.Size(400, 20);
            this.encodedVectorText.TabIndex = 13;
            this.encodedVectorText.Visible = false;
            // 
            // encodedVectorLabel
            // 
            this.encodedVectorLabel.AutoSize = true;
            this.encodedVectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodedVectorLabel.Location = new System.Drawing.Point(11, 130);
            this.encodedVectorLabel.Name = "encodedVectorLabel";
            this.encodedVectorLabel.Size = new System.Drawing.Size(158, 24);
            this.encodedVectorLabel.TabIndex = 12;
            this.encodedVectorLabel.Text = "Encoded vector";
            this.encodedVectorLabel.Visible = false;
            // 
            // vectorErrorRate
            // 
            this.vectorErrorRate.Location = new System.Drawing.Point(250, 172);
            this.vectorErrorRate.Name = "vectorErrorRate";
            this.vectorErrorRate.Size = new System.Drawing.Size(40, 20);
            this.vectorErrorRate.TabIndex = 11;
            this.vectorErrorRate.Visible = false;
            // 
            // vectorErrorRateLabel
            // 
            this.vectorErrorRateLabel.AutoSize = true;
            this.vectorErrorRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorErrorRateLabel.Location = new System.Drawing.Point(11, 170);
            this.vectorErrorRateLabel.Name = "vectorErrorRateLabel";
            this.vectorErrorRateLabel.Size = new System.Drawing.Size(98, 24);
            this.vectorErrorRateLabel.TabIndex = 10;
            this.vectorErrorRateLabel.Text = "Error rate";
            this.vectorErrorRateLabel.Visible = false;
            // 
            // vectorSendButton
            // 
            this.vectorSendButton.Location = new System.Drawing.Point(680, 170);
            this.vectorSendButton.Name = "vectorSendButton";
            this.vectorSendButton.Size = new System.Drawing.Size(75, 23);
            this.vectorSendButton.TabIndex = 9;
            this.vectorSendButton.Text = "Send";
            this.vectorSendButton.UseVisualStyleBackColor = true;
            this.vectorSendButton.Visible = false;
            this.vectorSendButton.Click += new System.EventHandler(this.vectorSendButton_Click);
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Location = new System.Drawing.Point(250, 92);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(400, 20);
            this.vectorTextBox.TabIndex = 8;
            this.vectorTextBox.Visible = false;
            // 
            // vectorLabel
            // 
            this.vectorLabel.AutoSize = true;
            this.vectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorLabel.Location = new System.Drawing.Point(11, 90);
            this.vectorLabel.Name = "vectorLabel";
            this.vectorLabel.Size = new System.Drawing.Size(71, 24);
            this.vectorLabel.TabIndex = 7;
            this.vectorLabel.Text = "Vector";
            this.vectorLabel.Visible = false;
            // 
            // mLengthVectorLabel
            // 
            this.mLengthVectorLabel.AutoSize = true;
            this.mLengthVectorLabel.Location = new System.Drawing.Point(11, 50);
            this.mLengthVectorLabel.Name = "mLengthVectorLabel";
            this.mLengthVectorLabel.Size = new System.Drawing.Size(0, 13);
            this.mLengthVectorLabel.TabIndex = 6;
            // 
            // mVectorSubmit
            // 
            this.mVectorSubmit.Location = new System.Drawing.Point(110, 9);
            this.mVectorSubmit.Name = "mVectorSubmit";
            this.mVectorSubmit.Size = new System.Drawing.Size(75, 23);
            this.mVectorSubmit.TabIndex = 5;
            this.mVectorSubmit.Text = "Submit";
            this.mVectorSubmit.UseVisualStyleBackColor = true;
            this.mVectorSubmit.Click += new System.EventHandler(this.mVectorSubmit_Click);
            // 
            // mVectorTextBox
            // 
            this.mVectorTextBox.Location = new System.Drawing.Point(60, 11);
            this.mVectorTextBox.Name = "mVectorTextBox";
            this.mVectorTextBox.Size = new System.Drawing.Size(30, 20);
            this.mVectorTextBox.TabIndex = 1;
            // 
            // mLabelVectorTav
            // 
            this.mLabelVectorTav.AutoSize = true;
            this.mLabelVectorTav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelVectorTav.Location = new System.Drawing.Point(11, 8);
            this.mLabelVectorTav.Name = "mLabelVectorTav";
            this.mLabelVectorTav.Size = new System.Drawing.Size(27, 24);
            this.mLabelVectorTav.TabIndex = 0;
            this.mLabelVectorTav.Text = "m";
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.mTextSubmit);
            this.tabText.Controls.Add(this.mText);
            this.tabText.Controls.Add(this.mLabelTextTab);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabText.Size = new System.Drawing.Size(787, 412);
            this.tabText.TabIndex = 1;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // mTextSubmit
            // 
            this.mTextSubmit.Location = new System.Drawing.Point(110, 9);
            this.mTextSubmit.Name = "mTextSubmit";
            this.mTextSubmit.Size = new System.Drawing.Size(75, 23);
            this.mTextSubmit.TabIndex = 6;
            this.mTextSubmit.Text = "Submit";
            this.mTextSubmit.UseVisualStyleBackColor = true;
            // 
            // mText
            // 
            this.mText.Location = new System.Drawing.Point(60, 11);
            this.mText.Name = "mText";
            this.mText.Size = new System.Drawing.Size(30, 20);
            this.mText.TabIndex = 2;
            // 
            // mLabelTextTab
            // 
            this.mLabelTextTab.AutoSize = true;
            this.mLabelTextTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelTextTab.Location = new System.Drawing.Point(11, 8);
            this.mLabelTextTab.Name = "mLabelTextTab";
            this.mLabelTextTab.Size = new System.Drawing.Size(27, 24);
            this.mLabelTextTab.TabIndex = 1;
            this.mLabelTextTab.Text = "m";
            // 
            // tabPicture
            // 
            this.tabPicture.Controls.Add(this.mPictureSubmit);
            this.tabPicture.Controls.Add(this.mPictureText);
            this.tabPicture.Controls.Add(this.mLabelPictureTab);
            this.tabPicture.Location = new System.Drawing.Point(4, 22);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Size = new System.Drawing.Size(787, 412);
            this.tabPicture.TabIndex = 2;
            this.tabPicture.Text = "Picture";
            this.tabPicture.UseVisualStyleBackColor = true;
            // 
            // mPictureSubmit
            // 
            this.mPictureSubmit.Location = new System.Drawing.Point(110, 9);
            this.mPictureSubmit.Name = "mPictureSubmit";
            this.mPictureSubmit.Size = new System.Drawing.Size(75, 23);
            this.mPictureSubmit.TabIndex = 4;
            this.mPictureSubmit.Text = "Submit";
            this.mPictureSubmit.UseVisualStyleBackColor = true;
            // 
            // mPictureText
            // 
            this.mPictureText.Location = new System.Drawing.Point(60, 11);
            this.mPictureText.Name = "mPictureText";
            this.mPictureText.Size = new System.Drawing.Size(30, 20);
            this.mPictureText.TabIndex = 3;
            // 
            // mLabelPictureTab
            // 
            this.mLabelPictureTab.AutoSize = true;
            this.mLabelPictureTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelPictureTab.Location = new System.Drawing.Point(11, 8);
            this.mLabelPictureTab.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.mLabelPictureTab.Name = "mLabelPictureTab";
            this.mLabelPictureTab.Size = new System.Drawing.Size(27, 24);
            this.mLabelPictureTab.TabIndex = 1;
            this.mLabelPictureTab.Text = "m";
            // 
            // vectorErrorValueLabel
            // 
            this.vectorErrorValueLabel.AutoSize = true;
            this.vectorErrorValueLabel.Location = new System.Drawing.Point(320, 175);
            this.vectorErrorValueLabel.Name = "vectorErrorValueLabel";
            this.vectorErrorValueLabel.Size = new System.Drawing.Size(0, 13);
            this.vectorErrorValueLabel.TabIndex = 23;
            // 
            // vectorFromChannelError
            // 
            this.vectorFromChannelError.AutoSize = true;
            this.vectorFromChannelError.Location = new System.Drawing.Point(300, 290);
            this.vectorFromChannelError.Name = "vectorFromChannelError";
            this.vectorFromChannelError.Size = new System.Drawing.Size(0, 13);
            this.vectorFromChannelError.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabVector.ResumeLayout(false);
            this.tabVector.PerformLayout();
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabPicture.ResumeLayout(false);
            this.tabPicture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVector;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabPicture;
        private System.Windows.Forms.Label mLabelVectorTav;
        private System.Windows.Forms.Label mLabelTextTab;
        private System.Windows.Forms.Label mLabelPictureTab;
        private System.Windows.Forms.TextBox mVectorTextBox;
        private System.Windows.Forms.TextBox mText;
        private System.Windows.Forms.TextBox mPictureText;
        private System.Windows.Forms.Button mVectorSubmit;
        private System.Windows.Forms.Button mTextSubmit;
        private System.Windows.Forms.Button mPictureSubmit;
        private System.Windows.Forms.Label mLengthVectorLabel;
        private System.Windows.Forms.TextBox vectorTextBox;
        private System.Windows.Forms.Label vectorLabel;
        private System.Windows.Forms.Button vectorSendButton;
        private System.Windows.Forms.TextBox vectorErrorRate;
        private System.Windows.Forms.Label vectorErrorRateLabel;
        private System.Windows.Forms.Button vectorEncodeButton;
        private System.Windows.Forms.TextBox encodedVectorText;
        private System.Windows.Forms.Label encodedVectorLabel;
        private System.Windows.Forms.Button vectorDecodeButton;
        private System.Windows.Forms.TextBox vectorFromChannelText;
        private System.Windows.Forms.Label vectorFromChannelLabel;
        private System.Windows.Forms.Label vectorErrorCountLabel;
        private System.Windows.Forms.TextBox decodedVectorText;
        private System.Windows.Forms.Label decodedVectorLabel;
        private System.Windows.Forms.Button vectorStartAgainButton;
        private System.Windows.Forms.Label vectorLengthErrorLabel;
        private System.Windows.Forms.Label vectorErrorValueLabel;
        private System.Windows.Forms.Label vectorFromChannelError;
    }
}

