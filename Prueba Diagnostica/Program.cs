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

            Array.Reverse(APERTURAOR);
            Array.Reverse(MAXIMOOR);
            Array.Reverse(MINIMOOR);
            Array.Reverse(CIERREOR);

            //MAXIMOS
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++ MAXIMOS ++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            #region
            int indice = 0;
            int regresivamayor = 199;
            bool op = true;


            while (op)
            {
           
                for (int i = 0; i < 200; i++)
                {
                
                    if (APERTURA[i].Equals(APERTURA[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (APERTURA.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion APERTURA MAXIMO = " + APERTURA[indice]);
                    
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
                    Console.WriteLine("Cumple la condicion MAXIMO MAXIMO = " + MAXIMO[indice]);

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

                    if (MINIMO[i].Equals(MINIMOOR[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (MINIMO.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion MINIMO MAXIMO = " + MINIMO[indice]);

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

                    if (CIERRE[i].Equals(CIERREOR[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (MAXIMO.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion CIERRE MAXIMO = " + CIERRE[indice]);

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

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++ MINIMOS ++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            // MINIMOS
            op = true;

            #region
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
                    Console.WriteLine("Cumple la condicion APERTURA MINIMO = " + APERTURA[indice]);

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
                    Console.WriteLine("Cumple la condicion MAXIMO MINIMO = " + MAXIMO[indice]);

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

                    if (MINIMO[i].Equals(MINIMOOR[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (MINIMO.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion MINIMO MINIMO = " + MINIMO[indice]);

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

                    if (CIERRE[i].Equals(CIERREOR[regresivamayor]))
                    {
                        indice = i;
                    }

                }

                int init = indice - 10;
                int end = indice + 10;

                if (MAXIMO.Length > end && init > 0)
                {
                    Console.WriteLine("Cumple la condicion CIERRE MINIMO = " + CIERRE[indice]);

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