using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public int maxBlock { get => this.Blocks.Count; }  //Max transactions per block                                
        public List<Block> Blocks = new List<Block>();     //Block listing                              
        public List<Transaction> TransactionPool = new List<Transaction>();  //List of pending transactions        

        public Blockchain()
        {
            Block genesis = new Block();
            Blocks.Add(genesis);
            
        }
        public string BlockString(int index)
        {
            return (Blocks.ElementAt(index).ReturnString());
        }


        public void add2TPool(Transaction Trans)
        {
            TransactionPool.Add(Trans);
        }
        public void add2Block(Block blck)
        {
            Blocks.Add(blck);
        }

        // Prints the block 
        public String GetBlockAsString(int index)
        {
            // Check if referenced block exists
            if (index >= 0 && index < Blocks.Count)
                return Blocks[index].ToString(); // Returns the block in string format 
            else
                return "No such block exists";
        }
        public void purgetransactions(List<Transaction> chosenT)
        {
            TransactionPool = TransactionPool.Except(chosenT).ToList();
        }
        public Block GetLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

                public List<Transaction> rettransactions() {
            return TransactionPool;
        }

        
        public override string ToString()
        {
            return string.Join("\n", Blocks);
        }

        
        public static bool ValidateHash(Block b){
            string rehash =string.Empty ;
            
            rehash = b.Create256Hash();
            Console.WriteLine("Rehash: " + rehash + " --> Hash: " + b.hash);
            return rehash.Equals(b.hash);
        }



        // Gets balance linked to the senders private key
        public double GetBalance(String address)
        {
            // Accumulator value
            double balance = 0;

            // Looping through to produce the balance
            foreach (Block b in Blocks)
            {
                foreach (Transaction t in b.transactionList)
                {
                    if (t.RecipientAddress.Equals(address))
                    {
                        balance += t.Amount; 
                    }
                    if (t.SenderAddress.Equals(address))
                    {
                        balance -= (t.Amount + t.Fee); 
                    }
                }
            }
            return balance;
        }

        
        public static bool ValidateMerkleRoot(Block b){
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }
    }
}
