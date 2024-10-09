namespace CarroApp
{
    partial class FrmLogin
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.btn_register2 = new System.Windows.Forms.Button();
            this.btn_login2 = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.PlayerOne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(90, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(90, 133);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 1;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(31, 193);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(115, 193);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_name2
            // 
            this.txt_name2.Location = new System.Drawing.Point(366, 89);
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(100, 20);
            this.txt_name2.TabIndex = 4;
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(366, 130);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '*';
            this.txt_pass2.Size = new System.Drawing.Size(100, 20);
            this.txt_pass2.TabIndex = 5;
            // 
            // btn_register2
            // 
            this.btn_register2.Location = new System.Drawing.Point(293, 193);
            this.btn_register2.Name = "btn_register2";
            this.btn_register2.Size = new System.Drawing.Size(75, 23);
            this.btn_register2.TabIndex = 6;
            this.btn_register2.Text = "Register";
            this.btn_register2.UseVisualStyleBackColor = true;
            this.btn_register2.Click += new System.EventHandler(this.btn_register2_Click);
            // 
            // btn_login2
            // 
            this.btn_login2.Location = new System.Drawing.Point(400, 193);
            this.btn_login2.Name = "btn_login2";
            this.btn_login2.Size = new System.Drawing.Size(75, 23);
            this.btn_login2.TabIndex = 7;
            this.btn_login2.Text = "Login";
            this.btn_login2.UseVisualStyleBackColor = true;
            this.btn_login2.Click += new System.EventHandler(this.btn_login2_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(210, 274);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // PlayerOne
            // 
            this.PlayerOne.AutoSize = true;
            this.PlayerOne.Location = new System.Drawing.Point(66, 55);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(56, 13);
            this.PlayerOne.TabIndex = 9;
            this.PlayerOne.Text = "PlayerOne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "PlayerTwo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "PassWord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "PassWord";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(38, 243);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(13, 13);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Text = "..";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 320);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerOne);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_login2);
            this.Controls.Add(this.btn_register2);
            this.Controls.Add(this.txt_pass2);
            this.Controls.Add(this.txt_name2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Button btn_register2;
        private System.Windows.Forms.Button btn_login2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label PlayerOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_status;
    }
}