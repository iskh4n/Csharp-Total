using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        ProductDAL _productDAL = new ProductDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ProductDAL productDAL = new ProductDAL();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDAL.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDAL.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxPrice.Text),
                StockAmount=Convert.ToInt32(tbxAmount.Text)


            });

            LoadProducts();
            MessageBox.Show("Product Added!");
        }

      

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name=tbxNameUpdate.Text,
                UnitPrice=Convert.ToDecimal(tbxPriceUpdate.Text),
                StockAmount=Convert.ToInt32(tbxAmountUpdate.Text)
        
            };

            _productDAL.Update(product);
            LoadProducts();
            MessageBox.Show("Product UPDATED!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDAL.Delete(id);
            LoadProducts();
            MessageBox.Show("Product DELETED!");

        }
    }
}
