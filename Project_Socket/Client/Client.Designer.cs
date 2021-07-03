
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
            this.label3 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buy_cash = new System.Windows.Forms.Label();
            this.buy_transfer = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Label();
            this.money_type = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameofbank = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.first.Size = new System.Drawing.Size(166, 20);
            this.first.TabIndex = 4;
            this.first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
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
            this.pressToConnect.Location = new System.Drawing.Point(16, 38);
            this.pressToConnect.Name = "pressToConnect";
            this.pressToConnect.Size = new System.Drawing.Size(123, 38);
            this.pressToConnect.TabIndex = 9;
            this.pressToConnect.Text = "Connect";
            this.pressToConnect.UseMnemonic = false;
            this.pressToConnect.UseVisualStyleBackColor = true;
            this.pressToConnect.Click += new System.EventHandler(this.pressToConnect_Click);
            // 
            // statusConnect
            // 
            this.statusConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.statusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConnect.Location = new System.Drawing.Point(15, 97);
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.Size = new System.Drawing.Size(275, 20);
            this.statusConnect.TabIndex = 10;
            this.statusConnect.Text = "Not connected";
            this.statusConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.listRegion.Location = new System.Drawing.Point(4, 16);
            this.listRegion.Name = "listRegion";
            this.listRegion.Size = new System.Drawing.Size(169, 24);
            this.listRegion.TabIndex = 17;
            this.listRegion.SelectedIndexChanged += new System.EventHandler(this.listRegion_SelectedIndexChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Enabled = false;
            this.searchbutton.Location = new System.Drawing.Point(178, 10);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(85, 34);
            this.searchbutton.TabIndex = 18;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchResult
            // 
            this.searchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult.Location = new System.Drawing.Point(4, 55);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(259, 20);
            this.searchResult.TabIndex = 19;
            this.searchResult.Text = "Search something";
            this.searchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchResult.Click += new System.EventHandler(this.searchResult_Click);
            // 
            // signStatus
            // 
            this.signStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signStatus.Location = new System.Drawing.Point(12, 262);
            this.signStatus.Name = "signStatus";
            this.signStatus.Size = new System.Drawing.Size(278, 20);
            this.signStatus.TabIndex = 20;
            this.signStatus.Text = "Not connected";
            this.signStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signStatus.Click += new System.EventHandler(this.signStatus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sell: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buy transfer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Buy cash: ";
            // 
            // buy_cash
            // 
            this.buy_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_cash.Location = new System.Drawing.Point(149, 144);
            this.buy_cash.Name = "buy_cash";
            this.buy_cash.Size = new System.Drawing.Size(114, 20);
            this.buy_cash.TabIndex = 24;
            this.buy_cash.Text = "0.00";
            this.buy_cash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buy_transfer
            // 
            this.buy_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_transfer.Location = new System.Drawing.Point(149, 174);
            this.buy_transfer.Name = "buy_transfer";
            this.buy_transfer.Size = new System.Drawing.Size(114, 20);
            this.buy_transfer.TabIndex = 25;
            this.buy_transfer.Text = "0.00";
            this.buy_transfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sell
            // 
            this.sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.Location = new System.Drawing.Point(149, 204);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(114, 20);
            this.sell.TabIndex = 26;
            this.sell.Text = "0.00";
            this.sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // money_type
            // 
            this.money_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_type.Location = new System.Drawing.Point(149, 114);
            this.money_type.Name = "money_type";
            this.money_type.Size = new System.Drawing.Size(114, 20);
            this.money_type.TabIndex = 28;
            this.money_type.Text = "###";
            this.money_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Type: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameofbank);
            this.panel1.Controls.Add(this.bankName);
            this.panel1.Controls.Add(this.listRegion);
            this.panel1.Controls.Add(this.money_type);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.searchResult);
            this.panel1.Controls.Add(this.sell);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buy_transfer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buy_cash);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(16, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 236);
            this.panel1.TabIndex = 29;
            // 
            // nameofbank
            // 
            this.nameofbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofbank.Location = new System.Drawing.Point(149, 88);
            this.nameofbank.Name = "nameofbank";
            this.nameofbank.Size = new System.Drawing.Size(114, 20);
            this.nameofbank.TabIndex = 30;
            this.nameofbank.Text = "###";
            this.nameofbank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankName.Location = new System.Drawing.Point(4, 88);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(50, 20);
            this.bankName.TabIndex = 29;
            this.bankName.Text = "Bank:";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(152, 38);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(123, 38);
            this.disconnectButton.TabIndex = 30;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseMnemonic = false;
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 533);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signStatus);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getpassword);
            this.Controls.Add(this.getusername);
            this.Controls.Add(this.statusConnect);
            this.Controls.Add(this.pressToConnect);
            this.Controls.Add(this.getport);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label buy_cash;
        private System.Windows.Forms.Label buy_transfer;
        private System.Windows.Forms.Label sell;
        private System.Windows.Forms.Label money_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameofbank;
        private System.Windows.Forms.Label bankName;
        private System.Windows.Forms.Button disconnectButton;
    }
}

