using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Program
    {
        static string[] XO = { " 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 " };

        static void Main(string[] args)
        {
            int player = 1;
            int temp = 0;


            for (int i = 0; i < 9; i++)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("pick Player 1 = X and pick Player 2  = O");
                Console.ForegroundColor = ConsoleColor.Gray;
                imageXO();

                if (temp != 1)

                {

                    if (player % 2 == 0)

                    {
                        Console.WriteLine(" Start Player O \n");
                    }

                    else

                    {
                        Console.WriteLine(" Start Player X \n");
                    }


                    Console.Write(" own number or tabale: ");
                    int adadDorost = Convert.ToInt32(Console.ReadLine());
                    if (adadDorost > 9 || adadDorost <= 0)
                    {
                        Console.WriteLine(" please Enter number  1 to 9");
                        Console.Write(" shomare radif ra entekhb konid ");
                        adadDorost = Convert.ToInt32(Console.ReadLine());
                    }


                    if (XO[adadDorost - 1] != " O " && XO[adadDorost - 1] != " X ")
                    {
                        if (player % 2 == 0)

                        {


                            XO[adadDorost - 1] = " O ";

                            player++;
                        }

                        else

                        {
                            XO[adadDorost - 1] = " X ";
                            player++;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Sorry this row and column is filled \n Please again Enter row & column");


                        Console.ReadKey();
                    }
                    Console.Clear();
                    imageXO();

                    temp = conditionwin();
                }

                if (temp == 1)

                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" Player {0} has won", (player % 2) + 1);
                }

                else

                {
                    Console.WriteLine("The game ended without a winner");
                }


            }
        }
        static void imageXO()

        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                ");
            Console.WriteLine("   |{0}|{1}|{2}|", XO[0], XO[1], XO[2]);
            Console.WriteLine("   |===|===|===|");
            Console.WriteLine("   |{0}|{1}|{2}|", XO[3], XO[4], XO[5]);
            Console.WriteLine("   |===|===|===|");
            Console.WriteLine("   |{0}|{1}|{2}|", XO[6], XO[7], XO[8]);
            Console.WriteLine("                ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
        }

        static int conditionwin()
        {
            if ((XO[0] == XO[1] && XO[1] == XO[2]) || (XO[3] == XO[4] && XO[4] == XO[5]) || XO[6] == XO[7] && XO[7] == XO[8])
            {
                return 1;
            }

            else if ((XO[0] == XO[3] && XO[3] == XO[6]) || (XO[1] == XO[4] && XO[4] == XO[7]) || (XO[2] == XO[5] && XO[5] == XO[8]))
            {
                return 1;
            }

            else if ((XO[0] == XO[4] && XO[4] == XO[8]) || (XO[2] == XO[4] && XO[4] == XO[6]))
            {
                return 1;
            }

            else
            {
                return 0;
            }

        }
    }
}