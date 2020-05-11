using lesson1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lesson1.Services
{
    public class ProductsService
    {
        private readonly string _path;

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            List<Product> products = new List<Product>();
            
            using (StreamReader sr = new StreamReader(_path, System.Text.Encoding.UTF8))
            {
                string line;
                
                while ((line = await sr.ReadLineAsync()) != null)
                {                
                    products.Add(GetProdFromArray(line.Split(',')));
                }
            }

            return products;
        }

        private Product GetProdFromArray(string[] v) =>
        
            new Product
            {
                Id = Int32.Parse(v[0]),
                Name = v[1],
                Price = Decimal.Parse(v[2]),
                Describe = v[3],
                Stocks = Int32.Parse(v[4]),
                Category = v[5]
            };
        

        public ProductsService(string path)
        {
            _path = path;
        }
    }
}
