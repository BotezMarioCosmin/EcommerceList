using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public class Cart
    {
        //attributi
        private const int MAXCARR = 999;
        private string _id;
        private int currentLenght;
        private Product[] _prod = new Product[MAXCARR];

        List<Product> Prodotti = new List<Product>();

        //properties
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Invalid Id");
            }
        }

        public Product[] Products
        {
            get
            {
                Product[] p = new Product[currentLenght];
                for (int i = 0; i < currentLenght; i++)
                {
                    p[i] = _prod[i];
                }
                return p;
            }
            //set{
            // 
            //}
        }

        public Cart(string id)
        {
            this.Id = id;
            Clear();
        }

        public void Clear()
        {
            Prodotti.Clear();
        }
        public void Add(Product p)
        {
            if (p != null)
            {
                Prodotti.Add(p);
            }
            else
                throw new Exception("Invalid product");
        }

        private int Length()
        {
            return Prodotti.Count();
        }

        public int IndexOf(Product q)
        {
            return Prodotti.IndexOf(q);
        }

        public void Modify(Product p)
        {
            int i = IndexOf(p);
            if (i >= 0)
            {
                Prodotti.Add(p);
            }
            else
                throw new Exception("Product not found");
        }

        public Product Remove(Product p)
        {
            if (IndexOf(p) != -1)
            {
                Prodotti.Remove(p);

                return p;
            }
            else
                throw new Exception("Product not found");
        }
    }
}

