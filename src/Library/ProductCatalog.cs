using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    /*
        Creamos la clase ProdcutCatalog, encargada de crear objetos de Product y guardarlos en una lista (entre otras cosas),
        ya que no tenía sentido que la clase program fuera la encargada de esta responsabilidad. Debido a que los objetos "Product"
        son guardados en dicha lista, decidimos que está los cree, aplicando así el patrón Creator.
    */
    public class ProductCatalog
    {
        public List<Product> Catalog {get; set;}

        public ProductCatalog()
        {
            this.Catalog = new List<Product>();
        }

        public void AddProductToCatalog(string description, double unitCost)
        {
            Catalog.Add(new Product(description, unitCost));
        }

        public Product ProductAt(int index)
        {
            return Catalog[index] as Product;
        }

        public Product GetProduct(string description)
        {
            var query = from Product product in Catalog where product.Description == description select product;
            return query.FirstOrDefault();
        }
    }
}