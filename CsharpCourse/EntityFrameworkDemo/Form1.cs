using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDAL _productDAL = new ProductDAL();

        private void Form1_Load(object sender, EventArgs e)
        {
            /* using (EticContext context = new EticContext())
             {
                 dgwProducts.DataSource = context.Products.ToList();

             }*/


            ProductLoad();

        }

        private void ProductLoad()
        {
            dgwProducts.DataSource = _productDAL.GetAll();
        }

        private void ProductSearch(string key)
        {
            var result = _productDAL.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            // c# küçük büyük harf duyarlı olduğu için  hem aranan hem listedekileri küçük harfe çeviririz.
            //var result = _productDAL.GetByName(key);// LINQ //  daha çok veri varsa daha verimli bir arama yöntemi harf duyarlılığı yok.
           
            
            dgwProducts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDAL.Add(new Product
            {
                Name=tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxPrice.Text),
                StockAmount=Convert.ToInt32(tbxAmount.Text)

            });

            ProductLoad();
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
           _productDAL.Update(new Product {
               Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
               Name = tbxNameUpdate.Text,
               UnitPrice = Convert.ToDecimal(tbxPriceUpdate.Text),
               StockAmount = Convert.ToInt32(tbxAmountUpdate.Text)

           });


            ProductLoad();
            MessageBox.Show("Product Updated!");
        }

     

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDAL.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)

            });


            ProductLoad();
            MessageBox.Show("Product Deleted!");

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            ProductSearch(tbxSearch.Text);
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            _productDAL.GetById(2);
        }
    }
}
