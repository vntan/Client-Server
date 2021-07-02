
namespace Client
{
    partial class Client
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
            this.dot1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.fourth = new System.Windows.Forms.TextBox();
            this.third = new System.Windows.Forms.TextBox();
            this.getport = new System.Windows.Forms.TextBox();
            this.pressToConnect = new System.Windows.Forms.Button();
            this.statusConnect = new System.Windows.Forms.Label();
            this.getusername = new System.Windows.Forms.TextBox();
            this.getpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signupbutton = new System.Windows.Forms.Button();
            this.signinbutton = new System.Windows.Forms.Button();
            this.listRegion = new System.Windows.Forms.ComboBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.Label();
            this.signStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dot1
            // 
            this.dot1.AutoSize = true;
            this.dot1.Location = new System.Drawing.Point(64, 19);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(10, 13);
            this.dot1.TabIndex = 0;
            this.dot1.Text = ".";
            this.dot1.Click += new System.EventHandler(this.dot1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // first
            // 
            this.first.AcceptsTab = true;
            this.first.Location = new System.Drawing.Point(33, 12);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(25, 20);
            this.first.TabIndex = 4;
            this.first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // second
            // 
            this.second.AcceptsTab = true;
            this.second.Location = new System.Drawing.Point(80, 12);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(25, 20);
            this.second.TabIndex = 5;
            this.second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // fourth
            // 
            this.fourth.AcceptsTab = true;
            this.fourth.Location = new System.Drawing.Point(174, 12);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(25, 20);
            this.fourth.TabIndex = 7;
            this.fourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fourth.TextChanged += new System.EventHandler(this.fourth_TextChanged);
            // 
            // third
            // 
            this.third.AcceptsTab = true;
            this.third.Location = new System.Drawing.Point(127, 12);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(25, 20);
            this.third.TabIndex = 6;
            this.third.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.third.TextChanged += new System.EventHandler(this.third_TextChanged);
            // 
            // getport
            // 
            this.getport.AcceptsTab = true;
            this.getport.Location = new System.Drawing.Point(221, 12);
            this.getport.Name = "getport";
            this.getport.Size = new System.Drawing.Size(40, 20);
            this.getport.TabIndex = 8;
            this.getport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getport.TextChanged += new System.EventHandler(this.getport_TextChanged);
            // 
            // pressToConnect
            // 
            this.pressToConnect.Location = new System.Drawing.Point(50, 47);
            this.pressToConnect.Name = "pressToConnect";
            this.pressToConnect.Size = new System.Drawing.Size(193, 38);
            this.pressToConnect.TabIndex = 9;
            this.pressToConnect.Text = "Connect";
            this.pressToConnect.UseMnemonic = false;
            this.pressToConnect.UseVisualStyleBackColor = true;
            this.pressToConnect.Click += new System.EventHandler(this.pressToConnect_Click);
            // 
            // statusConnect
            // 
            this.statusConnect.AutoSize = true;
            this.statusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConnect.Location = new System.Drawing.Point(86, 97);
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.Size = new System.Drawing.Size(113, 20);
            this.statusConnect.TabIndex = 10;
            this.statusConnect.Text = "Not connected";
            this.statusConnect.Click += new System.EventHandler(this.label4_Click);
            // 
            // getusername
            // 
            this.getusername.Enabled = false;
            this.getusername.Location = new System.Drawing.Point(114, 145);
            this.getusername.Name = "getusername";
            this.getusername.Size = new System.Drawing.Size(161, 20);
            this.getusername.TabIndex = 11;
            // 
            // getpassword
            // 
            this.getpassword.Enabled = false;
            this.getpassword.Location = new System.Drawing.Point(114, 175);
            this.getpassword.Name = "getpassword";
            this.getpassword.Size = new System.Drawing.Size(161, 20);
            this.getpassword.TabIndex = 12;
            this.getpassword.UseSystemPasswordChar = true;
            this.getpassword.TextChanged += new System.EventHandler(this.getpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.Enabled = false;
            this.signupbutton.Location = new System.Drawing.Point(161, 213);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(114, 37);
            this.signupbutton.TabIndex = 15;
            this.signupbutton.Text = "Sign up";
            this.signupbutton.UseMnemonic = false;
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // signinbutton
            // 
            this.signinbutton.Enabled = false;
            this.signinbutton.Location = new System.Drawing.Point(15, 213);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(124, 37);
            this.signinbutton.TabIndex = 16;
            this.signinbutton.Text = "Sign in";
            this.signinbutton.UseMnemonic = false;
            this.signinbutton.UseVisualStyleBackColor = true;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // listRegion
            // 
            this.listRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRegion.Enabled = false;
            this.listRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRegion.FormattingEnabled = true;
            this.listRegion.Items.AddRange(new object[] {
            "vnd",
            "eur",
            "rub",
            "yen",
            "ndt"});
            this.listRegion.Location = new System.Drawing.Point(20, 310);
            this.listRegion.Name = "listRegion";
            this.listRegion.Size = new System.Drawing.Size(116, 24);
            this.listRegion.TabIndex = 17;
            this.listRegion.SelectedIndexChanged += new System.EventHandler(this.listRegion_SelectedIndexChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Enabled = false;
            this.searchbutton.Location = new System.Drawing.Point(174, 304);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(87, 34);
            this.searchbutton.TabIndex = 18;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchResult
            // 
            this.searchResult.AutoSize = true;
            this.searchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult.Location = new System.Drawing.Point(12, 345);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(133, 20);
            this.searchResult.TabIndex = 19;
            this.searchResult.Text = "Seach something";
            this.searchResult.Click += new System.EventHandler(this.searchResult_Click);
            // 
            // signStatus
            // 
            this.signStatus.AutoSize = true;
            this.signStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signStatus.Location = new System.Drawing.Point(84, 262);
            this.signStatus.Name = "signStatus";
            this.signStatus.Size = new System.Drawing.Size(113, 20);
            this.signStatus.TabIndex = 20;
            this.signStatus.Text = "Not connected";
            this.signStatus.Click += new System.EventHandler(this.signStatus_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 383);
            this.Controls.Add(this.signStatus);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.listRegion);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getpassword);
            this.Controls.Add(this.getusername);
            this.Controls.Add(this.statusConnect);
            this.Controls.Add(this.pressToConnect);
            this.Controls.Add(this.getport);
            this.Controls.Add(this.third);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dot1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox fourth;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox getport;
        private System.Windows.Forms.Button pressToConnect;
        private System.Windows.Forms.Label statusConnect;
        private System.Windows.Forms.TextBox getusername;
        private System.Windows.Forms.TextBox getpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.ComboBox listRegion;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label searchResult;
        private System.Windows.Forms.Label signStatus;
    }
}

