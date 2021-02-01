using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        // seçilen krediye göre kredi hesaplaması
        //seçilen yere loglama yapma
        public void DoRecourse(ICreditManager creditManager, ILoggerService loggerService) 
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void CreditPreliminaryİnformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
