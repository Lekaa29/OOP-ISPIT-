using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ISPIT
{
    internal class AV4
    {
    }
    //SUČELJE can-do
    //Članovi sučelja implicitno su apstraktni i javni,
    //a nije dopušteno navođenje prava pristupa.
    //Imena sučelja započinju velikim početnim slovom I
    //i koriste PascalCase (npr. ICompressable, IComparable, IEnumerable...).
    public interface ILogger
    {
        void logInfo(string message);
    }
    public class Logger : ILogger
    {
        public void logInfo(string message){}
    }
    //Kod nasljeđivanja je moguće naslijediti samo i isključivo jednu klasu, dok je
    //moguće implementirati proizvoljan broj sučelja.
    public interface IElemental
    {
        string Element { get; }
    }
    public interface IFighter
    {
        int GetDamage(int hits);
    }
    public class IceGolem : IElemental, IFighter
    {
        private string element; //ovo se ne smatra implementacijom elemental jer interface name instance fields
        public string Element
        {
            get { return element; }
        }
        public int GetDamage(int hits)
        {
            return hits;
        }
    }

    //liste i povezivanje klasa čvrsta povezanost
    public class Product
    {
        public decimal Price { get; set; }
    }
    public class Cart
    {
        private List<Product> items;
        public Cart()
        {
            items = new List<Product>();
        }
        public void Insert(Product product)
        {
            items.Add(product);
        }
        public decimal Total()
        {
            decimal total = 0.0m;
            foreach(Product product in items)
            {
                total += product.Price;
            }
            return total;
        }
    }

    //labava ovisnost
    public interface IDiscount
    {
        public decimal CalculateDiscountedPrice(decimal price);
    }
    public class Fixed1Discount : IDiscount
    {
        public decimal CalculateDiscountedPrice(decimal price)
        {
            return 1.0m;
        }
    }
    public class Fixed2Discount : IDiscount
    {
        public decimal CalculateDiscountedPrice(decimal price)
        {
            return 2.0m;
        }
    }

    public class Product2
    {
        public decimal Price { get; set; }
    }
    public class Cart2
    {
        private List<Product> items;
        private decimal tax;
        private IDiscount discount;
        public Cart2(decimal tax, IDiscount discount) {
            this.tax = tax;
            this.discount = discount;
            items = new List<Product>();
        }
        // total += discount.CalculateDiscountedPrice(priceWithTax);
    }
    internal class test
    {
        static void Main(string[] args)
        {
            IDiscount discount = new Fixed1Discount();
            Cart2 cart = new Cart2(0.25m, discount);
            //mjenjamo funkcionalnost discount unutar cart vezom ( INTERFACE -> CLASS:I -> CART(CLASS:I) )
            discount = new Fixed2Discount();
            cart = new Cart2(0.25m, discount);
        }
    }
    //ubrizgavanje preko settera umjesto preko konstruktora
    public class Cart3
    {
        //..
        IDiscount discount;
        public void SetDiscount(IDiscount discount)
        {
            this.discount = discount;
        }

    }
    //cart3.setDiscount(discount1);
  
    
}
