namespace TransferPictures
{
    partial class LoginDialog
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
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Signin = new System.Windows.Forms.Button();
            this.cb_AccountType = new System.Windows.Forms.ComboBox();
            this.label_Invalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(44, 93);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(197, 26);
            this.tb_Email.TabIndex = 2;
            this.tb_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Email_KeyDown);
            this.tb_Email.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == System.Windows.Forms.Keys.Return)
                {
                    btn_Signin.PerformClick();
                }
            };
            this.tb_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Email_KeyUp);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(44, 135);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(197, 26);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            this.tb_Password.KeyDown += (sender, args) =>
            {
                if (args.KeyCode == System.Windows.Forms.Keys.Return)
                {
                    btn_Signin.PerformClick();
                }
            };
            this.tb_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyUp);
            // 
            // btn_Signin
            // 
            this.btn_Signin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Signin.Location = new System.Drawing.Point(44, 173);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(197, 28);
            this.btn_Signin.TabIndex = 4;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // cb_AccountType
            // 
            this.cb_AccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AccountType.FormattingEnabled = true;
            this.cb_AccountType.IntegralHeight = false;
            this.cb_AccountType.Location = new System.Drawing.Point(44, 22);
            this.cb_AccountType.Name = "cb_AccountType";
            this.cb_AccountType.Size = new System.Drawing.Size(197, 28);
            this.cb_AccountType.TabIndex = 5;
            // 
            // label_Invalid
            // 
            this.label_Invalid.AutoSize = true;
            this.label_Invalid.ForeColor = System.Drawing.Color.Red;
            this.label_Invalid.Location = new System.Drawing.Point(44, 67);
            this.label_Invalid.Name = "label_Invalid";
            this.label_Invalid.Size = new System.Drawing.Size(37, 13);
            this.label_Invalid.TabIndex = 6;
            this.label_Invalid.Text = "invalid";
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.label_Invalid);
            this.Controls.Add(this.cb_AccountType);
            this.Controls.Add(this.btn_Signin);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Email);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Signin;
        private System.Windows.Forms.ComboBox cb_AccountType;
        private System.Windows.Forms.Label label_Invalid;
    }
}