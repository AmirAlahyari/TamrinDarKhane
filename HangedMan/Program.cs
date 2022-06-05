using System;
using System.Collections.Generic;

namespace HangedMan
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] selectedWorld = GetRandomWord();

            char[] selectedWorldCopy = CopyFromSelectedWord(selectedWorld);

            Console.WriteLine(selectedWorld);

            Console.WriteLine("shoma baaraye nejat dostetan faght 6 eshtebah forsat darid ta kalame nejat az edam ra peyda konid");

            int tedadeshtebah = 0;
            while (tedadeshtebah < 6)
            {
                Console.WriteLine($"charecter ra vared konid");
                char importedChar = Convert.ToChar(Console.ReadLine());

                bool isExist = IsExistImportedCharInSelectedWord(selectedWorld, importedChar, ref selectedWorldCopy);
                if (isExist == true)
                {
                    Console.WriteLine("dorost hads zadid braye nejat edame dahid");
                    Console.WriteLine(selectedWorldCopy);

                    bool isSelectedWorldCopyMosaviSelectedWorld = CheckSelectedWorldCopyMosaviSelectedWorld(selectedWorld, selectedWorldCopy);
                    if (isSelectedWorldCopyMosaviSelectedWorld)
                    {
                        break;
                    }
                }
                else
                {
                    tedadeshtebah++;
                    PirintDar(tedadeshtebah);
                }
            }
            
            if (tedadeshtebah < 6)
            {
                Console.WriteLine("shoma dostetan ra nejat dadid :)) ");
            }
            else
            {
                Console.WriteLine(" dostetan b dar avikhte shod :(( ");
            }

            Console.ReadKey();
        }

        private static bool CheckSelectedWorldCopyMosaviSelectedWorld(char[] selectedWorld, char[] selectedWorldCopy)
        {
            for (int i = 0; i < selectedWorld.Length; i++)
            {
                if (selectedWorld[i] != selectedWorldCopy[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void PirintDar(int tedadEsthtebah)
        {
            switch (tedadEsthtebah)
            {
                case 1:
                    Console.WriteLine
                      (@"          
                                                        +---+
                                                        |   o
                                                        |    
                                                        |
                                                       ---  
                            ");
                    break;
                case 2:
                    Console.WriteLine
                  (@"          
                                                        +---+
                                                        |   o
                                                        |   | 
                                                        |
                                                       ---  
                            ");
                    break;

                case 3:
                    Console.WriteLine
                      (@"          
                                                        +---+
                                                        |   o
                                                        |   |\
                                                        |
                                                       ---  
                            ");
                    break;
                case 4:
                    Console.WriteLine
                  (@"          
                                                        +---+
                                                        |   o
                                                        |  /|\ 
                                                        |
                                                       ---  
                            ");
                    break;
                case 5:
                    Console.WriteLine
                  (@"          
                                                        +---+
                                                        |   o
                                                        |  /|\
                                                        |    \
                                                       ---  
                            ");
                    break;
                case 6:
                    Console.WriteLine
                  (@"          
                                                        +---+
                                                        |   o
                                                        |  /|\
                                                        |  / \
                                                       ---  
                            ");
                    break;
            }
        }

        private static bool IsExistImportedCharInSelectedWord(char[] selectedWorld, char importedChar, ref char[] selectedWorldCopy)
        {
            bool isMatch = false;
            for (int j = 0; j < selectedWorld.Length; j++)
            {
                if (importedChar == selectedWorld[j])
                {
                    selectedWorldCopy[j] = importedChar;
                    isMatch = true;
                }
            }

            return isMatch;
        }

        private static char[] CopyFromSelectedWord(char[] selectedWorld)
        {
            char[] selectedWorldCopy = new char[selectedWorld.Length];
            for (int i = 0; i < selectedWorldCopy.Length; i++)
            {
                selectedWorldCopy[i] = Convert.ToChar("_");
            }

            return selectedWorldCopy;
        }

        private static char[] GetRandomWord()
        {
            List<string> myWords = new List<string>
            {
                "MrAmir",
                "MrBehzad",
                "MrKeyvan",
                "MrKiyanosh",
                "MrSaeed",
                "MrPezhman"
            };

            Random rnd = new Random();
            int item = rnd.Next(0, 5);
            string selectedWord = myWords[item];
            return selectedWord.ToLower().ToCharArray();
        }
    }
}
