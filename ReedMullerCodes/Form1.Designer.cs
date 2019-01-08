namespace ReedMullerCodes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectorPanel = new System.Windows.Forms.Panel();
            this.mistakesPositionsLabel = new System.Windows.Forms.Label();
            this.mistakesPositionsTextBox = new System.Windows.Forms.TextBox();
            this.mistakesFoundTextBox = new System.Windows.Forms.TextBox();
            this.mistakesFoundLabel = new System.Windows.Forms.Label();
            this.vectorLength = new System.Windows.Forms.Label();
            this.decodedVectorTextBox = new System.Windows.Forms.TextBox();
            this.decodedVectorLabel = new System.Windows.Forms.Label();
            this.decodeVectorButton = new System.Windows.Forms.Button();
            this.sendVectorButton = new System.Windows.Forms.Button();
            this.receivedVectorTextBox = new System.Windows.Forms.TextBox();
            this.receivedVectorLabel = new System.Windows.Forms.Label();
            this.encodedVectorLabel = new System.Windows.Forms.Label();
            this.encodedVectorTextBox = new System.Windows.Forms.TextBox();
            this.probabilityLabel = new System.Windows.Forms.Label();
            this.probabilityTextBox = new System.Windows.Forms.TextBox();
            this.enterVectorSubmit = new System.Windows.Forms.Button();
            this.enterVectorLabel = new System.Windows.Forms.Label();
            this.enterVectorTextBox = new System.Windows.Forms.TextBox();
            this.parametersButton = new System.Windows.Forms.Button();
            this.parameterRLabel = new System.Windows.Forms.Label();
            this.parameterMLabel = new System.Windows.Forms.Label();
            this.parameterRTextBox = new System.Windows.Forms.TextBox();
            this.parameterMTextBox = new System.Windows.Forms.TextBox();
            this.textPanel = new System.Windows.Forms.Panel();
            this.receivedTextTextBox = new System.Windows.Forms.TextBox();
            this.resultPlainTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBytesTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBytesLabel = new System.Windows.Forms.Label();
            this.textProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.textProbabilityLabel = new System.Windows.Forms.Label();
            this.receivedPlainTextTextBox = new System.Windows.Forms.TextBox();
            this.receivedPlainTextLabel = new System.Windows.Forms.Label();
            this.receivedTextLabel = new System.Windows.Forms.Label();
            this.decodedTextTextBox = new System.Windows.Forms.TextBox();
            this.decodedTextLabel = new System.Windows.Forms.Label();
            this.encodedTextTextBox = new System.Windows.Forms.TextBox();
            this.encodedTextLabel = new System.Windows.Forms.Label();
            this.encodeTextButton = new System.Windows.Forms.Button();
            this.enterTextLabel = new System.Windows.Forms.Label();
            this.enterTextTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.vectorPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vectorToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vectorToolStripMenuItem
            // 
            this.vectorToolStripMenuItem.Name = "vectorToolStripMenuItem";
            this.vectorToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.vectorToolStripMenuItem.Text = "Vector";
            this.vectorToolStripMenuItem.Click += new System.EventHandler(this.onVectorClick);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.onTextClick);
            // 
            // vectorPanel
            // 
            this.vectorPanel.Controls.Add(this.mistakesPositionsLabel);
            this.vectorPanel.Controls.Add(this.mistakesPositionsTextBox);
            this.vectorPanel.Controls.Add(this.mistakesFoundTextBox);
            this.vectorPanel.Controls.Add(this.mistakesFoundLabel);
            this.vectorPanel.Controls.Add(this.vectorLength);
            this.vectorPanel.Controls.Add(this.decodedVectorTextBox);
            this.vectorPanel.Controls.Add(this.decodedVectorLabel);
            this.vectorPanel.Controls.Add(this.decodeVectorButton);
            this.vectorPanel.Controls.Add(this.sendVectorButton);
            this.vectorPanel.Controls.Add(this.receivedVectorTextBox);
            this.vectorPanel.Controls.Add(this.receivedVectorLabel);
            this.vectorPanel.Controls.Add(this.encodedVectorLabel);
            this.vectorPanel.Controls.Add(this.encodedVectorTextBox);
            this.vectorPanel.Controls.Add(this.probabilityLabel);
            this.vectorPanel.Controls.Add(this.probabilityTextBox);
            this.vectorPanel.Controls.Add(this.enterVectorSubmit);
            this.vectorPanel.Controls.Add(this.enterVectorLabel);
            this.vectorPanel.Controls.Add(this.enterVectorTextBox);
            this.vectorPanel.Location = new System.Drawing.Point(12, 112);
            this.vectorPanel.Name = "vectorPanel";
            this.vectorPanel.Size = new System.Drawing.Size(892, 428);
            this.vectorPanel.TabIndex = 1;
            // 
            // mistakesPositionsLabel
            // 
            this.mistakesPositionsLabel.AutoSize = true;
            this.mistakesPositionsLabel.Location = new System.Drawing.Point(513, 131);
            this.mistakesPositionsLabel.Name = "mistakesPositionsLabel";
            this.mistakesPositionsLabel.Size = new System.Drawing.Size(130, 17);
            this.mistakesPositionsLabel.TabIndex = 23;
            this.mistakesPositionsLabel.Text = "Mistakes\' positions:";
            // 
            // mistakesPositionsTextBox
            // 
            this.mistakesPositionsTextBox.Location = new System.Drawing.Point(516, 169);
            this.mistakesPositionsTextBox.Name = "mistakesPositionsTextBox";
            this.mistakesPositionsTextBox.Size = new System.Drawing.Size(243, 22);
            this.mistakesPositionsTextBox.TabIndex = 22;
            // 
            // mistakesFoundTextBox
            // 
            this.mistakesFoundTextBox.Location = new System.Drawing.Point(645, 92);
            this.mistakesFoundTextBox.Name = "mistakesFoundTextBox";
            this.mistakesFoundTextBox.Size = new System.Drawing.Size(100, 22);
            this.mistakesFoundTextBox.TabIndex = 21;
            // 
            // mistakesFoundLabel
            // 
            this.mistakesFoundLabel.AutoSize = true;
            this.mistakesFoundLabel.Location = new System.Drawing.Point(513, 97);
            this.mistakesFoundLabel.Name = "mistakesFoundLabel";
            this.mistakesFoundLabel.Size = new System.Drawing.Size(107, 17);
            this.mistakesFoundLabel.TabIndex = 20;
            this.mistakesFoundLabel.Text = "Mistakes found:";
            // 
            // vectorLength
            // 
            this.vectorLength.AutoSize = true;
            this.vectorLength.Location = new System.Drawing.Point(203, 92);
            this.vectorLength.Name = "vectorLength";
            this.vectorLength.Size = new System.Drawing.Size(0, 17);
            this.vectorLength.TabIndex = 19;
            // 
            // decodedVectorTextBox
            // 
            this.decodedVectorTextBox.Location = new System.Drawing.Point(516, 279);
            this.decodedVectorTextBox.Name = "decodedVectorTextBox";
            this.decodedVectorTextBox.Size = new System.Drawing.Size(243, 22);
            this.decodedVectorTextBox.TabIndex = 13;
            // 
            // decodedVectorLabel
            // 
            this.decodedVectorLabel.AutoSize = true;
            this.decodedVectorLabel.Location = new System.Drawing.Point(513, 249);
            this.decodedVectorLabel.Name = "decodedVectorLabel";
            this.decodedVectorLabel.Size = new System.Drawing.Size(110, 17);
            this.decodedVectorLabel.TabIndex = 12;
            this.decodedVectorLabel.Text = "Decoded Vector";
            // 
            // decodeVectorButton
            // 
            this.decodeVectorButton.Location = new System.Drawing.Point(801, 168);
            this.decodeVectorButton.Name = "decodeVectorButton";
            this.decodeVectorButton.Size = new System.Drawing.Size(75, 23);
            this.decodeVectorButton.TabIndex = 11;
            this.decodeVectorButton.Text = "Decode";
            this.decodeVectorButton.UseVisualStyleBackColor = true;
            this.decodeVectorButton.Click += new System.EventHandler(this.decodeVectorButton_Click);
            // 
            // sendVectorButton
            // 
            this.sendVectorButton.Location = new System.Drawing.Point(314, 213);
            this.sendVectorButton.Name = "sendVectorButton";
            this.sendVectorButton.Size = new System.Drawing.Size(75, 23);
            this.sendVectorButton.TabIndex = 10;
            this.sendVectorButton.Text = "Send";
            this.sendVectorButton.UseVisualStyleBackColor = true;
            this.sendVectorButton.Click += new System.EventHandler(this.sendVectorButton_Click);
            // 
            // receivedVectorTextBox
            // 
            this.receivedVectorTextBox.Location = new System.Drawing.Point(516, 50);
            this.receivedVectorTextBox.Name = "receivedVectorTextBox";
            this.receivedVectorTextBox.Size = new System.Drawing.Size(243, 22);
            this.receivedVectorTextBox.TabIndex = 9;
            // 
            // receivedVectorLabel
            // 
            this.receivedVectorLabel.AutoSize = true;
            this.receivedVectorLabel.Location = new System.Drawing.Point(513, 17);
            this.receivedVectorLabel.Name = "receivedVectorLabel";
            this.receivedVectorLabel.Size = new System.Drawing.Size(112, 17);
            this.receivedVectorLabel.TabIndex = 8;
            this.receivedVectorLabel.Text = "Received Vector";
            // 
            // encodedVectorLabel
            // 
            this.encodedVectorLabel.AutoSize = true;
            this.encodedVectorLabel.Location = new System.Drawing.Point(45, 174);
            this.encodedVectorLabel.Name = "encodedVectorLabel";
            this.encodedVectorLabel.Size = new System.Drawing.Size(109, 17);
            this.encodedVectorLabel.TabIndex = 7;
            this.encodedVectorLabel.Text = "Encoded Vector";
            // 
            // encodedVectorTextBox
            // 
            this.encodedVectorTextBox.Location = new System.Drawing.Point(49, 213);
            this.encodedVectorTextBox.Name = "encodedVectorTextBox";
            this.encodedVectorTextBox.Size = new System.Drawing.Size(243, 22);
            this.encodedVectorTextBox.TabIndex = 6;
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.AutoSize = true;
            this.probabilityLabel.Location = new System.Drawing.Point(46, 249);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(116, 17);
            this.probabilityLabel.TabIndex = 5;
            this.probabilityLabel.Text = "Errors probability";
            // 
            // probabilityTextBox
            // 
            this.probabilityTextBox.Location = new System.Drawing.Point(49, 279);
            this.probabilityTextBox.Name = "probabilityTextBox";
            this.probabilityTextBox.Size = new System.Drawing.Size(181, 22);
            this.probabilityTextBox.TabIndex = 3;
            // 
            // enterVectorSubmit
            // 
            this.enterVectorSubmit.Location = new System.Drawing.Point(274, 125);
            this.enterVectorSubmit.Name = "enterVectorSubmit";
            this.enterVectorSubmit.Size = new System.Drawing.Size(75, 23);
            this.enterVectorSubmit.TabIndex = 2;
            this.enterVectorSubmit.Text = "Encode";
            this.enterVectorSubmit.UseVisualStyleBackColor = true;
            this.enterVectorSubmit.Click += new System.EventHandler(this.VectorEnter_OnClick);
            // 
            // enterVectorLabel
            // 
            this.enterVectorLabel.AutoSize = true;
            this.enterVectorLabel.Location = new System.Drawing.Point(46, 92);
            this.enterVectorLabel.Name = "enterVectorLabel";
            this.enterVectorLabel.Size = new System.Drawing.Size(151, 17);
            this.enterVectorLabel.TabIndex = 1;
            this.enterVectorLabel.Text = "Enter Vector   Length: ";
            // 
            // enterVectorTextBox
            // 
            this.enterVectorTextBox.Location = new System.Drawing.Point(49, 125);
            this.enterVectorTextBox.Name = "enterVectorTextBox";
            this.enterVectorTextBox.Size = new System.Drawing.Size(181, 22);
            this.enterVectorTextBox.TabIndex = 0;
            this.enterVectorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterVector_KeyPress);
            // 
            // parametersButton
            // 
            this.parametersButton.Location = new System.Drawing.Point(326, 80);
            this.parametersButton.Name = "parametersButton";
            this.parametersButton.Size = new System.Drawing.Size(75, 23);
            this.parametersButton.TabIndex = 18;
            this.parametersButton.Text = "Submit";
            this.parametersButton.UseVisualStyleBackColor = true;
            this.parametersButton.Click += new System.EventHandler(this.Parameters_OnClick);
            // 
            // parameterRLabel
            // 
            this.parameterRLabel.AutoSize = true;
            this.parameterRLabel.Location = new System.Drawing.Point(193, 48);
            this.parameterRLabel.Name = "parameterRLabel";
            this.parameterRLabel.Size = new System.Drawing.Size(88, 17);
            this.parameterRLabel.TabIndex = 17;
            this.parameterRLabel.Text = "Parameter R";
            // 
            // parameterMLabel
            // 
            this.parameterMLabel.AutoSize = true;
            this.parameterMLabel.Location = new System.Drawing.Point(58, 48);
            this.parameterMLabel.Name = "parameterMLabel";
            this.parameterMLabel.Size = new System.Drawing.Size(89, 17);
            this.parameterMLabel.TabIndex = 16;
            this.parameterMLabel.Text = "Parameter M";
            // 
            // parameterRTextBox
            // 
            this.parameterRTextBox.Location = new System.Drawing.Point(196, 81);
            this.parameterRTextBox.Name = "parameterRTextBox";
            this.parameterRTextBox.Size = new System.Drawing.Size(94, 22);
            this.parameterRTextBox.TabIndex = 15;
            this.parameterRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParameterR_KeyPress);
            // 
            // parameterMTextBox
            // 
            this.parameterMTextBox.Location = new System.Drawing.Point(60, 81);
            this.parameterMTextBox.Name = "parameterMTextBox";
            this.parameterMTextBox.Size = new System.Drawing.Size(99, 22);
            this.parameterMTextBox.TabIndex = 14;
            this.parameterMTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParameterMTextBox_KeyPress);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.receivedTextTextBox);
            this.textPanel.Controls.Add(this.resultPlainTextBox);
            this.textPanel.Controls.Add(this.plainTextBytesTextBox);
            this.textPanel.Controls.Add(this.plainTextBytesLabel);
            this.textPanel.Controls.Add(this.textProbabilityTextBox);
            this.textPanel.Controls.Add(this.textProbabilityLabel);
            this.textPanel.Controls.Add(this.receivedPlainTextTextBox);
            this.textPanel.Controls.Add(this.receivedPlainTextLabel);
            this.textPanel.Controls.Add(this.receivedTextLabel);
            this.textPanel.Controls.Add(this.decodedTextTextBox);
            this.textPanel.Controls.Add(this.decodedTextLabel);
            this.textPanel.Controls.Add(this.encodedTextTextBox);
            this.textPanel.Controls.Add(this.encodedTextLabel);
            this.textPanel.Controls.Add(this.encodeTextButton);
            this.textPanel.Controls.Add(this.enterTextLabel);
            this.textPanel.Controls.Add(this.enterTextTextBox);
            this.textPanel.Location = new System.Drawing.Point(11, 109);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(893, 709);
            this.textPanel.TabIndex = 24;
            this.textPanel.Visible = false;
            // 
            // receivedTextTextBox
            // 
            this.receivedTextTextBox.Location = new System.Drawing.Point(56, 437);
            this.receivedTextTextBox.Multiline = true;
            this.receivedTextTextBox.Name = "receivedTextTextBox";
            this.receivedTextTextBox.Size = new System.Drawing.Size(228, 103);
            this.receivedTextTextBox.TabIndex = 18;
            this.receivedTextTextBox.Visible = false;
            // 
            // resultPlainTextBox
            // 
            this.resultPlainTextBox.Location = new System.Drawing.Point(397, 585);
            this.resultPlainTextBox.Multiline = true;
            this.resultPlainTextBox.Name = "resultPlainTextBox";
            this.resultPlainTextBox.Size = new System.Drawing.Size(190, 103);
            this.resultPlainTextBox.TabIndex = 17;
            this.resultPlainTextBox.Visible = false;
            // 
            // plainTextBytesTextBox
            // 
            this.plainTextBytesTextBox.Location = new System.Drawing.Point(397, 282);
            this.plainTextBytesTextBox.Multiline = true;
            this.plainTextBytesTextBox.Name = "plainTextBytesTextBox";
            this.plainTextBytesTextBox.Size = new System.Drawing.Size(190, 103);
            this.plainTextBytesTextBox.TabIndex = 16;
            this.plainTextBytesTextBox.Visible = false;
            // 
            // plainTextBytesLabel
            // 
            this.plainTextBytesLabel.AutoSize = true;
            this.plainTextBytesLabel.Location = new System.Drawing.Point(397, 240);
            this.plainTextBytesLabel.Name = "plainTextBytesLabel";
            this.plainTextBytesLabel.Size = new System.Drawing.Size(65, 17);
            this.plainTextBytesLabel.TabIndex = 15;
            this.plainTextBytesLabel.Text = "Plain text";
            this.plainTextBytesLabel.Visible = false;
            // 
            // textProbabilityTextBox
            // 
            this.textProbabilityTextBox.Location = new System.Drawing.Point(333, 53);
            this.textProbabilityTextBox.Multiline = true;
            this.textProbabilityTextBox.Name = "textProbabilityTextBox";
            this.textProbabilityTextBox.Size = new System.Drawing.Size(150, 28);
            this.textProbabilityTextBox.TabIndex = 14;
            // 
            // textProbabilityLabel
            // 
            this.textProbabilityLabel.AutoSize = true;
            this.textProbabilityLabel.Location = new System.Drawing.Point(330, 20);
            this.textProbabilityLabel.Name = "textProbabilityLabel";
            this.textProbabilityLabel.Size = new System.Drawing.Size(111, 17);
            this.textProbabilityLabel.TabIndex = 13;
            this.textProbabilityLabel.Text = "Enter probability";
            // 
            // receivedPlainTextTextBox
            // 
            this.receivedPlainTextTextBox.Location = new System.Drawing.Point(397, 437);
            this.receivedPlainTextTextBox.Multiline = true;
            this.receivedPlainTextTextBox.Name = "receivedPlainTextTextBox";
            this.receivedPlainTextTextBox.Size = new System.Drawing.Size(190, 103);
            this.receivedPlainTextTextBox.TabIndex = 12;
            this.receivedPlainTextTextBox.Visible = false;
            // 
            // receivedPlainTextLabel
            // 
            this.receivedPlainTextLabel.AutoSize = true;
            this.receivedPlainTextLabel.Location = new System.Drawing.Point(394, 404);
            this.receivedPlainTextLabel.Name = "receivedPlainTextLabel";
            this.receivedPlainTextLabel.Size = new System.Drawing.Size(133, 17);
            this.receivedPlainTextLabel.TabIndex = 11;
            this.receivedPlainTextLabel.Text = "Received Plain Text";
            this.receivedPlainTextLabel.Visible = false;
            // 
            // receivedTextLabel
            // 
            this.receivedTextLabel.AutoSize = true;
            this.receivedTextLabel.Location = new System.Drawing.Point(53, 404);
            this.receivedTextLabel.Name = "receivedTextLabel";
            this.receivedTextLabel.Size = new System.Drawing.Size(98, 17);
            this.receivedTextLabel.TabIndex = 8;
            this.receivedTextLabel.Text = "Received Text";
            this.receivedTextLabel.Visible = false;
            // 
            // decodedTextTextBox
            // 
            this.decodedTextTextBox.Location = new System.Drawing.Point(56, 585);
            this.decodedTextTextBox.Multiline = true;
            this.decodedTextTextBox.Name = "decodedTextTextBox";
            this.decodedTextTextBox.Size = new System.Drawing.Size(218, 103);
            this.decodedTextTextBox.TabIndex = 6;
            this.decodedTextTextBox.Visible = false;
            // 
            // decodedTextLabel
            // 
            this.decodedTextLabel.AutoSize = true;
            this.decodedTextLabel.Location = new System.Drawing.Point(272, 550);
            this.decodedTextLabel.Name = "decodedTextLabel";
            this.decodedTextLabel.Size = new System.Drawing.Size(96, 17);
            this.decodedTextLabel.TabIndex = 5;
            this.decodedTextLabel.Text = "Decoded Text";
            this.decodedTextLabel.Visible = false;
            // 
            // encodedTextTextBox
            // 
            this.encodedTextTextBox.Location = new System.Drawing.Point(56, 282);
            this.encodedTextTextBox.Multiline = true;
            this.encodedTextTextBox.Name = "encodedTextTextBox";
            this.encodedTextTextBox.Size = new System.Drawing.Size(228, 103);
            this.encodedTextTextBox.TabIndex = 4;
            this.encodedTextTextBox.Visible = false;
            // 
            // encodedTextLabel
            // 
            this.encodedTextLabel.AutoSize = true;
            this.encodedTextLabel.Location = new System.Drawing.Point(53, 241);
            this.encodedTextLabel.Name = "encodedTextLabel";
            this.encodedTextLabel.Size = new System.Drawing.Size(95, 17);
            this.encodedTextLabel.TabIndex = 3;
            this.encodedTextLabel.Text = "Encoded Text";
            this.encodedTextLabel.Visible = false;
            // 
            // encodeTextButton
            // 
            this.encodeTextButton.Location = new System.Drawing.Point(49, 174);
            this.encodeTextButton.Name = "encodeTextButton";
            this.encodeTextButton.Size = new System.Drawing.Size(75, 23);
            this.encodeTextButton.TabIndex = 2;
            this.encodeTextButton.Text = "Encode";
            this.encodeTextButton.UseVisualStyleBackColor = true;
            this.encodeTextButton.Click += new System.EventHandler(this.encodeTextButton_Click);
            // 
            // enterTextLabel
            // 
            this.enterTextLabel.AutoSize = true;
            this.enterTextLabel.Location = new System.Drawing.Point(45, 20);
            this.enterTextLabel.Name = "enterTextLabel";
            this.enterTextLabel.Size = new System.Drawing.Size(72, 17);
            this.enterTextLabel.TabIndex = 1;
            this.enterTextLabel.Text = "Enter text:";
            // 
            // enterTextTextBox
            // 
            this.enterTextTextBox.Location = new System.Drawing.Point(48, 53);
            this.enterTextTextBox.Multiline = true;
            this.enterTextTextBox.Name = "enterTextTextBox";
            this.enterTextTextBox.Size = new System.Drawing.Size(220, 103);
            this.enterTextTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 830);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.parameterMLabel);
            this.Controls.Add(this.parameterRLabel);
            this.Controls.Add(this.parametersButton);
            this.Controls.Add(this.parameterRTextBox);
            this.Controls.Add(this.parameterMTextBox);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.vectorPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.vectorPanel.ResumeLayout(false);
            this.vectorPanel.PerformLayout();
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vectorToolStripMenuItem;
        private System.Windows.Forms.Panel vectorPanel;
        private System.Windows.Forms.TextBox enterVectorTextBox;
        private System.Windows.Forms.Label enterVectorLabel;
        private System.Windows.Forms.Button enterVectorSubmit;
        private System.Windows.Forms.Label probabilityLabel;
        private System.Windows.Forms.TextBox probabilityTextBox;
        private System.Windows.Forms.Label encodedVectorLabel;
        private System.Windows.Forms.TextBox encodedVectorTextBox;
        private System.Windows.Forms.Button decodeVectorButton;
        private System.Windows.Forms.Button sendVectorButton;
        private System.Windows.Forms.TextBox receivedVectorTextBox;
        private System.Windows.Forms.Label receivedVectorLabel;
        private System.Windows.Forms.TextBox decodedVectorTextBox;
        private System.Windows.Forms.Label decodedVectorLabel;
        private System.Windows.Forms.Button parametersButton;
        private System.Windows.Forms.Label parameterRLabel;
        private System.Windows.Forms.Label parameterMLabel;
        private System.Windows.Forms.TextBox parameterRTextBox;
        private System.Windows.Forms.TextBox parameterMTextBox;
        private System.Windows.Forms.Label vectorLength;
        private System.Windows.Forms.Label mistakesPositionsLabel;
        private System.Windows.Forms.TextBox mistakesPositionsTextBox;
        private System.Windows.Forms.TextBox mistakesFoundTextBox;
        private System.Windows.Forms.Label mistakesFoundLabel;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Button encodeTextButton;
        private System.Windows.Forms.Label enterTextLabel;
        private System.Windows.Forms.TextBox enterTextTextBox;
        private System.Windows.Forms.TextBox textProbabilityTextBox;
        private System.Windows.Forms.Label textProbabilityLabel;
        private System.Windows.Forms.TextBox receivedPlainTextTextBox;
        private System.Windows.Forms.Label receivedPlainTextLabel;
        private System.Windows.Forms.Label receivedTextLabel;
        private System.Windows.Forms.TextBox decodedTextTextBox;
        private System.Windows.Forms.Label decodedTextLabel;
        private System.Windows.Forms.TextBox encodedTextTextBox;
        private System.Windows.Forms.Label encodedTextLabel;
        private System.Windows.Forms.TextBox resultPlainTextBox;
        private System.Windows.Forms.TextBox plainTextBytesTextBox;
        private System.Windows.Forms.Label plainTextBytesLabel;
        private System.Windows.Forms.TextBox receivedTextTextBox;
    }
}

