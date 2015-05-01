using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoApp
{
    public partial class BookInfoApp : Form
    {
        Hashtable bookHashtable = new Hashtable();
        public BookInfoApp()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbn = iSBNAddTextBox.Text;
            string bookDetails = bookDetailsAddTextBox.Text;
            bookHashtable.Add(isbn,bookDetails);
            iSBNAddTextBox.Text = "";
            bookDetailsAddTextBox.Text = "";
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

                
                bookDetailsSearchTextBox.Text = "";
                
                string isbn = iSBNSearchTextBox.Text;
            
                if (bookHashtable.ContainsKey(isbn))
                {
                    bookDetailsSearchTextBox.Text = bookHashtable[isbn].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Book Not Found");
                    
                }
                iSBNSearchTextBox.Text = "";
            

        }

       
    }
}
