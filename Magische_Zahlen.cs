/***********************************************************************************************
 * Übungsnr:        11                                     
 * Programmname:    MagicNumber
 * Autor:           Michael Bucek                            
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Für welche dreistellige Zahl gilt:    
 *   EinerZiffer³ + ZehnerZiffer³ + HunderterZiffer³ = zahl  (153, 370,371,407)
*/

using System;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //dreistellige Zahl besteht aus den Stellen: u v w
            for (int u = 1; u <= 9; u++)
            {
                for (int v = 0; v <= 9; v++)
                {
                    for (int w = 0; w <= 9; w++)
                    {
                        if (u * u * u + v * v * v + w * w * w == u * 100 + v * 10 + w)
                        {
                            Console.WriteLine("Eine magische Zahl lautet {0}{1}{2} da {0}^3+{1}^3+{2}^3={0}{1}{2}",u,v,w);
                        }
                    }
                }
            }
        }

    }
}
