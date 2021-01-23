using System;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryAdd<string, int> nameId = new MyDictionaryAdd<string, int>();
            Console.WriteLine("İsim giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Girdiğiniz ismin ID numarasını giriniz");
            int ID = Convert.ToInt32(Console.ReadLine());
            nameId.Add(isim, ID);

            Console.WriteLine("İsim giriniz: ");
             isim = Console.ReadLine();
            Console.WriteLine("Girdiğiniz ismin ID numarasını giriniz");
            ID = Convert.ToInt32(Console.ReadLine());
            nameId.Add(isim, ID);

            Console.WriteLine("İsim giriniz: ");
            isim = Console.ReadLine();
            Console.WriteLine("Girdiğiniz ismin ID numarasını giriniz");
            ID = Convert.ToInt32(Console.ReadLine());
            nameId.Add(isim, ID);


            Console.WriteLine("Dictionary içinde {0} key {1} value bulunuyor.", nameId.howManyKey, nameId.howManyValue);

            Console.WriteLine("\n\n----------------Key----->Value\n----------------");
            for (int i = 0; i < nameId.howManyKey; i++)
            {
                Console.WriteLine("İsim : {0}------------ID : {1}",nameId.key[i],nameId.value[i]);
            }
            Console.WriteLine("----------------\n");
        }
    }
}
