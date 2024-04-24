using ProductCRUD.Models;
using System.Diagnostics;

namespace ProductCRUD;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {

        db01Context db = new db01Context();
        int id, price;
        int.TryParse(txtId.Text, out id);
        int.TryParse(txtPrice.Text, out price);

        var result = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
        if (result == null)
        {

            var newProduct = new Product
            {
                ProductId = id,
                ProductName = txtName.Text,
                Price = price
            };
            db.Products.Add(newProduct);
            db.SaveChanges();

            MessageBox.Show($"{newProduct.ProductId} {newProduct.ProductName} {newProduct.Price}",
                            "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        else
        {
            MessageBox.Show($"Product ID:{txtId.Text} is already existed",
                            "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        db01Context db = new db01Context();
        int id, price;
        int.TryParse(txtId.Text, out id);
        int.TryParse(txtPrice.Text, out price);

        var result = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
        if (result != null)
        {
            result.ProductName = txtName.Text;
            result.Price = price;
            db.SaveChanges();

            MessageBox.Show($"{result.ProductId} {result.ProductName} {result.Price}",
                                           "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show($"Product ID:{txtId.Text} is not found",
                                           "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        db01Context db = new db01Context();
        int id, price;
        int.TryParse(txtId.Text, out id);
        int.TryParse(txtPrice.Text, out price);

        var result = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
        if (result != null)
        {
            db.Products.Remove(result);
            db.SaveChanges();

            MessageBox.Show($"{result.ProductId} {result.ProductName} {result.Price}",
                            "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show($"Product ID:{txtId.Text} is not found",
                            "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        db01Context db = new db01Context();
        int id;
        int.TryParse(txtId.Text, out id);

        var result = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
        if (result != null)
        {
            txtName.Text = result.ProductName;
            txtPrice.Text = result.Price.ToString();
        }
        else
        {
            txtName.Clear();
            txtPrice.Clear();
            MessageBox.Show($"Product ID:{txtId.Text} is not found",
                             "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
