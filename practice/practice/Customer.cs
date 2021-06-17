using System.Collections.Generic;

namespace practice
{
    partial class Program
    {
        public class Customer
        {
            public int id;
            public string Name;
            public List<Order> Orders = new List<Order>();

            public Customer(int Id)
            {
                this.id = Id;
            }

            public Customer(int id , string Nama)
                :this(id)
            {
                this.Name = Nama;
                this.id = id;
            }

            public void promote()
            {
                Orders = new List<Order>();
            }

        }
    }
}
