using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace andrew_foster_cpt_236_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        displayForm display = new displayForm();
        public static string resultsBuilder;

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
            pDescText.Enabled = false;
            invAmtText.Enabled = false;
            priceAmtText.Enabled = false;
        }

        private void Error()
        {
            if (pDescText.Text.Length < 1 && pNumText.Text.Length < 1 && priceAmtText.Text.Length < 1) { MessageBox.Show("You must provide something to search for!"); }
            else { MessageBox.Show("Your search returned 0 results. Be more specific and try again."); }
        }

        private void pNumRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pNumRadio.Checked == true)
            {
                pNumText.Text = "";
                invAmtText.Text = "";
                priceAmtText.Text = "";
                pNumText.Enabled = true;
                invAmtText.Enabled = false;
                priceAmtText.Enabled = false;
                pDescText.Enabled = false;
                invGreatRadio.Checked = false;
                invLessRadio.Checked = false;
                priceLessRadio.Checked = false;
                priceGreatRadio.Checked = false;
            }
        }

        private void pDescRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pDescRadio.Checked == true)
            {
                pDescText.Text = "";
                invAmtText.Text = "";
                priceAmtText.Text = "";
                pDescText.Enabled = true;
                invAmtText.Enabled = false;
                priceAmtText.Enabled = false;
                pNumText.Enabled = false;
                invGreatRadio.Checked = false;
                invLessRadio.Checked = false;
                priceLessRadio.Checked = false;
                priceGreatRadio.Checked = false;
            }
        }

        private void pClear_Click(object sender, EventArgs e)
        {
            pNumText.Text = "";
            pDescText.Text = "";
            resultsList.Items.Clear();
        }

        private void pSearch_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (pNumText.Text.Length > 0)
            {
                var results = from Product in db.Products
                              where Product.Product_Number == pNumText.Text
                              select Product.Product_Number + "\t\t" + Product.Description + "\t\t" + Product.Units_On_Hand + "\t\t$" + Product.Price + " each";
                resultsList.Items.Clear();
                foreach (string description in results)
                {
                    resultsList.Items.Add(description);
                }
            }
            else if (pDescText.Text.Length > 0)
            {
                var results = from Product in db.Products
                              where Product.Description == pDescText.Text
                              select Product.Product_Number + "\t\t" + Product.Description + "\t\t" + Product.Units_On_Hand + "\t\t$" + Product.Price + " each";
                resultsList.Items.Clear();
                foreach (string description in results)
                {
                    resultsList.Items.Add(description);
                }
            }
            if (resultsList.Items.Count < 1) { Error(); }
            
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void priceSearch_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            decimal priceAmt;
            decimal.TryParse(priceAmtText.Text, out priceAmt);
            if (priceAmtText.Text.Length < 1) { Error(); }
            else if (priceLessRadio.Checked == true)
            {
                var results = from Product in db.Products
                              where Product.Price < priceAmt
                              select Product.Product_Number + "\t\t" + Product.Description + "\t\t" + Product.Units_On_Hand + "\t\t$" + Product.Price + " each";
                resultsList.Items.Clear();
                foreach (string description in results)
                {
                    resultsList.Items.Add(description);
                }
            }
            else if (priceGreatRadio.Checked == true)
            {
                var results = from Product in db.Products
                              where Product.Price > priceAmt
                              select Product.Product_Number + "\t\t" + Product.Description + "\t\t" + Product.Units_On_Hand + "\t\t$" + Product.Price + " each";
                resultsList.Items.Clear();
                foreach (string description in results)
                {
                    resultsList.Items.Add(description);
                }
            }
            if (resultsList.Items.Count < 1) { Error(); }
        }

        private void invLessRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (invLessRadio.Checked == true)
            {
                pNumRadio.Checked = false;
                pDescRadio.Checked = false;
                priceGreatRadio.Checked = false;
                priceLessRadio.Checked = false;
                pNumText.Text = "";
                pDescText.Text = "";
                priceAmtText.Text = "";
                pNumText.Enabled = false;
                invAmtText.Enabled = true;
                priceAmtText.Enabled = false;
                pDescText.Enabled = false;
            }
            
        }

        private void invGreatRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (invGreatRadio.Checked == true)
            {
                pNumRadio.Checked = false;
                pDescRadio.Checked = false;
                priceGreatRadio.Checked = false;
                priceLessRadio.Checked = false;
                pNumText.Text = "";
                pDescText.Text = "";
                priceAmtText.Text = "";
                pNumText.Enabled = false;
                invAmtText.Enabled = true;
                priceAmtText.Enabled = false;
                pDescText.Enabled = false;
            }
            
        }

        private void priceLessRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (priceLessRadio.Checked == true)
            {
                pNumRadio.Checked = false;
                pDescRadio.Checked = false;
                invGreatRadio.Checked = false;
                invLessRadio.Checked = false;
                pNumText.Text = "";
                pDescText.Text = "";
                invAmtText.Text = "";
                pNumText.Enabled = false;
                invAmtText.Enabled = false;
                priceAmtText.Enabled = true;
                pDescText.Enabled = false;
            }
            
        }

        private void priceGreatRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (priceGreatRadio.Checked == true)
            {
                pNumRadio.Checked = false;
                pDescRadio.Checked = false;
                invGreatRadio.Checked = false;
                invLessRadio.Checked = false;
                pNumText.Text = "";
                pDescText.Text = "";
                invAmtText.Text = "";
                pNumText.Enabled = false;
                invAmtText.Enabled = false;
                priceAmtText.Enabled = true;
                pDescText.Enabled = false;
            }
            
        }

        private void invSearch_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            int onHand;
            int.TryParse(invAmtText.Text, out onHand);
            if (invAmtText.Text.Length < 1) { Error(); }
            else if (invLessRadio.Checked == true)
            {
                var results = from Product in db.Products
                              where Product.Price < onHand
                              select Product.Product_Number + "\t\t" + Product.Description + "\t\t" + Product.Units_On_Hand + "\t\t$" + Product.Price + " each";
                resultsList.Items.Clear();
                foreach (string description in results)
                {
                    resultsList.Items.Add(description);
                }
            }
            else if (invGreatRadio.Checked == true)
            {
                var results = from Product in db.Products
                              where Product.Price > onHand
                              select Product.Product_Number + "\t\t" + Product.Description + "\t\t" + Product.Units_On_Hand + "\t\t$" + Product.Price + " each";
                resultsList.Items.Clear();
                foreach (string description in results)
                {
                    resultsList.Items.Add(description);
                }
            }
            if (resultsList.Items.Count < 1) { Error(); }
        }
    }
}
