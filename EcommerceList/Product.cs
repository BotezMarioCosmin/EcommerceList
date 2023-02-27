using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    public abstract class Product
    {
        //attributi
        private string _id, _name, _manufacturer, _description;
        private float _price;

        //properties
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("Price must be >0");
            }
        }

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
                    throw new Exception("Invalid ID");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value != null)
                    _name = value;
                else
                    throw new Exception("Invalid name");
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            private set
            {
                if (value != null)
                    _manufacturer = value;
                else
                    throw new Exception("Invalid manufacturer");
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                if (value != null)
                    _description = value;
                else
                    throw new Exception("Invalid description");
            }
        }

        //costruttori
        public Product(string id, string name, string prod, string descr, float price)
        {
            if (String.IsNullOrEmpty(id) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(prod) || price <= 0)
            {
                throw new Exception("Invalid product parameters ");
            }
            Id = id;
            Name = name;
            Manufacturer = prod;
            Description = descr;
            Price = price;
        }

        public Product(string id, string name, string prod, string descr) : this(id, name, prod, descr, 10)
        {
        }

        public Product(string id, string name, string prod) : this(id, name, prod, "N/A", 10)
        {
        }

        public Product() : this("IDVUOTO", "N/A", "N/A", "N/A", 10)
        {
        }

        public Product(string id, string name, string prod, float price) : this(id, name, prod, "N/A", price)
        {

        }

        public Product(string id) : this(id, "N/A", "N/A", "N/A", 1)
        {

        }

        //costruttore copia
        protected Product(Product other) : this(other.Id, other.Name, other.Manufacturer, other.Description, other.Price)
        {
        }

        //clone 
        /*
        public Product Clone()
        {
            return new Product(this);
        }
        */
        //Equals
        public bool Equals(Product p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }

        //ToString
        public override string ToString()
        {
            return "Product:" + Id + ";" + Name + ";" + Manufacturer + ";" + Description + ";" + Price;
        }

        public virtual float getDiscount() { return Price; }
    }
}

