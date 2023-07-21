namespace NEA_Basketball_Statistics_System
{
    partial class SignIn
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
            this.gbSignInSI = new System.Windows.Forms.GroupBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.gbSignInSI.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSignInSI
            // 
            this.gbSignInSI.BackColor = System.Drawing.Color.MintCream;
            this.gbSignInSI.Controls.Add(this.btReturn);
            this.gbSignInSI.Controls.Add(this.btCreate);
            this.gbSignInSI.Controls.Add(this.lbPassword);
            this.gbSignInSI.Controls.Add(this.txPassword);
            this.gbSignInSI.Controls.Add(this.lbUsername);
            this.gbSignInSI.Controls.Add(this.txUsername);
            this.gbSignInSI.Location = new System.Drawing.Point(113, 47);
            this.gbSignInSI.Name = "gbSignInSI";
            this.gbSignInSI.Size = new System.Drawing.Size(439, 217);
            this.gbSignInSI.TabIndex = 2;
            this.gbSignInSI.TabStop = false;
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btReturn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(245, 152);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(130, 34);
            this.btReturn.TabIndex = 8;
            this.btReturn.Text = "Return to Menu";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btCreate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(63, 152);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(130, 34);
            this.btCreate.TabIndex = 7;
            this.btCreate.Text = "Create Account";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
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
            // txPassword
            // 
            this.txPassword.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassword.Location = new System.Drawing.Point(127, 93);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(202, 31);
            this.txPassword.TabIndex = 5;
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
            // txUsername
            // 
            this.txUsername.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsername.Location = new System.Drawing.Point(127, 37);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(202, 31);
            this.txUsername.TabIndex = 3;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(663, 322);
            this.Controls.Add(this.gbSignInSI);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.gbSignInSI.ResumeLayout(false);
            this.gbSignInSI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignInSI;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Button btReturn;
    }
}