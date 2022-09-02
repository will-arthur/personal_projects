
namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.indexTBox = new System.Windows.Forms.TextBox();
            this.genWalletBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.pubKeyLbl = new System.Windows.Forms.Label();
            this.privKeyLbl = new System.Windows.Forms.Label();
            this.PrivatekeyTextBox = new System.Windows.Forms.TextBox();
            this.createtransactionbutton = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.feeLbl = new System.Windows.Forms.Label();
            this.RKeyLbl = new System.Windows.Forms.Label();
            this.amountTBox = new System.Windows.Forms.TextBox();
            this.feeTBox = new System.Windows.Forms.TextBox();
            this.recieverKeyTBox = new System.Windows.Forms.TextBox();
            this.blockGenBtn = new System.Windows.Forms.Button();
            this.printAllBtn = new System.Windows.Forms.Button();
            this.viewpendingtransacbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.validate = new System.Windows.Forms.Button();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.addressFind = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(739, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(15, 451);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print Block";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // indexTBox
            // 
            this.indexTBox.Location = new System.Drawing.Point(95, 453);
            this.indexTBox.Name = "indexTBox";
            this.indexTBox.Size = new System.Drawing.Size(40, 20);
            this.indexTBox.TabIndex = 2;
            this.indexTBox.TextChanged += new System.EventHandler(this.IndexInput_TextChanged);
            // 
            // genWalletBtn
            // 
            this.genWalletBtn.Location = new System.Drawing.Point(589, 335);
            this.genWalletBtn.Name = "genWalletBtn";
            this.genWalletBtn.Size = new System.Drawing.Size(62, 48);
            this.genWalletBtn.TabIndex = 4;
            this.genWalletBtn.Text = "Generate Wallet";
            this.genWalletBtn.UseVisualStyleBackColor = true;
            this.genWalletBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Validate Keys";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PublicKeyTextBox
            // 
            this.PublicKeyTextBox.Location = new System.Drawing.Point(312, 335);
            this.PublicKeyTextBox.Name = "PublicKeyTextBox";
            this.PublicKeyTextBox.Size = new System.Drawing.Size(271, 20);
            this.PublicKeyTextBox.TabIndex = 6;
            this.PublicKeyTextBox.TextChanged += new System.EventHandler(this.PubKeyTBox_TextChanged);
            // 
            // pubKeyLbl
            // 
            this.pubKeyLbl.AutoSize = true;
            this.pubKeyLbl.Location = new System.Drawing.Point(249, 338);
            this.pubKeyLbl.Name = "pubKeyLbl";
            this.pubKeyLbl.Size = new System.Drawing.Size(57, 13);
            this.pubKeyLbl.TabIndex = 7;
            this.pubKeyLbl.Text = "Public Key";
            this.pubKeyLbl.Click += new System.EventHandler(this.pubKeyLbl_Click);
            // 
            // privKeyLbl
            // 
            this.privKeyLbl.AutoSize = true;
            this.privKeyLbl.Location = new System.Drawing.Point(245, 364);
            this.privKeyLbl.Name = "privKeyLbl";
            this.privKeyLbl.Size = new System.Drawing.Size(61, 13);
            this.privKeyLbl.TabIndex = 8;
            this.privKeyLbl.Text = "Private Key";
            // 
            // PrivatekeyTextBox
            // 
            this.PrivatekeyTextBox.Location = new System.Drawing.Point(312, 361);
            this.PrivatekeyTextBox.Name = "PrivatekeyTextBox";
            this.PrivatekeyTextBox.Size = new System.Drawing.Size(271, 20);
            this.PrivatekeyTextBox.TabIndex = 9;
            this.PrivatekeyTextBox.TextChanged += new System.EventHandler(this.PrivKeyTBox_TextChanged);
            // 
            // createtransactionbutton
            // 
            this.createtransactionbutton.Location = new System.Drawing.Point(17, 335);
            this.createtransactionbutton.Name = "createtransactionbutton";
            this.createtransactionbutton.Size = new System.Drawing.Size(73, 46);
            this.createtransactionbutton.TabIndex = 10;
            this.createtransactionbutton.Text = "Create Transaction";
            this.createtransactionbutton.UseVisualStyleBackColor = true;
            this.createtransactionbutton.Click += new System.EventHandler(this.createtransactionbutton_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(92, 335);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(43, 13);
            this.amountLbl.TabIndex = 11;
            this.amountLbl.Text = "Amount";
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.Location = new System.Drawing.Point(101, 361);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(25, 13);
            this.feeLbl.TabIndex = 12;
            this.feeLbl.Text = "Fee";
            // 
            // RKeyLbl
            // 
            this.RKeyLbl.AutoSize = true;
            this.RKeyLbl.Location = new System.Drawing.Point(351, 485);
            this.RKeyLbl.Name = "RKeyLbl";
            this.RKeyLbl.Size = new System.Drawing.Size(71, 13);
            this.RKeyLbl.TabIndex = 13;
            this.RKeyLbl.Text = "Receiver Key";
            // 
            // amountTBox
            // 
            this.amountTBox.Location = new System.Drawing.Point(132, 335);
            this.amountTBox.Name = "amountTBox";
            this.amountTBox.Size = new System.Drawing.Size(100, 20);
            this.amountTBox.TabIndex = 14;
            // 
            // feeTBox
            // 
            this.feeTBox.Location = new System.Drawing.Point(132, 361);
            this.feeTBox.Name = "feeTBox";
            this.feeTBox.Size = new System.Drawing.Size(100, 20);
            this.feeTBox.TabIndex = 15;
            // 
            // recieverKeyTBox
            // 
            this.recieverKeyTBox.Location = new System.Drawing.Point(428, 482);
            this.recieverKeyTBox.Name = "recieverKeyTBox";
            this.recieverKeyTBox.Size = new System.Drawing.Size(323, 20);
            this.recieverKeyTBox.TabIndex = 16;
            // 
            // blockGenBtn
            // 
            this.blockGenBtn.Location = new System.Drawing.Point(17, 396);
            this.blockGenBtn.Name = "blockGenBtn";
            this.blockGenBtn.Size = new System.Drawing.Size(73, 40);
            this.blockGenBtn.TabIndex = 17;
            this.blockGenBtn.Text = "Generate New Block";
            this.blockGenBtn.UseVisualStyleBackColor = true;
            this.blockGenBtn.Click += new System.EventHandler(this.BlockGenBtn_Click);
            // 
            // printAllBtn
            // 
            this.printAllBtn.Location = new System.Drawing.Point(12, 480);
            this.printAllBtn.Name = "printAllBtn";
            this.printAllBtn.Size = new System.Drawing.Size(78, 23);
            this.printAllBtn.TabIndex = 18;
            this.printAllBtn.Text = "Print All";
            this.printAllBtn.UseVisualStyleBackColor = true;
            this.printAllBtn.Click += new System.EventHandler(this.PrintAllBtn_Click);
            // 
            // viewpendingtransacbutton
            // 
            this.viewpendingtransacbutton.Location = new System.Drawing.Point(171, 456);
            this.viewpendingtransacbutton.Name = "viewpendingtransacbutton";
            this.viewpendingtransacbutton.Size = new System.Drawing.Size(100, 46);
            this.viewpendingtransacbutton.TabIndex = 19;
            this.viewpendingtransacbutton.Text = "View  Pending Transactions ";
            this.viewpendingtransacbutton.UseVisualStyleBackColor = true;
            this.viewpendingtransacbutton.Click += new System.EventHandler(this.viewpendingtransacbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "None";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GREEDY",
            "RANDOM",
            "ALTRUISTIC",
            "ADDRESS PREFERENCE"});
            this.comboBox1.Location = new System.Drawing.Point(354, 432);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Mining system";
            this.comboBox1.ValueMember = "None";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(658, 363);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(93, 20);
            this.validate.TabIndex = 23;
            this.validate.Text = "Validate Chain";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // CheckBalance
            // 
            this.CheckBalance.Location = new System.Drawing.Point(657, 389);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(94, 25);
            this.CheckBalance.TabIndex = 24;
            this.CheckBalance.Text = "Check Balance";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // addressFind
            // 
            this.addressFind.Location = new System.Drawing.Point(525, 432);
            this.addressFind.Name = "addressFind";
            this.addressFind.Size = new System.Drawing.Size(163, 20);
            this.addressFind.TabIndex = 25;
            this.addressFind.Text = "Search for: ";
            this.addressFind.TextChanged += new System.EventHandler(this.addressFind_TextChanged);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 507);
            this.Controls.Add(this.addressFind);
            this.Controls.Add(this.CheckBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.viewpendingtransacbutton);
            this.Controls.Add(this.printAllBtn);
            this.Controls.Add(this.blockGenBtn);
            this.Controls.Add(this.recieverKeyTBox);
            this.Controls.Add(this.feeTBox);
            this.Controls.Add(this.amountTBox);
            this.Controls.Add(this.RKeyLbl);
            this.Controls.Add(this.feeLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.createtransactionbutton);
            this.Controls.Add(this.PrivatekeyTextBox);
            this.Controls.Add(this.privKeyLbl);
            this.Controls.Add(this.pubKeyLbl);
            this.Controls.Add(this.PublicKeyTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.genWalletBtn);
            this.Controls.Add(this.indexTBox);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox indexTBox;
        private System.Windows.Forms.Button genWalletBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PublicKeyTextBox;
        private System.Windows.Forms.Label pubKeyLbl;
        private System.Windows.Forms.Label privKeyLbl;
        private System.Windows.Forms.TextBox PrivatekeyTextBox;
        private System.Windows.Forms.Button createtransactionbutton;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label feeLbl;
        private System.Windows.Forms.Label RKeyLbl;
        private System.Windows.Forms.TextBox amountTBox;
        private System.Windows.Forms.TextBox feeTBox;
        private System.Windows.Forms.TextBox recieverKeyTBox;
        private System.Windows.Forms.Button blockGenBtn;
        private System.Windows.Forms.Button printAllBtn;
        private System.Windows.Forms.Button viewpendingtransacbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.TextBox addressFind;
    }
}
