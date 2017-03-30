namespace OrderManagers
{
    partial class CreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.createUser = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(179, 39);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(179, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(170, 283);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(75, 23);
            this.createUser.TabIndex = 7;
            this.createUser.Text = "Create";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(179, 190);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxAdmin.TabIndex = 9;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(179, 133);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtUserPassword.TabIndex = 10;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 385);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.TextBox txtUserPassword;
    }
}