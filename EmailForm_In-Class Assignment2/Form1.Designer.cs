namespace EmailForm_In_Class_Assignment2
{
    partial class sendEmailForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendEmailForm));
            this.emailGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.emailSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.hidePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SSLCheckBox = new System.Windows.Forms.CheckBox();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.hotmailRadioButton = new System.Windows.Forms.RadioButton();
            this.googleRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SentButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.emailGroupBox.SuspendLayout();
            this.emailSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailGroupBox
            // 
            this.emailGroupBox.Controls.Add(this.label5);
            this.emailGroupBox.Controls.Add(this.SubjectLabel);
            this.emailGroupBox.Controls.Add(this.FromLabel);
            this.emailGroupBox.Controls.Add(this.ToLabel);
            this.emailGroupBox.Controls.Add(this.messageRichTextBox);
            this.emailGroupBox.Controls.Add(this.subjectTextBox);
            this.emailGroupBox.Controls.Add(this.toTextBox);
            this.emailGroupBox.Controls.Add(this.fromTextBox);
            this.emailGroupBox.Location = new System.Drawing.Point(12, 34);
            this.emailGroupBox.Name = "emailGroupBox";
            this.emailGroupBox.Size = new System.Drawing.Size(286, 292);
            this.emailGroupBox.TabIndex = 0;
            this.emailGroupBox.TabStop = false;
            this.emailGroupBox.Text = "E-Mail Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(24, 111);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(46, 13);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Subject:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(24, 42);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(36, 13);
            this.FromLabel.TabIndex = 2;
            this.FromLabel.Text = "From: ";
            this.FromLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(24, 74);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(23, 13);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "To:";
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Location = new System.Drawing.Point(27, 141);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(209, 135);
            this.messageRichTextBox.TabIndex = 3;
            this.messageRichTextBox.Text = "";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(94, 104);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(142, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(94, 71);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(142, 20);
            this.toTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.toTextBox, "Enter recipient email");
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(94, 45);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(142, 20);
            this.fromTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.fromTextBox, "Enter your email");
            // 
            // emailSettingsGroupBox
            // 
            this.emailSettingsGroupBox.Controls.Add(this.logoPictureBox);
            this.emailSettingsGroupBox.Controls.Add(this.hidePasswordCheckBox);
            this.emailSettingsGroupBox.Controls.Add(this.SSLCheckBox);
            this.emailSettingsGroupBox.Controls.Add(this.customRadioButton);
            this.emailSettingsGroupBox.Controls.Add(this.hotmailRadioButton);
            this.emailSettingsGroupBox.Controls.Add(this.googleRadioButton);
            this.emailSettingsGroupBox.Controls.Add(this.passwordTextBox);
            this.emailSettingsGroupBox.Controls.Add(this.usernameTextBox);
            this.emailSettingsGroupBox.Controls.Add(this.portTextBox);
            this.emailSettingsGroupBox.Controls.Add(this.passwordLabel);
            this.emailSettingsGroupBox.Controls.Add(this.usernameLabel);
            this.emailSettingsGroupBox.Controls.Add(this.portLabel);
            this.emailSettingsGroupBox.Controls.Add(this.serverLabel);
            this.emailSettingsGroupBox.Controls.Add(this.label6);
            this.emailSettingsGroupBox.Controls.Add(this.label2);
            this.emailSettingsGroupBox.Controls.Add(this.serverTextBox);
            this.emailSettingsGroupBox.Location = new System.Drawing.Point(304, 34);
            this.emailSettingsGroupBox.Name = "emailSettingsGroupBox";
            this.emailSettingsGroupBox.Size = new System.Drawing.Size(342, 276);
            this.emailSettingsGroupBox.TabIndex = 1;
            this.emailSettingsGroupBox.TabStop = false;
            this.emailSettingsGroupBox.Text = "Server Settings";
            this.toolTip1.SetToolTip(this.emailSettingsGroupBox, "Enter the subject");
            this.emailSettingsGroupBox.Enter += new System.EventHandler(this.emailSettingsGroupBox_Enter);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.ErrorImage = null;
            this.logoPictureBox.InitialImage = global::EmailForm_In_Class_Assignment2.Properties.Resources.Google;
            this.logoPictureBox.Location = new System.Drawing.Point(245, 8);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(91, 66);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hidePasswordCheckBox
            // 
            this.hidePasswordCheckBox.AutoSize = true;
            this.hidePasswordCheckBox.Checked = true;
            this.hidePasswordCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hidePasswordCheckBox.Location = new System.Drawing.Point(143, 223);
            this.hidePasswordCheckBox.Name = "hidePasswordCheckBox";
            this.hidePasswordCheckBox.Size = new System.Drawing.Size(97, 17);
            this.hidePasswordCheckBox.TabIndex = 8;
            this.hidePasswordCheckBox.Text = "Hide Password";
            this.hidePasswordCheckBox.UseVisualStyleBackColor = true;
            this.hidePasswordCheckBox.CheckedChanged += new System.EventHandler(this.hidePasswordCheckBox_CheckedChanged);
            // 
            // SSLCheckBox
            // 
            this.SSLCheckBox.AutoSize = true;
            this.SSLCheckBox.Location = new System.Drawing.Point(144, 117);
            this.SSLCheckBox.Name = "SSLCheckBox";
            this.SSLCheckBox.Size = new System.Drawing.Size(82, 17);
            this.SSLCheckBox.TabIndex = 5;
            this.SSLCheckBox.Text = "Enable SSL";
            this.SSLCheckBox.UseVisualStyleBackColor = true;
            this.SSLCheckBox.CheckedChanged += new System.EventHandler(this.SSLCheckBox_CheckedChanged);
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Location = new System.Drawing.Point(164, 20);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(60, 17);
            this.customRadioButton.TabIndex = 2;
            this.customRadioButton.TabStop = true;
            this.customRadioButton.Text = "Custom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            this.customRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // hotmailRadioButton
            // 
            this.hotmailRadioButton.AutoSize = true;
            this.hotmailRadioButton.Location = new System.Drawing.Point(86, 20);
            this.hotmailRadioButton.Name = "hotmailRadioButton";
            this.hotmailRadioButton.Size = new System.Drawing.Size(60, 17);
            this.hotmailRadioButton.TabIndex = 1;
            this.hotmailRadioButton.TabStop = true;
            this.hotmailRadioButton.Text = "Hotmail";
            this.hotmailRadioButton.UseVisualStyleBackColor = true;
            this.hotmailRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // googleRadioButton
            // 
            this.googleRadioButton.AutoSize = true;
            this.googleRadioButton.Location = new System.Drawing.Point(9, 20);
            this.googleRadioButton.Name = "googleRadioButton";
            this.googleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.googleRadioButton.TabIndex = 0;
            this.googleRadioButton.TabStop = true;
            this.googleRadioButton.Text = "Google";
            this.googleRadioButton.UseVisualStyleBackColor = true;
            this.googleRadioButton.CheckedChanged += new System.EventHandler(this.googleRadioButton_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(143, 197);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.passwordTextBox, "Enter your password");
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(143, 160);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.usernameTextBox, "Enter your username");
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(143, 91);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.portTextBox, "Put in the port");
            this.portTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 193);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 163);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(6, 87);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port:";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(6, 61);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(68, 13);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server/Host:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(143, 62);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(100, 20);
            this.serverTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.serverTextBox, "Put in the server");
            this.serverTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(415, 326);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear Fields";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SentButton
            // 
            this.SentButton.Location = new System.Drawing.Point(334, 325);
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(75, 23);
            this.SentButton.TabIndex = 2;
            this.SentButton.Text = "&Send Email";
            this.SentButton.UseVisualStyleBackColor = true;
            this.SentButton.Click += new System.EventHandler(this.SentButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(496, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sendEmailForm
            // 
            this.AcceptButton = this.SentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(658, 382);
            this.Controls.Add(this.SentButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.emailSettingsGroupBox);
            this.Controls.Add(this.emailGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sendEmailForm";
            this.Text = " Sent E-mail";
            this.Load += new System.EventHandler(this.sendEmailForm_Load);
            this.emailGroupBox.ResumeLayout(false);
            this.emailGroupBox.PerformLayout();
            this.emailSettingsGroupBox.ResumeLayout(false);
            this.emailSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox emailGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.GroupBox emailSettingsGroupBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.RadioButton hotmailRadioButton;
        private System.Windows.Forms.RadioButton googleRadioButton;
        private System.Windows.Forms.CheckBox hidePasswordCheckBox;
        private System.Windows.Forms.CheckBox SSLCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button SentButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

