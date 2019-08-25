using System.Collections.Generic;

namespace MVCForms.Models
{
    public static class ProductRepository
    {   
        private static List<Product> _products;
        public static List<Product> Products{
            get{ return _products;}
        }
        static ProductRepository()
        {
            _products=new List<Product>(){
                new Product(){Id=1,Name="Prod 1", Description="Descrip1",Price=100, isApproved=true},
                new Product(){Id=2,Name="Prod 2", Description="Descrip2",Price=200, isApproved=true},
                new Product(){Id=3,Name="Prod 3", Description="Descrip3",Price=300, isApproved=true},
                new Product(){Id=4,Name="Prod 4", Description="Descri4",Price=140, isApproved=true},
                new Product(){Id=5,Name="Prod 5", Description="Descrip5",Price=500, isApproved=true}
            };
        }
        public static void addProduct(Product product){
            _products.Add(product);
        }
    }
}