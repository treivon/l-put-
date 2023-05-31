namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali: ");
            Console.WriteLine("1 - Skip");
            Console.WriteLine("2 - Where");
            Console.WriteLine("3 - If ja Else");
            Console.WriteLine("4 - ForLoop");




            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Skip();

                    break;
                case 2:
                    WhereLINQ();
                    break;

                case 3:
                    IfElse();
                    break;

                case 4:
                    ForLoop();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;



            }
        }


        public static void Skip()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("----------Skip--------------");
            //jätab esimesed kolm rida välja
            var skip = PeopleList.peoples.Skip(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void IfElse()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
               "veateate. Kui on õige, siis ütleb, " +
               "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/kasutajad/opilane/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/users/opilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }


        }
        public static void ForLoop()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 0; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i + 1; j++)
                {
                  
                    Console.Write(i + j); 
                }
                Console.Write("\n");
            }
        }
    }
}
