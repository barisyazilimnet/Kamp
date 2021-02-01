using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NeedCreditManager needCreditManager = new NeedCreditManager();
            ICreditManager needCreditManager = new NeedCreditManager();
            needCreditManager.Calculate();

            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            vehicleCreditManager.Calculate();

            HomeCreditManager homeCreditManager = new HomeCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();
            homeCreditManager.Calculate(); */

            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.DoRecourse(homeCreditManager, new DatabaseLoggerService()); // direk method içindede newlenebilir

            List<ICreditManager> credits = new List<ICreditManager>() { homeCreditManager, needCreditManager };
            //recourseManager.CreditPreliminaryİnformation(credits);
        }
    }
}
