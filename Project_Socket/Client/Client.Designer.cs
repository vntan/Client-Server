
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
            this.pnServer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusConnect = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnResearch = new System.Windows.Forms.Panel();
            this.lbResearch = new System.Windows.Forms.Label();
            this.lbBank = new System.Windows.Forms.Label();
            this.bankName = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.lbMoneyType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSearchResult = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbBuyTransfer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBuyCash = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnServer.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.pnResearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnServer
            // 
            this.pnServer.Controls.Add(this.label1);
            this.pnServer.Controls.Add(this.btnDisconnect);
            this.pnServer.Controls.Add(this.statusConnect);
            this.pnServer.Controls.Add(this.btnConnect);
            this.pnServer.Controls.Add(this.txtPort);
            this.pnServer.Controls.Add(this.txtIP);
            this.pnServer.Controls.Add(this.label3);
            this.pnServer.Location = new System.Drawing.Point(12, 3);
            this.pnServer.Name = "pnServer";
            this.pnServer.Size = new System.Drawing.Size(278, 139);
            this.pnServer.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Connect to server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(152, 65);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 35);
            this.btnDisconnect.TabIndex = 36;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseMnemonic = false;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // statusConnect
            // 
            this.statusConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.statusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConnect.Location = new System.Drawing.Point(4, 113);
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.Size = new System.Drawing.Size(266, 20);
            this.statusConnect.TabIndex = 35;
            this.statusConnect.Text = "Not connected";
            this.statusConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 65);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 35);
            this.btnConnect.TabIndex = 34;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseMnemonic = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.AcceptsTab = true;
            this.txtPort.Location = new System.Drawing.Point(201, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(67, 20);
            this.txtPort.TabIndex = 33;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIP
            // 
            this.txtIP.AcceptsTab = true;
            this.txtIP.Location = new System.Drawing.Point(4, 39);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(175, 20);
            this.txtIP.TabIndex = 32;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = ":";
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.btnSignIn);
            this.pnLogin.Controls.Add(this.btnSignUp);
            this.pnLogin.Controls.Add(this.label5);
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.txtUserName);
            this.pnLogin.Location = new System.Drawing.Point(12, 148);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(278, 147);
            this.pnLogin.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Enabled = false;
            this.btnSignIn.Location = new System.Drawing.Point(4, 96);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(124, 37);
            this.btnSignIn.TabIndex = 22;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseMnemonic = false;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Enabled = false;
            this.btnSignUp.Location = new System.Drawing.Point(154, 96);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(114, 37);
            this.btnSignUp.TabIndex = 21;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseMnemonic = false;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(93, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(95, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 20);
            this.txtUserName.TabIndex = 17;
            // 
            // pnResearch
            // 
            this.pnResearch.Controls.Add(this.lbResearch);
            this.pnResearch.Controls.Add(this.lbBank);
            this.pnResearch.Controls.Add(this.bankName);
            this.pnResearch.Controls.Add(this.cbCurrency);
            this.pnResearch.Controls.Add(this.lbMoneyType);
            this.pnResearch.Controls.Add(this.label10);
            this.pnResearch.Controls.Add(this.lbSearchResult);
            this.pnResearch.Controls.Add(this.sell);
            this.pnResearch.Controls.Add(this.label6);
            this.pnResearch.Controls.Add(this.lbBuyTransfer);
            this.pnResearch.Controls.Add(this.label7);
            this.pnResearch.Controls.Add(this.lbBuyCash);
            this.pnResearch.Controls.Add(this.label8);
            this.pnResearch.Location = new System.Drawing.Point(13, 148);
            this.pnResearch.Name = "pnResearch";
            this.pnResearch.Size = new System.Drawing.Size(278, 274);
            this.pnResearch.TabIndex = 33;
            this.pnResearch.Visible = false;
            // 
            // lbResearch
            // 
            this.lbResearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResearch.Location = new System.Drawing.Point(4, 6);
            this.lbResearch.Name = "lbResearch";
            this.lbResearch.Size = new System.Drawing.Size(271, 31);
            this.lbResearch.TabIndex = 38;
            this.lbResearch.Text = "Research";
            this.lbResearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBank
            // 
            this.lbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBank.Location = new System.Drawing.Point(153, 121);
            this.lbBank.Name = "lbBank";
            this.lbBank.Size = new System.Drawing.Size(114, 20);
            this.lbBank.TabIndex = 30;
            this.lbBank.Text = "###";
            this.lbBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankName.Location = new System.Drawing.Point(8, 121);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(50, 20);
            this.bankName.TabIndex = 29;
            this.bankName.Text = "Bank:";
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.Enabled = false;
            this.cbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(8, 49);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(169, 24);
            this.cbCurrency.TabIndex = 17;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            // 
            // lbMoneyType
            // 
            this.lbMoneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyType.Location = new System.Drawing.Point(153, 147);
            this.lbMoneyType.Name = "lbMoneyType";
            this.lbMoneyType.Size = new System.Drawing.Size(114, 20);
            this.lbMoneyType.TabIndex = 28;
            this.lbMoneyType.Text = "###";
            this.lbMoneyType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Type: ";
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchResult.Location = new System.Drawing.Point(9, 86);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(259, 20);
            this.lbSearchResult.TabIndex = 19;
            this.lbSearchResult.Text = "Search something";
            this.lbSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sell
            // 
            this.sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.Location = new System.Drawing.Point(153, 237);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(114, 20);
            this.sell.TabIndex = 26;
            this.sell.Text = "0.00";
            this.sell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sell: ";
            // 
            // lbBuyTransfer
            // 
            this.lbBuyTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuyTransfer.Location = new System.Drawing.Point(153, 207);
            this.lbBuyTransfer.Name = "lbBuyTransfer";
            this.lbBuyTransfer.Size = new System.Drawing.Size(114, 20);
            this.lbBuyTransfer.TabIndex = 25;
            this.lbBuyTransfer.Text = "0.00";
            this.lbBuyTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buy transfer:";
            // 
            // lbBuyCash
            // 
            this.lbBuyCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuyCash.Location = new System.Drawing.Point(153, 177);
            this.lbBuyCash.Name = "lbBuyCash";
            this.lbBuyCash.Size = new System.Drawing.Size(114, 20);
            this.lbBuyCash.TabIndex = 24;
            this.lbBuyCash.Text = "0.00";
            this.lbBuyCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Buy cash: ";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 297);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnResearch);
            this.Controls.Add(this.pnServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Client";
            this.Text = "Client";
            this.Activated += new System.EventHandler(this.Client_Activated);
            this.Deactivate += new System.EventHandler(this.Client_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.pnServer.ResumeLayout(false);
            this.pnServer.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnResearch.ResumeLayout(false);
            this.pnResearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label statusConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel pnResearch;
        private System.Windows.Forms.Label lbResearch;
        private System.Windows.Forms.Label lbBank;
        private System.Windows.Forms.Label bankName;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lbMoneyType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSearchResult;
        private System.Windows.Forms.Label sell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBuyTransfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBuyCash;
        private System.Windows.Forms.Label label8;
    }
}

