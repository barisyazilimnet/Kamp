﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HomeCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }
    }
}
