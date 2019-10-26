namespace ReedMullerCode
{
    partial class MainWindow
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
            this.vectorFromChannelError = new System.Windows.Forms.Label();
            this.vectorErrorValueLabel = new System.Windows.Forms.Label();
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
            this.textStartAgainButton = new System.Windows.Forms.Button();
            this.textWithoutCodingOutput = new System.Windows.Forms.TextBox();
            this.textWithoutCodingLabel = new System.Windows.Forms.Label();
            this.textWithCodingOutput = new System.Windows.Forms.TextBox();
            this.textWithCodingLabel = new System.Windows.Forms.Label();
            this.textErrorLabel = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.textErrorRateInput = new System.Windows.Forms.TextBox();
            this.textErrorRateLabel = new System.Windows.Forms.Label();
            this.textSendButton = new System.Windows.Forms.Button();
            this.mLengthTextLabel = new System.Windows.Forms.Label();
            this.mTextSubmit = new System.Windows.Forms.Button();
            this.mText = new System.Windows.Forms.TextBox();
            this.mLabelTextTab = new System.Windows.Forms.Label();
            this.tabPicture = new System.Windows.Forms.TabPage();
            this.pictureErrorLabel = new System.Windows.Forms.Label();
            this.pictureStartAgainButton = new System.Windows.Forms.Button();
            this.pictureErrorRateText = new System.Windows.Forms.TextBox();
            this.pictureErrorRateLabel = new System.Windows.Forms.Label();
            this.pictureSend = new System.Windows.Forms.Button();
            this.pictureWithoutCodingLabel = new System.Windows.Forms.Label();
            this.pictureWithCodingLabel = new System.Windows.Forms.Label();
            this.inputPictureLabel = new System.Windows.Forms.Label();
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxWithCoding = new System.Windows.Forms.PictureBox();
            this.pictureBoxWithoutCoding = new System.Windows.Forms.PictureBox();
            this.mPictureLengthLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.mPictureSubmit = new System.Windows.Forms.Button();
            this.mPictureText = new System.Windows.Forms.TextBox();
            this.mLabelPictureTab = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabVector.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithCoding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithoutCoding)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVector);
            this.tabControl.Controls.Add(this.tabText);
            this.tabControl.Controls.Add(this.tabPicture);
            this.tabControl.Location = new System.Drawing.Point(4, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1192, 877);
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
            this.tabVector.Location = new System.Drawing.Point(4, 29);
            this.tabVector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabVector.Name = "tabVector";
            this.tabVector.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabVector.Size = new System.Drawing.Size(1184, 844);
            this.tabVector.TabIndex = 0;
            this.tabVector.Text = "Vector";
            this.tabVector.UseVisualStyleBackColor = true;
            // 
            // vectorFromChannelError
            // 
            this.vectorFromChannelError.AutoSize = true;
            this.vectorFromChannelError.Location = new System.Drawing.Point(450, 446);
            this.vectorFromChannelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorFromChannelError.Name = "vectorFromChannelError";
            this.vectorFromChannelError.Size = new System.Drawing.Size(0, 20);
            this.vectorFromChannelError.TabIndex = 24;
            // 
            // vectorErrorValueLabel
            // 
            this.vectorErrorValueLabel.AutoSize = true;
            this.vectorErrorValueLabel.Location = new System.Drawing.Point(480, 269);
            this.vectorErrorValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorErrorValueLabel.Name = "vectorErrorValueLabel";
            this.vectorErrorValueLabel.Size = new System.Drawing.Size(0, 20);
            this.vectorErrorValueLabel.TabIndex = 23;
            // 
            // vectorLengthErrorLabel
            // 
            this.vectorLengthErrorLabel.AutoSize = true;
            this.vectorLengthErrorLabel.Location = new System.Drawing.Point(540, 108);
            this.vectorLengthErrorLabel.Name = "vectorLengthErrorLabel";
            this.vectorLengthErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.vectorLengthErrorLabel.TabIndex = 22;
            // 
            // vectorStartAgainButton
            // 
            this.vectorStartAgainButton.Location = new System.Drawing.Point(534, 569);
            this.vectorStartAgainButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorStartAgainButton.Name = "vectorStartAgainButton";
            this.vectorStartAgainButton.Size = new System.Drawing.Size(112, 35);
            this.vectorStartAgainButton.TabIndex = 21;
            this.vectorStartAgainButton.Text = "Start again";
            this.vectorStartAgainButton.UseVisualStyleBackColor = true;
            this.vectorStartAgainButton.Visible = false;
            this.vectorStartAgainButton.Click += new System.EventHandler(this.vectorStartAgainButton_Click);
            // 
            // decodedVectorText
            // 
            this.decodedVectorText.Location = new System.Drawing.Point(375, 492);
            this.decodedVectorText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decodedVectorText.Name = "decodedVectorText";
            this.decodedVectorText.Size = new System.Drawing.Size(598, 26);
            this.decodedVectorText.TabIndex = 20;
            this.decodedVectorText.Visible = false;
            // 
            // decodedVectorLabel
            // 
            this.decodedVectorLabel.AutoSize = true;
            this.decodedVectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodedVectorLabel.Location = new System.Drawing.Point(16, 492);
            this.decodedVectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodedVectorLabel.Name = "decodedVectorLabel";
            this.decodedVectorLabel.Size = new System.Drawing.Size(233, 33);
            this.decodedVectorLabel.TabIndex = 19;
            this.decodedVectorLabel.Text = "Decoded vector";
            this.decodedVectorLabel.Visible = false;
            // 
            // vectorErrorCountLabel
            // 
            this.vectorErrorCountLabel.AutoSize = true;
            this.vectorErrorCountLabel.Location = new System.Drawing.Point(450, 338);
            this.vectorErrorCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorErrorCountLabel.Name = "vectorErrorCountLabel";
            this.vectorErrorCountLabel.Size = new System.Drawing.Size(0, 20);
            this.vectorErrorCountLabel.TabIndex = 18;
            // 
            // vectorDecodeButton
            // 
            this.vectorDecodeButton.Location = new System.Drawing.Point(1020, 385);
            this.vectorDecodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorDecodeButton.Name = "vectorDecodeButton";
            this.vectorDecodeButton.Size = new System.Drawing.Size(112, 35);
            this.vectorDecodeButton.TabIndex = 17;
            this.vectorDecodeButton.Text = "Decode";
            this.vectorDecodeButton.UseVisualStyleBackColor = true;
            this.vectorDecodeButton.Visible = false;
            this.vectorDecodeButton.Click += new System.EventHandler(this.vectorDecodeButton_Click);
            // 
            // vectorFromChannelText
            // 
            this.vectorFromChannelText.Location = new System.Drawing.Point(375, 388);
            this.vectorFromChannelText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorFromChannelText.Name = "vectorFromChannelText";
            this.vectorFromChannelText.Size = new System.Drawing.Size(598, 26);
            this.vectorFromChannelText.TabIndex = 16;
            this.vectorFromChannelText.Visible = false;
            // 
            // vectorFromChannelLabel
            // 
            this.vectorFromChannelLabel.AutoSize = true;
            this.vectorFromChannelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorFromChannelLabel.Location = new System.Drawing.Point(16, 385);
            this.vectorFromChannelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorFromChannelLabel.Name = "vectorFromChannelLabel";
            this.vectorFromChannelLabel.Size = new System.Drawing.Size(295, 33);
            this.vectorFromChannelLabel.TabIndex = 15;
            this.vectorFromChannelLabel.Text = "Vector from channel";
            this.vectorFromChannelLabel.Visible = false;
            // 
            // vectorEncodeButton
            // 
            this.vectorEncodeButton.Location = new System.Drawing.Point(1020, 138);
            this.vectorEncodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorEncodeButton.Name = "vectorEncodeButton";
            this.vectorEncodeButton.Size = new System.Drawing.Size(112, 35);
            this.vectorEncodeButton.TabIndex = 14;
            this.vectorEncodeButton.Text = "Encode";
            this.vectorEncodeButton.UseVisualStyleBackColor = true;
            this.vectorEncodeButton.Visible = false;
            this.vectorEncodeButton.Click += new System.EventHandler(this.vectorEncodeButton_Click);
            // 
            // encodedVectorText
            // 
            this.encodedVectorText.Location = new System.Drawing.Point(375, 203);
            this.encodedVectorText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encodedVectorText.Name = "encodedVectorText";
            this.encodedVectorText.Size = new System.Drawing.Size(598, 26);
            this.encodedVectorText.TabIndex = 13;
            this.encodedVectorText.Visible = false;
            // 
            // encodedVectorLabel
            // 
            this.encodedVectorLabel.AutoSize = true;
            this.encodedVectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodedVectorLabel.Location = new System.Drawing.Point(16, 200);
            this.encodedVectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encodedVectorLabel.Name = "encodedVectorLabel";
            this.encodedVectorLabel.Size = new System.Drawing.Size(231, 33);
            this.encodedVectorLabel.TabIndex = 12;
            this.encodedVectorLabel.Text = "Encoded vector";
            this.encodedVectorLabel.Visible = false;
            // 
            // vectorErrorRate
            // 
            this.vectorErrorRate.Location = new System.Drawing.Point(375, 265);
            this.vectorErrorRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorErrorRate.Name = "vectorErrorRate";
            this.vectorErrorRate.Size = new System.Drawing.Size(58, 26);
            this.vectorErrorRate.TabIndex = 11;
            this.vectorErrorRate.Visible = false;
            // 
            // vectorErrorRateLabel
            // 
            this.vectorErrorRateLabel.AutoSize = true;
            this.vectorErrorRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorErrorRateLabel.Location = new System.Drawing.Point(16, 262);
            this.vectorErrorRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorErrorRateLabel.Name = "vectorErrorRateLabel";
            this.vectorErrorRateLabel.Size = new System.Drawing.Size(148, 33);
            this.vectorErrorRateLabel.TabIndex = 10;
            this.vectorErrorRateLabel.Text = "Error rate";
            this.vectorErrorRateLabel.Visible = false;
            // 
            // vectorSendButton
            // 
            this.vectorSendButton.Location = new System.Drawing.Point(1020, 262);
            this.vectorSendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorSendButton.Name = "vectorSendButton";
            this.vectorSendButton.Size = new System.Drawing.Size(112, 35);
            this.vectorSendButton.TabIndex = 9;
            this.vectorSendButton.Text = "Send";
            this.vectorSendButton.UseVisualStyleBackColor = true;
            this.vectorSendButton.Visible = false;
            this.vectorSendButton.Click += new System.EventHandler(this.vectorSendButton_Click);
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Location = new System.Drawing.Point(375, 142);
            this.vectorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(598, 26);
            this.vectorTextBox.TabIndex = 8;
            this.vectorTextBox.Visible = false;
            // 
            // vectorLabel
            // 
            this.vectorLabel.AutoSize = true;
            this.vectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorLabel.Location = new System.Drawing.Point(16, 138);
            this.vectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorLabel.Name = "vectorLabel";
            this.vectorLabel.Size = new System.Drawing.Size(105, 33);
            this.vectorLabel.TabIndex = 7;
            this.vectorLabel.Text = "Vector";
            this.vectorLabel.Visible = false;
            // 
            // mLengthVectorLabel
            // 
            this.mLengthVectorLabel.AutoSize = true;
            this.mLengthVectorLabel.Location = new System.Drawing.Point(16, 77);
            this.mLengthVectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLengthVectorLabel.Name = "mLengthVectorLabel";
            this.mLengthVectorLabel.Size = new System.Drawing.Size(0, 20);
            this.mLengthVectorLabel.TabIndex = 6;
            // 
            // mVectorSubmit
            // 
            this.mVectorSubmit.Location = new System.Drawing.Point(165, 14);
            this.mVectorSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mVectorSubmit.Name = "mVectorSubmit";
            this.mVectorSubmit.Size = new System.Drawing.Size(112, 35);
            this.mVectorSubmit.TabIndex = 5;
            this.mVectorSubmit.Text = "Submit";
            this.mVectorSubmit.UseVisualStyleBackColor = true;
            this.mVectorSubmit.Click += new System.EventHandler(this.mVectorSubmit_Click);
            // 
            // mVectorTextBox
            // 
            this.mVectorTextBox.Location = new System.Drawing.Point(90, 17);
            this.mVectorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mVectorTextBox.Name = "mVectorTextBox";
            this.mVectorTextBox.Size = new System.Drawing.Size(43, 26);
            this.mVectorTextBox.TabIndex = 1;
            // 
            // mLabelVectorTav
            // 
            this.mLabelVectorTav.AutoSize = true;
            this.mLabelVectorTav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelVectorTav.Location = new System.Drawing.Point(16, 12);
            this.mLabelVectorTav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelVectorTav.Name = "mLabelVectorTav";
            this.mLabelVectorTav.Size = new System.Drawing.Size(41, 33);
            this.mLabelVectorTav.TabIndex = 0;
            this.mLabelVectorTav.Text = "m";
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.textStartAgainButton);
            this.tabText.Controls.Add(this.textWithoutCodingOutput);
            this.tabText.Controls.Add(this.textWithoutCodingLabel);
            this.tabText.Controls.Add(this.textWithCodingOutput);
            this.tabText.Controls.Add(this.textWithCodingLabel);
            this.tabText.Controls.Add(this.textErrorLabel);
            this.tabText.Controls.Add(this.textInput);
            this.tabText.Controls.Add(this.textLabel);
            this.tabText.Controls.Add(this.textErrorRateInput);
            this.tabText.Controls.Add(this.textErrorRateLabel);
            this.tabText.Controls.Add(this.textSendButton);
            this.tabText.Controls.Add(this.mLengthTextLabel);
            this.tabText.Controls.Add(this.mTextSubmit);
            this.tabText.Controls.Add(this.mText);
            this.tabText.Controls.Add(this.mLabelTextTab);
            this.tabText.Location = new System.Drawing.Point(4, 29);
            this.tabText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabText.Size = new System.Drawing.Size(1184, 844);
            this.tabText.TabIndex = 1;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // textStartAgainButton
            // 
            this.textStartAgainButton.Location = new System.Drawing.Point(534, 462);
            this.textStartAgainButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textStartAgainButton.Name = "textStartAgainButton";
            this.textStartAgainButton.Size = new System.Drawing.Size(112, 35);
            this.textStartAgainButton.TabIndex = 22;
            this.textStartAgainButton.Text = "Start again";
            this.textStartAgainButton.UseVisualStyleBackColor = true;
            this.textStartAgainButton.Visible = false;
            this.textStartAgainButton.Click += new System.EventHandler(this.textStartAgainButton_Click);
            // 
            // textWithoutCodingOutput
            // 
            this.textWithoutCodingOutput.Location = new System.Drawing.Point(315, 369);
            this.textWithoutCodingOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textWithoutCodingOutput.Name = "textWithoutCodingOutput";
            this.textWithoutCodingOutput.Size = new System.Drawing.Size(823, 26);
            this.textWithoutCodingOutput.TabIndex = 21;
            this.textWithoutCodingOutput.Visible = false;
            // 
            // textWithoutCodingLabel
            // 
            this.textWithoutCodingLabel.AutoSize = true;
            this.textWithoutCodingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWithoutCodingLabel.Location = new System.Drawing.Point(16, 369);
            this.textWithoutCodingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textWithoutCodingLabel.Name = "textWithoutCodingLabel";
            this.textWithoutCodingLabel.Size = new System.Drawing.Size(221, 33);
            this.textWithoutCodingLabel.TabIndex = 20;
            this.textWithoutCodingLabel.Text = "Without coding";
            this.textWithoutCodingLabel.Visible = false;
            // 
            // textWithCodingOutput
            // 
            this.textWithCodingOutput.Location = new System.Drawing.Point(315, 298);
            this.textWithCodingOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textWithCodingOutput.Name = "textWithCodingOutput";
            this.textWithCodingOutput.Size = new System.Drawing.Size(823, 26);
            this.textWithCodingOutput.TabIndex = 19;
            this.textWithCodingOutput.Visible = false;
            // 
            // textWithCodingLabel
            // 
            this.textWithCodingLabel.AutoSize = true;
            this.textWithCodingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWithCodingLabel.Location = new System.Drawing.Point(16, 298);
            this.textWithCodingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textWithCodingLabel.Name = "textWithCodingLabel";
            this.textWithCodingLabel.Size = new System.Drawing.Size(178, 33);
            this.textWithCodingLabel.TabIndex = 18;
            this.textWithCodingLabel.Text = "With coding";
            this.textWithCodingLabel.Visible = false;
            // 
            // textErrorLabel
            // 
            this.textErrorLabel.AutoSize = true;
            this.textErrorLabel.Location = new System.Drawing.Point(570, 192);
            this.textErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textErrorLabel.Name = "textErrorLabel";
            this.textErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.textErrorLabel.TabIndex = 17;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(315, 123);
            this.textInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(823, 26);
            this.textInput.TabIndex = 16;
            this.textInput.Visible = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(16, 123);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(76, 33);
            this.textLabel.TabIndex = 15;
            this.textLabel.Text = "Text";
            this.textLabel.Visible = false;
            // 
            // textErrorRateInput
            // 
            this.textErrorRateInput.Location = new System.Drawing.Point(315, 188);
            this.textErrorRateInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textErrorRateInput.Name = "textErrorRateInput";
            this.textErrorRateInput.Size = new System.Drawing.Size(58, 26);
            this.textErrorRateInput.TabIndex = 14;
            this.textErrorRateInput.Visible = false;
            // 
            // textErrorRateLabel
            // 
            this.textErrorRateLabel.AutoSize = true;
            this.textErrorRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textErrorRateLabel.Location = new System.Drawing.Point(16, 185);
            this.textErrorRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textErrorRateLabel.Name = "textErrorRateLabel";
            this.textErrorRateLabel.Size = new System.Drawing.Size(148, 33);
            this.textErrorRateLabel.TabIndex = 13;
            this.textErrorRateLabel.Text = "Error rate";
            this.textErrorRateLabel.Visible = false;
            // 
            // textSendButton
            // 
            this.textSendButton.Location = new System.Drawing.Point(420, 185);
            this.textSendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSendButton.Name = "textSendButton";
            this.textSendButton.Size = new System.Drawing.Size(112, 35);
            this.textSendButton.TabIndex = 12;
            this.textSendButton.Text = "Send";
            this.textSendButton.UseVisualStyleBackColor = true;
            this.textSendButton.Visible = false;
            this.textSendButton.Click += new System.EventHandler(this.textSendButton_Click);
            // 
            // mLengthTextLabel
            // 
            this.mLengthTextLabel.AutoSize = true;
            this.mLengthTextLabel.Location = new System.Drawing.Point(16, 77);
            this.mLengthTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLengthTextLabel.Name = "mLengthTextLabel";
            this.mLengthTextLabel.Size = new System.Drawing.Size(0, 20);
            this.mLengthTextLabel.TabIndex = 7;
            // 
            // mTextSubmit
            // 
            this.mTextSubmit.Location = new System.Drawing.Point(165, 14);
            this.mTextSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mTextSubmit.Name = "mTextSubmit";
            this.mTextSubmit.Size = new System.Drawing.Size(112, 35);
            this.mTextSubmit.TabIndex = 6;
            this.mTextSubmit.Text = "Submit";
            this.mTextSubmit.UseVisualStyleBackColor = true;
            this.mTextSubmit.Click += new System.EventHandler(this.mTextSubmit_Click);
            // 
            // mText
            // 
            this.mText.Location = new System.Drawing.Point(90, 17);
            this.mText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mText.Name = "mText";
            this.mText.Size = new System.Drawing.Size(43, 26);
            this.mText.TabIndex = 2;
            // 
            // mLabelTextTab
            // 
            this.mLabelTextTab.AutoSize = true;
            this.mLabelTextTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelTextTab.Location = new System.Drawing.Point(16, 12);
            this.mLabelTextTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTextTab.Name = "mLabelTextTab";
            this.mLabelTextTab.Size = new System.Drawing.Size(41, 33);
            this.mLabelTextTab.TabIndex = 1;
            this.mLabelTextTab.Text = "m";
            // 
            // tabPicture
            // 
            this.tabPicture.Controls.Add(this.pictureErrorLabel);
            this.tabPicture.Controls.Add(this.pictureStartAgainButton);
            this.tabPicture.Controls.Add(this.pictureErrorRateText);
            this.tabPicture.Controls.Add(this.pictureErrorRateLabel);
            this.tabPicture.Controls.Add(this.pictureSend);
            this.tabPicture.Controls.Add(this.pictureWithoutCodingLabel);
            this.tabPicture.Controls.Add(this.pictureWithCodingLabel);
            this.tabPicture.Controls.Add(this.inputPictureLabel);
            this.tabPicture.Controls.Add(this.inputPictureBox);
            this.tabPicture.Controls.Add(this.pictureBoxWithCoding);
            this.tabPicture.Controls.Add(this.pictureBoxWithoutCoding);
            this.tabPicture.Controls.Add(this.mPictureLengthLabel);
            this.tabPicture.Controls.Add(this.openFileButton);
            this.tabPicture.Controls.Add(this.mPictureSubmit);
            this.tabPicture.Controls.Add(this.mPictureText);
            this.tabPicture.Controls.Add(this.mLabelPictureTab);
            this.tabPicture.Location = new System.Drawing.Point(4, 29);
            this.tabPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Size = new System.Drawing.Size(1184, 844);
            this.tabPicture.TabIndex = 2;
            this.tabPicture.Text = "Picture";
            this.tabPicture.UseVisualStyleBackColor = true;
            // 
            // pictureErrorLabel
            // 
            this.pictureErrorLabel.AutoSize = true;
            this.pictureErrorLabel.Location = new System.Drawing.Point(11, 240);
            this.pictureErrorLabel.Name = "pictureErrorLabel";
            this.pictureErrorLabel.Size = new System.Drawing.Size(0, 30);
            this.pictureErrorLabel.TabIndex = 24;
            // 
            // pictureStartAgainButton
            // 
            this.pictureStartAgainButton.Location = new System.Drawing.Point(534, 769);
            this.pictureStartAgainButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureStartAgainButton.Name = "pictureStartAgainButton";
            this.pictureStartAgainButton.Size = new System.Drawing.Size(112, 35);
            this.pictureStartAgainButton.TabIndex = 23;
            this.pictureStartAgainButton.Text = "Start again";
            this.pictureStartAgainButton.UseVisualStyleBackColor = true;
            this.pictureStartAgainButton.Visible = false;
            this.pictureStartAgainButton.Click += new System.EventHandler(this.pictureStartAgainButton_Click);
            // 
            // pictureErrorRateText
            // 
            this.pictureErrorRateText.Location = new System.Drawing.Point(195, 188);
            this.pictureErrorRateText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureErrorRateText.Name = "pictureErrorRateText";
            this.pictureErrorRateText.Size = new System.Drawing.Size(58, 26);
            this.pictureErrorRateText.TabIndex = 17;
            this.pictureErrorRateText.Text = "0.0";
            this.pictureErrorRateText.Visible = false;
            // 
            // pictureErrorRateLabel
            // 
            this.pictureErrorRateLabel.AutoSize = true;
            this.pictureErrorRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureErrorRateLabel.Location = new System.Drawing.Point(11, 185);
            this.pictureErrorRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureErrorRateLabel.Name = "pictureErrorRateLabel";
            this.pictureErrorRateLabel.Size = new System.Drawing.Size(148, 33);
            this.pictureErrorRateLabel.TabIndex = 16;
            this.pictureErrorRateLabel.Text = "Error rate";
            this.pictureErrorRateLabel.Visible = false;
            // 
            // pictureSend
            // 
            this.pictureSend.Location = new System.Drawing.Point(300, 185);
            this.pictureSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureSend.Name = "pictureSend";
            this.pictureSend.Size = new System.Drawing.Size(112, 35);
            this.pictureSend.TabIndex = 15;
            this.pictureSend.Text = "Send";
            this.pictureSend.UseVisualStyleBackColor = true;
            this.pictureSend.Visible = false;
            this.pictureSend.Click += new System.EventHandler(this.pictureSend_Click);
            // 
            // pictureWithoutCodingLabel
            // 
            this.pictureWithoutCodingLabel.AutoSize = true;
            this.pictureWithoutCodingLabel.Location = new System.Drawing.Point(810, 431);
            this.pictureWithoutCodingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureWithoutCodingLabel.Name = "pictureWithoutCodingLabel";
            this.pictureWithoutCodingLabel.Size = new System.Drawing.Size(164, 20);
            this.pictureWithoutCodingLabel.TabIndex = 12;
            this.pictureWithoutCodingLabel.Text = "Picture without coding";
            this.pictureWithoutCodingLabel.Visible = false;
            // 
            // pictureWithCodingLabel
            // 
            this.pictureWithCodingLabel.AutoSize = true;
            this.pictureWithCodingLabel.Location = new System.Drawing.Point(825, 43);
            this.pictureWithCodingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureWithCodingLabel.Name = "pictureWithCodingLabel";
            this.pictureWithCodingLabel.Size = new System.Drawing.Size(141, 20);
            this.pictureWithCodingLabel.TabIndex = 11;
            this.pictureWithCodingLabel.Text = "Picture with coding";
            this.pictureWithCodingLabel.Visible = false;
            // 
            // inputPictureLabel
            // 
            this.inputPictureLabel.AutoSize = true;
            this.inputPictureLabel.Location = new System.Drawing.Point(128, 431);
            this.inputPictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputPictureLabel.Name = "inputPictureLabel";
            this.inputPictureLabel.Size = new System.Drawing.Size(98, 20);
            this.inputPictureLabel.TabIndex = 10;
            this.inputPictureLabel.Text = "Input picture";
            this.inputPictureLabel.Visible = false;
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.Location = new System.Drawing.Point(30, 462);
            this.inputPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(300, 308);
            this.inputPictureBox.TabIndex = 9;
            this.inputPictureBox.TabStop = false;
            // 
            // pictureBoxWithCoding
            // 
            this.pictureBoxWithCoding.Location = new System.Drawing.Point(750, 77);
            this.pictureBoxWithCoding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxWithCoding.Name = "pictureBoxWithCoding";
            this.pictureBoxWithCoding.Size = new System.Drawing.Size(300, 308);
            this.pictureBoxWithCoding.TabIndex = 8;
            this.pictureBoxWithCoding.TabStop = false;
            // 
            // pictureBoxWithoutCoding
            // 
            this.pictureBoxWithoutCoding.Location = new System.Drawing.Point(750, 462);
            this.pictureBoxWithoutCoding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxWithoutCoding.Name = "pictureBoxWithoutCoding";
            this.pictureBoxWithoutCoding.Size = new System.Drawing.Size(300, 308);
            this.pictureBoxWithoutCoding.TabIndex = 7;
            this.pictureBoxWithoutCoding.TabStop = false;
            // 
            // mPictureLengthLabel
            // 
            this.mPictureLengthLabel.AutoSize = true;
            this.mPictureLengthLabel.Location = new System.Drawing.Point(16, 77);
            this.mPictureLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mPictureLengthLabel.Name = "mPictureLengthLabel";
            this.mPictureLengthLabel.Size = new System.Drawing.Size(0, 20);
            this.mPictureLengthLabel.TabIndex = 6;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(16, 123);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(112, 35);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Visible = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // mPictureSubmit
            // 
            this.mPictureSubmit.Location = new System.Drawing.Point(165, 14);
            this.mPictureSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPictureSubmit.Name = "mPictureSubmit";
            this.mPictureSubmit.Size = new System.Drawing.Size(112, 35);
            this.mPictureSubmit.TabIndex = 4;
            this.mPictureSubmit.Text = "Submit";
            this.mPictureSubmit.UseVisualStyleBackColor = true;
            this.mPictureSubmit.Click += new System.EventHandler(this.mPictureSubmit_Click);
            // 
            // mPictureText
            // 
            this.mPictureText.Location = new System.Drawing.Point(90, 17);
            this.mPictureText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mPictureText.Name = "mPictureText";
            this.mPictureText.Size = new System.Drawing.Size(43, 26);
            this.mPictureText.TabIndex = 3;
            // 
            // mLabelPictureTab
            // 
            this.mLabelPictureTab.AutoSize = true;
            this.mLabelPictureTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabelPictureTab.Location = new System.Drawing.Point(16, 12);
            this.mLabelPictureTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mLabelPictureTab.Name = "mLabelPictureTab";
            this.mLabelPictureTab.Size = new System.Drawing.Size(41, 33);
            this.mLabelPictureTab.TabIndex = 1;
            this.mLabelPictureTab.Text = "m";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tabControl.ResumeLayout(false);
            this.tabVector.ResumeLayout(false);
            this.tabVector.PerformLayout();
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabPicture.ResumeLayout(false);
            this.tabPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithCoding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithoutCoding)).EndInit();
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
        private System.Windows.Forms.Label mLengthTextLabel;
        private System.Windows.Forms.TextBox textErrorRateInput;
        private System.Windows.Forms.Label textErrorRateLabel;
        private System.Windows.Forms.Button textSendButton;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label textErrorLabel;
        private System.Windows.Forms.TextBox textWithCodingOutput;
        private System.Windows.Forms.Label textWithCodingLabel;
        private System.Windows.Forms.TextBox textWithoutCodingOutput;
        private System.Windows.Forms.Label textWithoutCodingLabel;
        private System.Windows.Forms.Button textStartAgainButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label mPictureLengthLabel;
        private System.Windows.Forms.PictureBox pictureBoxWithoutCoding;
        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxWithCoding;
        private System.Windows.Forms.Label pictureWithoutCodingLabel;
        private System.Windows.Forms.Label pictureWithCodingLabel;
        private System.Windows.Forms.Label inputPictureLabel;
        private System.Windows.Forms.TextBox pictureErrorRateText;
        private System.Windows.Forms.Label pictureErrorRateLabel;
        private System.Windows.Forms.Button pictureSend;
        private System.Windows.Forms.Button pictureStartAgainButton;
        private System.Windows.Forms.Label pictureErrorLabel;
    }
}

