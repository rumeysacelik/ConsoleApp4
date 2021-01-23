using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap (konutKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

           

        }
    }
}
