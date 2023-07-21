namespace NEA_Basketball_Statistics_System
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btSignIn = new System.Windows.Forms.Button();
            this.gbSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(27, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(282, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Basketball Statistics System";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // gbSignIn
            // 
            this.gbSignIn.BackColor = System.Drawing.Color.MintCream;
            this.gbSignIn.Controls.Add(this.btLogIn);
            this.gbSignIn.Controls.Add(this.lbPassword);
            this.gbSignIn.Controls.Add(this.txPassword);
            this.gbSignIn.Controls.Add(this.lbUsername);
            this.gbSignIn.Controls.Add(this.txUsername);
            this.gbSignIn.Location = new System.Drawing.Point(283, 132);
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.Size = new System.Drawing.Size(439, 217);
            this.gbSignIn.TabIndex = 1;
            this.gbSignIn.TabStop = false;
            // 
            // txUsername
            // 
            this.txUsername.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsername.Location = new System.Drawing.Point(127, 29);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(202, 31);
            this.txUsername.TabIndex = 3;
            this.txUsername.TextChanged += new System.EventHandler(this.txUsername_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(23, 37);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 20);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username";
            // 
            // txPassword
            // 
            this.txPassword.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassword.Location = new System.Drawing.Point(127, 93);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(202, 31);
            this.txPassword.TabIndex = 5;
            this.txPassword.TextChanged += new System.EventHandler(this.txPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(23, 93);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(78, 20);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // btLogIn
            // 
            this.btLogIn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btLogIn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Location = new System.Drawing.Point(183, 148);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(81, 34);
            this.btLogIn.TabIndex = 7;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = false;
            this.btLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(546, 379);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(176, 49);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.Location = new System.Drawing.Point(283, 380);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(176, 49);
            this.btSignIn.TabIndex = 13;
            this.btSignIn.Text = "Sign In";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(990, 551);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.gbSignIn);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSignIn;
    }
}

