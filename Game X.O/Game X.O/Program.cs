using System;

namespace ConsoleApp58
{
    class Program
    {
        static byte ValidationforByte()
        {
            Console.Write("Введите число: ");
            byte num;
            string imput = Console.ReadLine();
            if (byte.TryParse(imput, out num) && num > 0 && num < 10)
            {
                return num;
            }
            else
            {
                Console.Write("от 1 до 9) ");
                return ValidationforByte();
            }
        }
        static string CheckString()
        {
            string name;
            string Error = "`1234567890-=[];' ,./~!@#$%^&*()_+{}:?";
            bool Error2;
            do
            {
                Error2 = true;
                name = Console.ReadLine();
                if (name == "")
                {
                    Error2 = false;
                }
                foreach (char item1 in name)
                {
                    foreach (char item2 in Error)
                    {
                        if (item1 == item2)
                        {
                            Error2 = false;
                        }
                    }
                }
                if (!Error2)
                {
                    Console.WriteLine("Ошибка! Повторите ввод:");
                }
            } while (!Error2);
            name = name.ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите имя первого игрока: ");
            string player1 = CheckString();
            Console.Write("Введите имя второго игрока: ");
            string player2 = CheckString();
            Console.WriteLine("Интсрукция:");
            Console.Write($" 7  |"); Console.Write($"  8 |"); Console.WriteLine($"  9 |");
            Console.Write($" 4  |"); Console.Write($"  5 |"); Console.WriteLine($"  6 |");
            Console.Write($" 1  |"); Console.Write($"  2 |"); Console.WriteLine($"  3 |");

            string x = "  X |";
            string o = "  O |";
            string z = "    |";
            byte counter = 1;
            int[] numb = new int[9];
            string[] XO = new string[9];
            for (int i = 0; i < XO.Length; i++)
            {
                XO[i] = z;
                numb[i] = 0;
            }
            for (; ; )
            {
                byte number;
                for (; ; )
                {
                    number = ValidationforByte();
                    if (numb[number - 1] == 0)
                    {
                        numb[number - 1] = 1;
                        break;
                    }
                    else
                    {
                        Console.Write("Заново: ");
                    }
                }
                if (counter % 2 != 0)
                {
                    XO[9 - number] = x;
                }
                else
                {
                    XO[9 - number] = o;
                }
                Console.Write($"{XO[2]}"); Console.Write($"{XO[1]}"); Console.WriteLine($"{XO[0]}");
                Console.Write($"{XO[5]}"); Console.Write($"{XO[4]}"); Console.WriteLine($"{XO[3]}");
                Console.Write($"{XO[8]}"); Console.Write($"{XO[7]}"); Console.WriteLine($"{XO[6]}");

                if (XO[0] == x && XO[1] == x && XO[2] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!");
                    break;
                }
                else if (XO[3] == x && XO[4] == x && XO[5] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[6] == x && XO[7] == x && XO[8] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[1] == x && XO[4] == x && XO[7] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[2] == x && XO[5] == x && XO[8] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[0] == x && XO[3] == x && XO[6] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[2] == x && XO[4] == x && XO[6] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[0] == x && XO[4] == x && XO[8] == x)
                {
                    Console.WriteLine($"{player1} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[0] == o && XO[1] == o && XO[2] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[3] == o && XO[4] == o && XO[5] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[6] == o && XO[7] == o && XO[8] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[1] == o && XO[4] == o && XO[7] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[2] == o && XO[5] == o && XO[8] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[0] == o && XO[3] == o && XO[6] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                else if (XO[2] == o && XO[4] == o && XO[6] == o)
                {
                    Console.WriteLine($"{player2} ПОБЕДИЛ!!!"); break;

                }
                counter++;
                if (counter == 10)
                {
                    Console.WriteLine("Победила дружба");
                    break;
                }
            }
        }
    }
}
