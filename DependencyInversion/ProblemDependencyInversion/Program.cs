using ProblemDependencyInversion.Controllers;
using ProblemDependencyInversion.Services;

ProductController productController = new(new ProductService());

Console.WriteLine(productController.GetAllProducts(outputFormatJson: false));

// UNCOMMENT IF YOU WANT TO GET FORMAT JSON
// Console.WriteLine(productController.GetAllProducts(outputFormatJson: true));
