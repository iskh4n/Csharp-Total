using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //  _productService = new ProductManager(new NhProductDal());
            // _productService = new ProductManager(new EfProductDal());
            _productService = InstanceFactory.GetInstance<IProductService>();

            // _categoryService = new CategoryManager(new EfCategoryDal());

            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;//
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //ProductManager productManager = new ProductManager(new NhProductDal());

            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            //----

            cbxAddCategory .DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";


            //--
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch (Exception)
            {

                
            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);

            }
            else
            {
                LoadProducts();
            }

        }


        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantity.Text = row.Cells[4].Value.ToString();
            tbxUpdateStock.Text = row.Cells[5].Value.ToString();


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = tbxAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    QuantityPerUnit = tbxAddQuantity.Text,
                    UnitsInStock = Convert.ToInt16(tbxAddStock.Text)
                });

                MessageBox.Show("Product Added!");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUpdateStock.Text),
                    QuantityPerUnit = tbxUpdateQuantity.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)


                });

                MessageBox.Show("Product Updated!");
                LoadProducts();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
                
            }
            
            
           


          

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)

                    });
                    MessageBox.Show("Product Deleted!");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
            

        }


       

       
    }
}
