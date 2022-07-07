using ProblemSingleResponsability.Controllers;
using ProblemSingleResponsability.Models;

namespace ProblemSingleResposabilityForm
{
    public partial class Form1 : Form
    {
        ProductController productController;
        public Form1()
        {
            productController = new();
            InitializeComponent();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            var listProducts = productController.GetProducts();

            MessageBox.Show(listProducts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lblName.Text != "" && lblPrice.Text != "")
            {
                Product product = new(lblName.Text, float.Parse(lblPrice.Text));
                product.AddProduct();
                MessageBox.Show("Producto ingresado.");
            }
            else
                MessageBox.Show("Ingrese datos validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}