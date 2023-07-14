using System;
using System.Collections.Generic;

namespace Project_ProizvPraktika_Xz11_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int result = 0;
            int br = 1;
            List<int> greshki = new List<int>();
            string[] VerniOtg = new string[3];
            string[] VsichkiOtg = new string[3];
            Console.WriteLine("1. Изберете подходящото за постаяне в празното пространство изображение.");
            Console.WriteLine("A) B) C) D) E) F)");
            VerniOtg[0] = "A";
            VsichkiOtg[0] = Console.ReadLine();
            if (VsichkiOtg[0] == VerniOtg[0] || VsichkiOtg[0] == "A)") result++;
            else greshki.Add(br);
            br++;
            Console.WriteLine("2. Изберете подходящото число или цифра.");
            Console.WriteLine("235; 5; 259; 311; 198; 298;");
            VerniOtg[1] = "259";
            VsichkiOtg[1] = Console.ReadLine();
            if (VsichkiOtg[1] == VerniOtg[1]) result++;
            else greshki.Add(br);
            br++;
            Console.WriteLine("3. Въведете отговор, който считате за подходящ.");
            Console.WriteLine("528173 - дърво; 11122924 - ключ; 18161213 - ?");
            VerniOtg[2] = "йрщб";
            VsichkiOtg[2] = Console.ReadLine();
            if (VsichkiOtg[2] == VerniOtg[2]) result++;
            else greshki.Add(br);
            Console.WriteLine($"Отговорено е вярно на {result} от 3-те въпроса.");
            Console.WriteLine("Желаете ли да видите къде са грешките ви?");
            Console.WriteLine("Да/Не");
            string otg = Console.ReadLine();
            if (otg == "Да")
            {
                for (int i = 0; i < greshki.Count; i++)
                {
                    Console.WriteLine($"Отговор на {greshki[i]}-ия въпрос е \"{VerniOtg[greshki[i] - 1]}\", а не \"{VsichkiOtg[greshki[i] - 1]}\".");
                }
            }
        }
    }
}
