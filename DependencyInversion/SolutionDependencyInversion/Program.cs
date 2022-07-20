using SolutionDependencyInversion.Commons;
using SolutionDependencyInversion.Commons.Interface;
using SolutionDependencyInversion.Controllers;
using SolutionDependencyInversion.Services;

IInfo info = new InfoFormatJson();
ProductService productService = new(info);
ProductController productController = new(productService);

Console.WriteLine(productController.GetAllProducts());

