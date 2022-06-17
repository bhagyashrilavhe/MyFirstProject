using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Order
    {
        int orderId;
        string customerName;
        string city;

        public Order(int orderId,string customerName,string city)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(orderId + " " + customerName + " " + city );
        }
    }
    class OrderDate
    {
        int mm;
        int dd;
        int yy;

        public OrderDate(int mm, int dd, int yy)
        {
            this.mm = mm;
            this.dd = dd;
            this.yy = yy;
        }
        public void show1()
        {
            Console.WriteLine(mm + " " + dd + " " + yy);
        }
    }
    class ShipmentConstructor
    {

        int shipmentId;
        Order o;
        OrderDate od;

        public ShipmentConstructor(int shipmentId,Order o,OrderDate od)
        {
            this.shipmentId = shipmentId;
            this.o = o;
            this.od = od;
        }
        public void showShipmentConstructor()
        {
            Console.WriteLine(shipmentId + " " + o + " " + od);
            o.show();
            od.show1();
        }


        static void Main(String[] args)
        {
            ShipmentConstructor s = new ShipmentConstructor(101, new Order(1, "Rutuja", "Baramati"), new OrderDate(06, 07, 2022));
            s.showShipmentConstructor();
        }
    }
}
