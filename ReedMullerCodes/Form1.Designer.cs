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
            this.vectorPanel = new System.Windows.Forms.Panel();
            this.parametersButton = new System.Windows.Forms.Button();
            this.parameterRLabel = new System.Windows.Forms.Label();
            this.parameterMLabel = new System.Windows.Forms.Label();
            this.parameterRTextBox = new System.Windows.Forms.TextBox();
            this.parameterMTextBox = new System.Windows.Forms.TextBox();
            this.decodedVectorTextBox = new System.Windows.Forms.TextBox();
            this.decodedVectorLabel = new System.Windows.Forms.Label();
            this.decodeVectorButton = new System.Windows.Forms.Button();
            this.sendVectorButton = new System.Windows.Forms.Button();
            this.receivedVectorTextBox = new System.Windows.Forms.TextBox();
            this.receivedVector = new System.Windows.Forms.Label();
            this.encodedVector = new System.Windows.Forms.Label();
            this.encodedVectorTextBox = new System.Windows.Forms.TextBox();
            this.probabilityLabel = new System.Windows.Forms.Label();
            this.probabilityButton = new System.Windows.Forms.Button();
            this.probabilityTextBox = new System.Windows.Forms.TextBox();
            this.enterVectorSubmit = new System.Windows.Forms.Button();
            this.enterVectorLabel = new System.Windows.Forms.Label();
            this.enterVectorTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.vectorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vectorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
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
            // vectorPanel
            // 
            this.vectorPanel.Controls.Add(this.parametersButton);
            this.vectorPanel.Controls.Add(this.parameterRLabel);
            this.vectorPanel.Controls.Add(this.parameterMLabel);
            this.vectorPanel.Controls.Add(this.parameterRTextBox);
            this.vectorPanel.Controls.Add(this.parameterMTextBox);
            this.vectorPanel.Controls.Add(this.decodedVectorTextBox);
            this.vectorPanel.Controls.Add(this.decodedVectorLabel);
            this.vectorPanel.Controls.Add(this.decodeVectorButton);
            this.vectorPanel.Controls.Add(this.sendVectorButton);
            this.vectorPanel.Controls.Add(this.receivedVectorTextBox);
            this.vectorPanel.Controls.Add(this.receivedVector);
            this.vectorPanel.Controls.Add(this.encodedVector);
            this.vectorPanel.Controls.Add(this.encodedVectorTextBox);
            this.vectorPanel.Controls.Add(this.probabilityLabel);
            this.vectorPanel.Controls.Add(this.probabilityButton);
            this.vectorPanel.Controls.Add(this.probabilityTextBox);
            this.vectorPanel.Controls.Add(this.enterVectorSubmit);
            this.vectorPanel.Controls.Add(this.enterVectorLabel);
            this.vectorPanel.Controls.Add(this.enterVectorTextBox);
            this.vectorPanel.Location = new System.Drawing.Point(13, 32);
            this.vectorPanel.Name = "vectorPanel";
            this.vectorPanel.Size = new System.Drawing.Size(928, 328);
            this.vectorPanel.TabIndex = 1;
            // 
            // parametersButton
            // 
            this.parametersButton.Location = new System.Drawing.Point(314, 49);
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
            this.parameterRLabel.Location = new System.Drawing.Point(181, 17);
            this.parameterRLabel.Name = "parameterRLabel";
            this.parameterRLabel.Size = new System.Drawing.Size(88, 17);
            this.parameterRLabel.TabIndex = 17;
            this.parameterRLabel.Text = "Parameter R";
            // 
            // parameterMLabel
            // 
            this.parameterMLabel.AutoSize = true;
            this.parameterMLabel.Location = new System.Drawing.Point(45, 17);
            this.parameterMLabel.Name = "parameterMLabel";
            this.parameterMLabel.Size = new System.Drawing.Size(89, 17);
            this.parameterMLabel.TabIndex = 16;
            this.parameterMLabel.Text = "Parameter M";
            // 
            // parameterRTextBox
            // 
            this.parameterRTextBox.Location = new System.Drawing.Point(184, 50);
            this.parameterRTextBox.Name = "parameterRTextBox";
            this.parameterRTextBox.Size = new System.Drawing.Size(94, 22);
            this.parameterRTextBox.TabIndex = 15;
            this.parameterRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParameterR_KeyPress);
            // 
            // parameterMTextBox
            // 
            this.parameterMTextBox.Location = new System.Drawing.Point(48, 50);
            this.parameterMTextBox.Name = "parameterMTextBox";
            this.parameterMTextBox.Size = new System.Drawing.Size(99, 22);
            this.parameterMTextBox.TabIndex = 14;
            this.parameterMTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParameterMTextBox_KeyPress);
            // 
            // decodedVectorTextBox
            // 
            this.decodedVectorTextBox.Location = new System.Drawing.Point(516, 252);
            this.decodedVectorTextBox.Name = "decodedVectorTextBox";
            this.decodedVectorTextBox.Size = new System.Drawing.Size(243, 22);
            this.decodedVectorTextBox.TabIndex = 13;
            // 
            // decodedVectorLabel
            // 
            this.decodedVectorLabel.AutoSize = true;
            this.decodedVectorLabel.Location = new System.Drawing.Point(515, 224);
            this.decodedVectorLabel.Name = "decodedVectorLabel";
            this.decodedVectorLabel.Size = new System.Drawing.Size(110, 17);
            this.decodedVectorLabel.TabIndex = 12;
            this.decodedVectorLabel.Text = "Decoded Vector";
            // 
            // decodeVectorButton
            // 
            this.decodeVectorButton.Location = new System.Drawing.Point(804, 141);
            this.decodeVectorButton.Name = "decodeVectorButton";
            this.decodeVectorButton.Size = new System.Drawing.Size(75, 23);
            this.decodeVectorButton.TabIndex = 11;
            this.decodeVectorButton.Text = "Decode";
            this.decodeVectorButton.UseVisualStyleBackColor = true;
            // 
            // sendVectorButton
            // 
            this.sendVectorButton.Location = new System.Drawing.Point(804, 49);
            this.sendVectorButton.Name = "sendVectorButton";
            this.sendVectorButton.Size = new System.Drawing.Size(75, 23);
            this.sendVectorButton.TabIndex = 10;
            this.sendVectorButton.Text = "Send";
            this.sendVectorButton.UseVisualStyleBackColor = true;
            // 
            // receivedVectorTextBox
            // 
            this.receivedVectorTextBox.Location = new System.Drawing.Point(516, 141);
            this.receivedVectorTextBox.Name = "receivedVectorTextBox";
            this.receivedVectorTextBox.Size = new System.Drawing.Size(243, 22);
            this.receivedVectorTextBox.TabIndex = 9;
            // 
            // receivedVector
            // 
            this.receivedVector.AutoSize = true;
            this.receivedVector.Location = new System.Drawing.Point(513, 111);
            this.receivedVector.Name = "receivedVector";
            this.receivedVector.Size = new System.Drawing.Size(112, 17);
            this.receivedVector.TabIndex = 8;
            this.receivedVector.Text = "Received Vector";
            // 
            // encodedVector
            // 
            this.encodedVector.AutoSize = true;
            this.encodedVector.Location = new System.Drawing.Point(513, 17);
            this.encodedVector.Name = "encodedVector";
            this.encodedVector.Size = new System.Drawing.Size(109, 17);
            this.encodedVector.TabIndex = 7;
            this.encodedVector.Text = "Encoded Vector";
            // 
            // encodedVectorTextBox
            // 
            this.encodedVectorTextBox.Location = new System.Drawing.Point(516, 50);
            this.encodedVectorTextBox.Name = "encodedVectorTextBox";
            this.encodedVectorTextBox.Size = new System.Drawing.Size(243, 22);
            this.encodedVectorTextBox.TabIndex = 6;
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.AutoSize = true;
            this.probabilityLabel.Location = new System.Drawing.Point(45, 224);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(116, 17);
            this.probabilityLabel.TabIndex = 5;
            this.probabilityLabel.Text = "Errors probability";
            // 
            // probabilityButton
            // 
            this.probabilityButton.Location = new System.Drawing.Point(274, 252);
            this.probabilityButton.Name = "probabilityButton";
            this.probabilityButton.Size = new System.Drawing.Size(75, 23);
            this.probabilityButton.TabIndex = 4;
            this.probabilityButton.Text = "Submit";
            this.probabilityButton.UseVisualStyleBackColor = true;
            // 
            // probabilityTextBox
            // 
            this.probabilityTextBox.Location = new System.Drawing.Point(48, 253);
            this.probabilityTextBox.Name = "probabilityTextBox";
            this.probabilityTextBox.Size = new System.Drawing.Size(181, 22);
            this.probabilityTextBox.TabIndex = 3;
            // 
            // enterVectorSubmit
            // 
            this.enterVectorSubmit.Location = new System.Drawing.Point(274, 140);
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
            this.enterVectorLabel.Location = new System.Drawing.Point(45, 111);
            this.enterVectorLabel.Name = "enterVectorLabel";
            this.enterVectorLabel.Size = new System.Drawing.Size(87, 17);
            this.enterVectorLabel.TabIndex = 1;
            this.enterVectorLabel.Text = "Enter Vector";
            // 
            // enterVectorTextBox
            // 
            this.enterVectorTextBox.Location = new System.Drawing.Point(48, 141);
            this.enterVectorTextBox.Name = "enterVectorTextBox";
            this.enterVectorTextBox.Size = new System.Drawing.Size(181, 22);
            this.enterVectorTextBox.TabIndex = 0;
            this.enterVectorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterVector_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 372);
            this.Controls.Add(this.vectorPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.vectorPanel.ResumeLayout(false);
            this.vectorPanel.PerformLayout();
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
        private System.Windows.Forms.Button probabilityButton;
        private System.Windows.Forms.TextBox probabilityTextBox;
        private System.Windows.Forms.Label encodedVector;
        private System.Windows.Forms.TextBox encodedVectorTextBox;
        private System.Windows.Forms.Button decodeVectorButton;
        private System.Windows.Forms.Button sendVectorButton;
        private System.Windows.Forms.TextBox receivedVectorTextBox;
        private System.Windows.Forms.Label receivedVector;
        private System.Windows.Forms.TextBox decodedVectorTextBox;
        private System.Windows.Forms.Label decodedVectorLabel;
        private System.Windows.Forms.Button parametersButton;
        private System.Windows.Forms.Label parameterRLabel;
        private System.Windows.Forms.Label parameterMLabel;
        private System.Windows.Forms.TextBox parameterRTextBox;
        private System.Windows.Forms.TextBox parameterMTextBox;
    }
}

