using ProblemOpenClosed.Controllers;
using ProblemOpenClosed.Services;

ProductController productController = new ProductController(new ProductService());

Console.WriteLine(productController.PrintAllProducts());