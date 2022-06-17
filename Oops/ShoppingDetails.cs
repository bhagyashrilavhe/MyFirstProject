using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class ShoppingDetails
    {

        public string item;
        public int quantity;
        public int price, total;

        public void AcceptShoppingDetails(string sitem, int squantity, int sprice)
        {
            item = sitem;
            quantity = squantity;
            price = sprice;
        }

        public void get()
        {
            if(quantity>0)
            {
                total = price * quantity;
                Console.WriteLine("Total price : " + total);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void show()
        {
            Console.WriteLine("Item \t Quantity \tPrice \t Total");
            Console.WriteLine(item + "     " + quantity+ "         " + price +  "       " + total);
        }

        static void Main(String[] args)
        {
            ShoppingDetails shop = new ShoppingDetails();
             
            shop.AcceptShoppingDetails("NoteBook", 3,120 );
            shop.get();
            shop.show();

        }
    }
}
