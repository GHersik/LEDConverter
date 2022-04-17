using System;
using System.Collections.Generic;

namespace LED_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down numbers to convert:");
            string wejscie = Console.ReadLine();
            
            List<int> dane = new List<int>();

            foreach (var item in wejscie)
            {
                dane.Add(item - 48);
            }

            int[] tabdane = dane.ToArray();

            string[,] zero = new string[3, 3]
                       {
                {" ", "_", " "},
                {"|", " ", "|"},
                {"|", "_", "|"}
                       };

            string[,] I = new string[3, 3]
            {
                {" ", " ", " "},
                {" ", " ", "|"},
                {" ", " ", "|"}
            };

            string[,] II = new string[3, 3]
            {
                {" ", "_", " "},
                {" ", "_", "|"},
                {"|", "_", " "}
            };

            string[,] III = new string[3, 3]
            {
                {" ", "_", " "},
                {" ", "_", "|"},
                {" ", "_", "|"}
            };

            string[,] IV = new string[3, 3]
            {
                {" ", " ", " "},
                {"|", "_", "|"},
                {" ", " ", "|"}
            };

            string[,] V = new string[3, 3]
            {
                {" ", "_", " "},
                {"|", "_", " "},
                {" ", "_", "|"}
            };

            string[,] VI = new string[3, 3]
            {
                {" ", "_", " "},
                {"|", "_", " "},
                {"|", "_", "|"}
            };

            string[,] VII = new string[3, 3]
            {
                {" ", "_", " "},
                {" ", " ", "|"},
                {" ", " ", "|"}
            };

            string[,] VIII = new string[3, 3]
            {
                {" ", "_", " "},
                {"|", "_", "|"},
                {"|", "_", "|"}
            };

            string[,] VIV = new string[3, 3]
            {
                {" ", "_", " "},
                {"|", "_", "|"},
                {" ", " ", "|"}
            };

            string[][,] TABjag = new string[tabdane.Length][,];


            for (int j = 0; j < tabdane.Length; j++)
            {
                if (tabdane[j] == 0)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(zero, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 1)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(I, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 2)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(II, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 3)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(III, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 4)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(IV, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 5)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(V, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 6)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(VI, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 7)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(VII, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 8)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(VIII, 0, TABjag[j], 0, 9);
                }

                else if (tabdane[j] == 9)
                {
                    TABjag[j] = new string[3, 3];
                    Array.Copy(VIV, 0, TABjag[j], 0, 9);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result");
            for (int k = 0; k < TABjag.GetLength(0); k++)
            {
                for (int row = 0; row < 1; row++)
                {
                    for (int col = 0; col < TABjag[k].GetLength(1); col++)
                    {
                        Console.Write(TABjag[k][row, col]);
                    }
                }
            }


            Console.WriteLine();

            for (int k = 0; k < TABjag.GetLength(0); k++)
            {
                for (int row = 1; row < 2; row++)
                {
                    for (int col = 0; col < TABjag[k].GetLength(1); col++)
                    {
                        Console.Write(TABjag[k][row, col]);
                    }
                }
            }

            Console.WriteLine();

            for (int k = 0; k < TABjag.GetLength(0); k++)
            {
                for (int row = 2; row < 3; row++)
                {
                    for (int col = 0; col < TABjag[k].GetLength(1); col++)
                    {
                        Console.Write(TABjag[k][row, col]);
                    }
                }
            }
        }
    }
}
