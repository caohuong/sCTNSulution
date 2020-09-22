namespace sCTNSolution.AppTest
{
    partial class Login
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.chkrememberme = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridresult = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttoken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngettram = new System.Windows.Forms.Button();
            this.cbhtcn = new System.Windows.Forms.ComboBox();
            this.cbkyxuathd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btngetHDbykytram = new System.Windows.Forms.Button();
            this.GetHDByky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridresult)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remember Me";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(147, 16);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(163, 20);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(147, 49);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(163, 20);
            this.txtpassword.TabIndex = 4;
            // 
            // chkrememberme
            // 
            this.chkrememberme.AutoSize = true;
            this.chkrememberme.Location = new System.Drawing.Point(147, 82);
            this.chkrememberme.Name = "chkrememberme";
            this.chkrememberme.Size = new System.Drawing.Size(15, 14);
            this.chkrememberme.TabIndex = 5;
            this.chkrememberme.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridresult
            // 
            this.gridresult.AllowUserToAddRows = false;
            this.gridresult.AllowUserToDeleteRows = false;
            this.gridresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridresult.Location = new System.Drawing.Point(3, 16);
            this.gridresult.Name = "gridresult";
            this.gridresult.ReadOnly = true;
            this.gridresult.Size = new System.Drawing.Size(1034, 338);
            this.gridresult.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridresult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 357);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txttoken
            // 
            this.txttoken.Location = new System.Drawing.Point(400, 42);
            this.txttoken.Multiline = true;
            this.txttoken.Name = "txttoken";
            this.txttoken.Size = new System.Drawing.Size(323, 53);
            this.txttoken.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Token:";
            // 
            // btngettram
            // 
            this.btngettram.Location = new System.Drawing.Point(129, 112);
            this.btngettram.Name = "btngettram";
            this.btngettram.Size = new System.Drawing.Size(75, 23);
            this.btngettram.TabIndex = 9;
            this.btngettram.Text = "Get All Tram";
            this.btngettram.UseVisualStyleBackColor = true;
            this.btngettram.Click += new System.EventHandler(this.btngettram_Click);
            // 
            // cbhtcn
            // 
            this.cbhtcn.FormattingEnabled = true;
            this.cbhtcn.Location = new System.Drawing.Point(400, 16);
            this.cbhtcn.Name = "cbhtcn";
            this.cbhtcn.Size = new System.Drawing.Size(121, 21);
            this.cbhtcn.TabIndex = 10;
            // 
            // cbkyxuathd
            // 
            this.cbkyxuathd.FormattingEnabled = true;
            this.cbkyxuathd.Location = new System.Drawing.Point(602, 15);
            this.cbkyxuathd.Name = "cbkyxuathd";
            this.cbkyxuathd.Size = new System.Drawing.Size(121, 21);
            this.cbkyxuathd.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trạm nước";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kỳ xuất";
            // 
            // btngetHDbykytram
            // 
            this.btngetHDbykytram.Location = new System.Drawing.Point(602, 102);
            this.btngetHDbykytram.Name = "btngetHDbykytram";
            this.btngetHDbykytram.Size = new System.Drawing.Size(109, 23);
            this.btngetHDbykytram.TabIndex = 14;
            this.btngetHDbykytram.Text = "GetHDByTram";
            this.btngetHDbykytram.UseVisualStyleBackColor = true;
            this.btngetHDbykytram.Click += new System.EventHandler(this.btngetHDbykytram_Click);
            // 
            // GetHDByky
            // 
            this.GetHDByky.Location = new System.Drawing.Point(448, 102);
            this.GetHDByky.Name = "GetHDByky";
            this.GetHDByky.Size = new System.Drawing.Size(81, 23);
            this.GetHDByky.TabIndex = 15;
            this.GetHDByky.Text = "GetALLByKy";
            this.GetHDByky.UseVisualStyleBackColor = true;
            this.GetHDByky.Click += new System.EventHandler(this.GetHDByky_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 498);
            this.Controls.Add(this.GetHDByky);
            this.Controls.Add(this.btngetHDbykytram);
            this.Controls.Add(this.txttoken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbkyxuathd);
            this.Controls.Add(this.cbhtcn);
            this.Controls.Add(this.btngettram);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkrememberme);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.gridresult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox chkrememberme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridresult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttoken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngettram;
        private System.Windows.Forms.ComboBox cbhtcn;
        private System.Windows.Forms.ComboBox cbkyxuathd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btngetHDbykytram;
        private System.Windows.Forms.Button GetHDByky;
    }
}