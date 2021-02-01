using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.yol
            //Barış KURT
            İndividiualCustomer customer1 = new İndividiualCustomer
            {
                CustomerId = 1,
                CustomerTcNumber = "21656132565",
                CustomerNumber = "12354",
                CustomerName = "Barış",
                CustomerSurname = "KURT"
            };

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer
            {
                CustomerId=2,
                CustomerNumber="1896",
                CustomerVergiNumber="156130",
                CustomerCompanyName="Kodlama.io"
            };
            //2.yol
            Customer customer3 = new İndividiualCustomer(); //bireysel müşteri
            Customer customer4 = new CorporateCustomer(); //kurumsal müşteri
            CustomerManager customerManager = new CustomerManager();
            //4 üde burda kullanılabilir
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
