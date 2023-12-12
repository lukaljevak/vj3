using System;
					
public class Program
{
	public static void Main()
	{
            int x, y, z;

            Console.WriteLine("Unesite duljinu stranice x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu stranice y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu stranice z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                {
                    Console.WriteLine("Stranice čine pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Stranice ne čine pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Unesene vrijednosti stranica nisu smislene.");
            }
        }
	}