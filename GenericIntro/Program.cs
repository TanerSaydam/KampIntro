using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("isim");
            isimler.Add("isim1");
            isimler.Add("isim2");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.İtems)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
