using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Futbol> takim = new List<Futbol>();
            takim.Add(new Futbol("Kaleci",1));
            takim.Add(new Defans("defans1", 2));
            takim.Add(new Defans("defans2", 3));
            takim.Add(new Defans("defans3", 4));
            takim.Add(new Defans("defans4", 5));
            takim.Add(new OrtaSaha("ortasaha1", 6));
            takim.Add(new OrtaSaha("ortasaha2", 7));
            takim.Add(new OrtaSaha("ortasaha3", 8));
            takim.Add(new OrtaSaha("ortasaha4", 9));
            takim.Add(new Forvet("forvet1", 10));
            takim.Add(new Forvet("forvet2", 11));
            Random rastgele = new Random();
            int formaNo;
            int pasKontrol=12;
            formaNo = rastgele.Next(1, 12);
            Boolean golOlabilir = true;
            for (int i = 0; i < 3; i++)
            {
                while (pasKontrol == formaNo)
                {
                    formaNo = rastgele.Next(1, 12);
                }
                pasKontrol = formaNo;
                
                if (!takim[formaNo-1].passVer())
                {
                    Console.WriteLine(formaNo + "Numaralı Oyuncunun Pası Başarısız.");
                    golOlabilir = false;
                    break;
                }
                else
                {
                    Console.WriteLine(formaNo + "Numaralı Oyuncunun Pası Başarılı.");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine(formaNo + "Numaralı kaleciyle karşı karşıya");
            System.Threading.Thread.Sleep(1000);
            if (golOlabilir = true)
            {
                if (takim[formaNo-1].golVurusu())
                {
                    Console.WriteLine(formaNo + "GOLLLLLLLLLLL !...");
                }
                else
                {
                    Console.WriteLine( "Az farkla Kaçırdı !...");
                }
            }
            Console.ReadLine();

        }
    }
}
