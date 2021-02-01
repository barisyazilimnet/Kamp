using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //bireysel müşteri
    class İndividiualCustomer : Customer //bununda normal bir müşteri oldugunu söler
    {
        public string CustomerTcNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
