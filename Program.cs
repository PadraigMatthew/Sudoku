using System;
namespace Sudoku
{
    class Program
    {
        static int[,] ints2 = new int[9, 9];
        static bool[,] fixedValue = new bool[9, 9];
        static void Main(string[] args)
        {
            
            Ajouter(8, 0, 9);
            Ajouter(7, 3, 9);
            Ajouter(6, 6, 9);
            Ajouter(5, 1, 9);
            Ajouter(4, 4, 9);
            Ajouter(3, 7, 9);
            Ajouter(2, 2, 9);
            Ajouter(1, 5, 9);
            Ajouter(0, 8, 9);
            //
            // Ajouter(5, 2, 9);
            //
            //Ajouter(5, 7, 9);
            //

            Ajouter(0, 0, 1);
            Ajouter(1, 8, 1);
            Ajouter(2, 5, 1);
            Ajouter(4, 7, 1);
            Ajouter(5, 4, 1);
            Ajouter(6, 1, 1);
            Ajouter(7, 6, 1);
            Ajouter(8, 3, 1);
            Ajouter(3, 2, 1);

            /* Ajouter(5, 5, 1);
            Ajouter(6, 5, 1);
            Ajouter(7, 4, 1); */

            Afficher();
            Console.ReadKey();
            TrouverSolution();

            Console.Clear();

            Afficher();
        }

        private static void TrouverSolution()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (fixedValue[j,i])
                    {
                        continue;
                    }
                    Ajouter(j, i, 1);
                }
            }
        }

        private static void Afficher()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(ints2[j, i]);
                }
                Console.WriteLine();
            }


        }

        static bool Ajouter(int x, int y, int value)
        {
            if(value > 9)
            {
                return false;
            }

            if (!CheckLine(y, value))
            {
                return false;
            }

            if (!CheckColonne(x, value))
            {
                return false;
            }

            if (!CheckGrill(x, y, value))
            {
                return false;
            }

            ints2[x, y] = value;
            fixedValue[x, y] = true;
            return true;
        }

        private static bool CheckLine(int y, int value)
        {
            for(int j = 0; j < 9; j++)
            {
                if (ints2[j, y] == value)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckColonne(int j, int value)
        {
            for (int y = 0; y < 9; y++)
            {
                if (ints2[j, y] == value)
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckGrill(int col, int line, int value)
        {
            /*permet de verifier dans la grille que les numeros n'ont pas les memes valeurs*/
            int startcol = col - col % 3;
            int startline = line - line % 3;

            for(int i = startline; i < startline + 3; i++)
            {
                for(int j = startcol; j < startcol + 3; j++)
                {
                    if (ints2[j, i] == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void augmentation(int y, int j) 
        {
            Random aleatoire = new Random();
            int entierUnChiffre= aleatoire.Next(1,9);

        }
    }
}
