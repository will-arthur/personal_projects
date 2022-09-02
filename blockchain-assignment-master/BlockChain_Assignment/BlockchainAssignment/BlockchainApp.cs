using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{

    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;

        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();

            // Message printed when block chain is initialised
            outputToRichTextBox1("New Blockchain Initialised!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Int32.TryParse(indexTBox.Text, out int index))
                outputToRichTextBox1(blockchain.GetBlockAsString(index));
            else
                outputToRichTextBox1("Invalid Block No.");
           
        }

        private void outputToRichTextBox1(string toBePrinted) { richTextBox1.Text = toBePrinted; }
        private void outputToTextBox(TextBox TBox, string toBePrinted) { TBox.Text = toBePrinted; }

        private void button2_Click(object sender, EventArgs e)
        {
            //String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out string privatekey);
            String publickey = myNewWallet.publicID;
            

            outputToTextBox(PrivatekeyTextBox, privatekey);
            outputToTextBox(PublicKeyTextBox, publickey) ;
        }

        /* Validate Keys */
        private void button3_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(PrivatekeyTextBox.Text, PublicKeyTextBox.Text))
            {
                richTextBox1.Text = "Keys are valid";
            }
            else
            {
                richTextBox1.Text = "Keys are invalid";
            }
        }

        private void createtransactionbutton_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(PublicKeyTextBox.Text, PrivatekeyTextBox.Text, recieverKeyTBox.Text, Convert.ToSingle(amountTBox.Text), Convert.ToSingle(feeTBox.Text));

            blockchain.add2TPool(transaction);
            outputToRichTextBox1(transaction.ReturnString());
        }

        private void BlockGenBtn_Click(object sender, EventArgs e)
        {
            
            Block block = new Block(blockchain.GetLastBlock());
            blockchain.add2Block(block);

            richTextBox1.Text = blockchain.ToString();
        }
        
        private void PrintAllBtn_Click(object sender, EventArgs e)
        {
            string printall = "";
            for (int i = 0; i < blockchain.maxBlock; i++)
            {
                printall += (blockchain.BlockString(Convert.ToInt32(i)) + "\n \n");
            }
            outputToRichTextBox1(printall);
        }

        

        private void viewpendingtransacbutton_Click(object sender, EventArgs e)
        {string s = "";
            foreach (Transaction T in blockchain.rettransactions()) {
               s+= T +": \n "+T.ReturnString() + "\n \n ";
            }
            outputToRichTextBox1(s);
        }
                     
            
        private void PubKeyTBox_TextChanged(object sender, EventArgs e)
        {
            button3.BackColor = Color.AntiqueWhite;
        }
        private void PrivKeyTBox_TextChanged(object sender, EventArgs e)
        {
            button3.BackColor = Color.AntiqueWhite;
        }

        
        private void BlockchainApp_Load(object sender, EventArgs e)
        {

        }

          private void IndexInput_TextChanged(object sender, EventArgs e)
        {

        }
    

        private void Validate_Click(object sender, EventArgs e)
        {
            
            if (blockchain.Blocks.Count == 1)
            {
                if (!Blockchain.ValidateHash(blockchain.Blocks[0])) 
                    outputToRichTextBox1("Blockchain is invalid - Hash ");
                else
                    outputToRichTextBox1("Blockchain is valid");
                return;
            }

            Console.WriteLine(" NewBlock: " + (blockchain.Blocks.Count - 1)); 
            for (int i = 1; i < blockchain.Blocks.Count - 1; i++)
            {
                Console.WriteLine("Hash for block " + i);
                if (
                    blockchain.Blocks[i].prevHash != blockchain.Blocks[i - 1].hash || 
                    !Blockchain.ValidateHash(blockchain.Blocks[i]) ||  
                    !Blockchain.ValidateMerkleRoot(blockchain.Blocks[i]) // Check transaction integrity using Merkle Root
                )
                {
                    outputToRichTextBox1("Blockchain is invalid " + (blockchain.Blocks[i].prevHash != blockchain.Blocks[i - 1].hash).ToString() + "  " +
                    !Blockchain.ValidateHash(blockchain.Blocks[i]) + "  " + 
                    !Blockchain.ValidateMerkleRoot(blockchain.Blocks[i]) + " " + blockchain.Blocks[i].nonce);// C);
                    return;
                }
            }
            outputToRichTextBox1("Blockchain is valid");
        }

        // Check user balance
        private void CheckBalance_Click(object sender, EventArgs e)
        {
            outputToRichTextBox1(blockchain.GetBalance(PublicKeyTextBox.Text).ToString() + " Assignment Coin");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pubKeyLbl_Click(object sender, EventArgs e)
        {

        }

        private void addressFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
