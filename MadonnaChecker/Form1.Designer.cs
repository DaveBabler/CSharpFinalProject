namespace MadonnaChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ballDoneImage = new System.Windows.Forms.PictureBox();
            this.ballOpeningImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ballDoneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballOpeningImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sharp Unity Extrabold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(349, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verify Credentials";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Sharp Unity Extrabold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.UserLabel.Location = new System.Drawing.Point(260, 366);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(96, 20);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "User Name";
            this.UserLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserNameBox
            // 
            this.UserNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(74)))));
            this.UserNameBox.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold);
            this.UserNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.UserNameBox.Location = new System.Drawing.Point(374, 362);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(145, 28);
            this.UserNameBox.TabIndex = 3;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(74)))));
            this.PasswordBox.Font = new System.Drawing.Font("Semplicita", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(112)))));
            this.PasswordBox.Location = new System.Drawing.Point(374, 408);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(145, 28);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Sharp Unity Extrabold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.PassLabel.Location = new System.Drawing.Point(267, 412);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(89, 20);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HIDDEN ANGRY BAD PASSWORD LABEL";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ballDoneImage
            // 
            this.ballDoneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ballDoneImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ballDoneImage.ErrorImage")));
            this.ballDoneImage.Image = ((System.Drawing.Image)(resources.GetObject("ballDoneImage.Image")));
            this.ballDoneImage.Location = new System.Drawing.Point(-2, -4);
            this.ballDoneImage.Name = "ballDoneImage";
            this.ballDoneImage.Size = new System.Drawing.Size(907, 533);
            this.ballDoneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballDoneImage.TabIndex = 8;
            this.ballDoneImage.TabStop = false;
            // 
            // ballOpeningImage
            // 
            this.ballOpeningImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballOpeningImage.BackgroundImage")));
            this.ballOpeningImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ballOpeningImage.Location = new System.Drawing.Point(-2, -4);
            this.ballOpeningImage.Name = "ballOpeningImage";
            this.ballOpeningImage.Size = new System.Drawing.Size(916, 543);
            this.ballOpeningImage.TabIndex = 9;
            this.ballOpeningImage.TabStop = false;
            this.ballOpeningImage.Visible = false;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(915, 540);
            this.Controls.Add(this.ballOpeningImage);
            this.Controls.Add(this.ballDoneImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ballDoneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballOpeningImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ballDoneImage;
        private System.Windows.Forms.PictureBox ballOpeningImage;
    }
}

