using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager,konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
