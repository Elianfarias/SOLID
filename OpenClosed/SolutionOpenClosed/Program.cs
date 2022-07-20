using SolutionOpenClosed.Controllers;
using SolutionOpenClosed.Services;

ProductController productController = new ProductController(new ProductService());

Console.WriteLine(productController.PrintAllProducts());