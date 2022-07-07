using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSingleResponsability.Models;
using ProblemSingleResponsability.Models.Database;

namespace ProblemSingleResposabilityForm.Services
{
    public class ProductServices : IProductServices
    {
        public void AddProduct(Product product)
        {
            Database.AddProduct(product);
        }

    }
}
