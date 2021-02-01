using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Kurumsal müşteri
    class CorporateCustomer : Customer //bununda normal bir müşteri oldugunu söler
    {
        public string CustomerCompanyName { get; set; }
        public string CustomerVergiNumber { get; set; }
    }
}
