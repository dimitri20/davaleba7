using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba7
{
    class Program
    {
        static void Main(string[] args)
        {
            //monacemta sashualo

            Console.WriteLine("###############   1   ##############\n\n");

            Console.WriteLine($" monacemta sashualoa - {average(1, 2, 2, 3, 1)}\n\n");


            //shemoyvanili ricxvebis bechdva
            Console.WriteLine(" ###############  2  ############### \n\n");

            double a, b, c;

            Console.WriteLine("shemoiyvanet ricxvebi ");
            Console.Write("pirveli ricxvi: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");
            Console.Write("meore ricxvi: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");
            Console.Write("mesame ricxvi: ");
            c = Convert.ToDouble(Console.ReadLine());

            printInput(a, b, c);

            Console.Write("\n\n\n");



            Console.WriteLine("###################  3  ################### \n\n");
            //martkutxa samkutxedis povna
            if(isRectangular(10, 6, 8))
            {
                Console.WriteLine("samkutxedi martkutxaa");
            } else
            {
                Console.WriteLine("samkutxedi ar aris martkutxa");
            }

            Console.ReadLine();
        }

        //sashualos povna
        static double average(int a1, int a2, int a3, int a4, int a5)
        {
            double summ = a1 + a2 + a3 + a4 + a5;
            return summ / 5;
        }

        //monacemebis bechdva
        static void printInput(double a1, double a2, double a3)
        {
            Console.Write($"shemoyvanili ricxvebia: {a1}, {a2}, {a3}");
        }

        //samkutxedi aris tu ara martkutxa
        static bool isRectangular(double a, double b, double c)
        {
            double[] sides = new double[3] { a, b, c };
            double[] max = new double[2] { sides[0], 0 };

            //vipovot gverdebs shoris maqsimumi romlis kvadrati toli iqneba
            //danarcheni ori ricxvis kvadratis jamis
            for(int i = 0; i < sides.Length; i++)
            {
                if(sides[i] > max[0])
                {
                    max[0] = sides[i];
                    max[1] = i;
                }
            }

            //gavigot darchenili ori ricxvis kvadratebis jami
            double summ = 0;
            for(int i = 0; i < sides.Length; i++)
            {
                if(i == max[1])
                {
                    continue;
                }
                summ += sides[i]*sides[i];
            }

            //tu darchenili ori ricxvis kvadratebis jami tolia mesamis kvadratis
            //mashin samkutxedi martkutxaa

            bool isRectangular = summ == max[0] * max[0];

            return isRectangular;

        }
    }
}
