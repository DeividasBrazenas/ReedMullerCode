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
            this.MTextBox = new System.Windows.Forms.TextBox();
            this.MLabel = new System.Windows.Forms.Label();
            this.MSubmitButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.VectorLengthLabel = new System.Windows.Forms.Label();
            this.VectorTextBox = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MTextBox
            // 
            this.MTextBox.Location = new System.Drawing.Point(49, 23);
            this.MTextBox.Name = "MTextBox";
            this.MTextBox.Size = new System.Drawing.Size(100, 26);
            this.MTextBox.TabIndex = 0;
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Location = new System.Drawing.Point(16, 23);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(22, 20);
            this.MLabel.TabIndex = 1;
            this.MLabel.Text = "m";
            // 
            // MSubmitButton
            // 
            this.MSubmitButton.Location = new System.Drawing.Point(190, 26);
            this.MSubmitButton.Name = "MSubmitButton";
            this.MSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.MSubmitButton.TabIndex = 3;
            this.MSubmitButton.Text = "Submit";
            this.MSubmitButton.UseVisualStyleBackColor = true;
            this.MSubmitButton.Click += new System.EventHandler(this.MSubmitButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(464, 26);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 4;
            // 
            // VectorLengthLabel
            // 
            this.VectorLengthLabel.AutoSize = true;
            this.VectorLengthLabel.Location = new System.Drawing.Point(16, 84);
            this.VectorLengthLabel.Name = "VectorLengthLabel";
            this.VectorLengthLabel.Size = new System.Drawing.Size(0, 30);
            this.VectorLengthLabel.TabIndex = 5;
            // 
            // VectorTextBox
            // 
            this.VectorTextBox.Location = new System.Drawing.Point(49, 138);
            this.VectorTextBox.Name = "VectorTextBox";
            this.VectorTextBox.Size = new System.Drawing.Size(100, 26);
            this.VectorTextBox.TabIndex = 6;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(190, 140);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 7;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 492);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.VectorTextBox);
            this.Controls.Add(this.VectorLengthLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.MSubmitButton);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.MTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MTextBox;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Button MSubmitButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label VectorLengthLabel;
        private System.Windows.Forms.TextBox VectorTextBox;
        private System.Windows.Forms.Button EncodeButton;
    }
}

