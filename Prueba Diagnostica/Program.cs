using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Prueba_Diagnostica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();

            //APERTURA MAXIMO  MINIMO CIERRE
            double[] APERTURA = new double[200];
            double[] MAXIMO = new double[200];
            double[] MINIMO = new double[200];
            double[] CIERRE = new double[200];

            double[] APERTURAOR = new double[200];
            double[] MAXIMOOR = new double[200];
            double[] MINIMOOR = new double[200];
            double[] CIERREOR = new double[200];


            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');

                //*********Con arreglos separados
                APERTURA[contador] = double.Parse(dataLinea[0]);
                MAXIMO[contador] = double.Parse(dataLinea[1]);
                MINIMO[contador] = double.Parse(dataLinea[2]);
                CIERRE[contador] = double.Parse(dataLinea[3]);

                APERTURAOR[contador] = double.Parse(dataLinea[0]);
                MAXIMOOR[contador] = double.Parse(dataLinea[1]);
                MINIMOOR[contador] = double.Parse(dataLinea[2]);
                CIERREOR[contador] = double.Parse(dataLinea[3]);

                line = sr.ReadLine();

                contador++;
            }


            Array.Sort(APERTURAOR);
            Array.Sort(MAXIMOOR);
            Array.Sort(MINIMOOR);
            Array.Sort(CIERREOR);



            #region
            int indice = 0;
            int regresivamayor = 199;
            bool op = true;


            while (op)
            {
           
                for (int i = 0; i < 200; i++)
                {
                
                    if (APERTURA[i].Equals(APERTURAOR[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (APERTURA.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion APERTURA" + APERTURA[indice]);
                    
                    op = false;
                    break;
                }
                else
                {
                    regresivamayor = regresivamayor - 1;
                    op = true;
                }
            }
            #endregion


            #region

            op = true;

            while (op)
            {

                for (int i = 0; i < 200; i++)
                {

                    if (MAXIMO[i].Equals(MAXIMOOR[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (MAXIMO.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion MAXIMO" + MAXIMO[indice]);

                    op = false;
                    break;
                }
                else
                {
                    regresivamayor = regresivamayor - 1;
                    op = true;
                }
            }
            #endregion




            Console.ReadKey();


        }

        


       
    }

}