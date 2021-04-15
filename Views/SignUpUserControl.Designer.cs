using System.ComponentModel;

namespace filmhub.Views
{
    partial class SignUpUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.privacyLabel = new System.Windows.Forms.Label();
            this.andLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new filmhub.Views.RoundedTextBox();
            this.termsLabel = new System.Windows.Forms.Label();
            this.byClickingLabel = new System.Windows.Forms.Label();
            this.signUpButton = new filmhub.Views.RoundedButton();
            this.passwordTextBox = new filmhub.Views.RoundedTextBox();
            this.emailTextBox = new filmhub.Views.RoundedTextBox();
            this.signInLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.privacyLabel);
            this.menuPanel.Controls.Add(this.andLabel);
            this.menuPanel.Controls.Add(this.confirmPasswordTextBox);
            this.menuPanel.Controls.Add(this.termsLabel);
            this.menuPanel.Controls.Add(this.byClickingLabel);
            this.menuPanel.Controls.Add(this.signUpButton);
            this.menuPanel.Controls.Add(this.passwordTextBox);
            this.menuPanel.Controls.Add(this.emailTextBox);
            this.menuPanel.Controls.Add(this.signInLabel);
            this.menuPanel.Location = new System.Drawing.Point(375, 38);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(532, 522);
            this.menuPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.Image = global::filmhub.Properties.Resources.back;
            this.homeButton.Location = new System.Drawing.Point(55, 45);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(27, 47);
            this.homeButton.TabIndex = 10;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            this.homeButton.MouseHover += new System.EventHandler(this.homeButton_MouseHover);
            // 
            // privacyLabel
            // 
            this.privacyLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.privacyLabel.ForeColor = System.Drawing.Color.White;
            this.privacyLabel.Location = new System.Drawing.Point(280, 474);
            this.privacyLabel.Name = "privacyLabel";
            this.privacyLabel.Size = new System.Drawing.Size(143, 33);
            this.privacyLabel.TabIndex = 9;
            this.privacyLabel.Text = "Privacy Policy";
            this.privacyLabel.MouseLeave += new System.EventHandler(this.privacyLabel_MouseLeave);
            this.privacyLabel.MouseHover += new System.EventHandler(this.privacyLabel_MouseHover);
            // 
            // andLabel
            // 
            this.andLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.andLabel.Location = new System.Drawing.Point(245, 474);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(47, 32);
            this.andLabel.TabIndex = 8;
            this.andLabel.Text = "and";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(55, 291);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(413, 43);
            this.confirmPasswordTextBox.TabIndex = 7;
            this.confirmPasswordTextBox.TabStop = false;
            this.confirmPasswordTextBox.Text = " Confirm password";
            this.confirmPasswordTextBox.Enter += new System.EventHandler(this.confirmPasswordTextBox_Enter);
            this.confirmPasswordTextBox.Leave += new System.EventHandler(this.confirmPasswordTextBox_Leave);
            // 
            // termsLabel
            // 
            this.termsLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.termsLabel.ForeColor = System.Drawing.Color.White;
            this.termsLabel.Location = new System.Drawing.Point(55, 474);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(217, 33);
            this.termsLabel.TabIndex = 6;
            this.termsLabel.Text = "Terms and Conditions";
            this.termsLabel.MouseLeave += new System.EventHandler(this.TermsLabel_MouseLeave);
            this.termsLabel.MouseHover += new System.EventHandler(this.signUpLabel_MouseHover);
            // 
            // byClickingLabel
            // 
            this.byClickingLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.byClickingLabel.Location = new System.Drawing.Point(55, 447);
            this.byClickingLabel.Name = "byClickingLabel";
            this.byClickingLabel.Size = new System.Drawing.Size(388, 60);
            this.byClickingLabel.TabIndex = 5;
            this.byClickingLabel.Text = "By clicking the Sign up button you agree to our";
            // 
            // signUpButton
            // 
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(55, 367);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(413, 56);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.TabStop = false;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.passwordTextBox.Location = new System.Drawing.Point(55, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(413, 43);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = " Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.emailTextBox.Location = new System.Drawing.Point(55, 149);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(413, 43);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TabStop = false;
            this.emailTextBox.Text = " E-mail";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // signInLabel
            // 
            this.signInLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.signInLabel.ForeColor = System.Drawing.Color.White;
            this.signInLabel.Location = new System.Drawing.Point(0, 38);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(532, 58);
            this.signInLabel.TabIndex = 0;
            this.signInLabel.Text = "Sign Up";
            this.signInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::filmhub.Properties.Resources.background;
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Name = "SignUpUserControl";
            this.Size = new System.Drawing.Size(1264, 595);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.homeButton)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox homeButton;

        private filmhub.Views.RoundedButton signUpButton;

        private System.Windows.Forms.Label privacyLabel;

        private System.Windows.Forms.Label andLabel;

        private RoundedTextBox confirmPasswordTextBox;

        private RoundedTextBox passwordTextBox;

        private System.Windows.Forms.Label termsLabel;

        private System.Windows.Forms.Label byClickingLabel;
        
        private RoundedButton signInButton;

        private RoundedTextBox emailTextBox;

        private System.Windows.Forms.Label signInLabel;
        
        private System.Windows.Forms.Panel menuPanel;

        #endregion
    }
}