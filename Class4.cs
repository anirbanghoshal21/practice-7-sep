using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_library
{
    public delegate void ProductDelegate(int _productid, string _productname);
    public class Product
    {
        private int _productid;

        public int Productid
        {
            get { return _productid; }
            set { _productid = value; }
        }
        private string _productname;

        public string Productname
        {
            get { return _productname; }
            set { _productname = value; }
        }

        public ProductDelegate Product { get; private set; }

        static void Main(string[] args)
        {

            Product p = new Product();


            ProductDelegate d = new ProductDelegate(p.Product);
            d.Invoke();
            d();

        }
    }
}
