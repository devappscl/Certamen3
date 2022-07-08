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
            List<data> datos = new List<data>();
            data[] arrayData = new data[200];
            //APERTURA MAXIMO  MINIMO CIERRE
            //double[] APERTURA = new double[200];
            //double[] MAXIMO = new double[200];
            //double[] MINIMO = new double[200];
            //double[] CIERRE = new double[200];

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');
                //*********Con arreglo de objetos
                arrayData[contador] = new data();
                arrayData[contador].APERTURA = double.Parse(dataLinea[0]);
                arrayData[contador].MAXIMO = double.Parse(dataLinea[1]);
                arrayData[contador].MINIMO = double.Parse(dataLinea[2]);
                arrayData[contador].CIERRE = double.Parse(dataLinea[3]);

                //*********Con arreglos separados
                //APERTURA[contador] = double.Parse(dataLinea[0]);
                //MAXIMO[contador] = double.Parse(dataLinea[1]);
                //MINIMO[contador] = double.Parse(dataLinea[2]);
                //CIERRE[contador] = double.Parse(dataLinea[3]);
                //*********Con lista de objetos
                //data item = new data();
                //item.APERTURA = double.Parse(dataLinea[0]);
                //item.MAXIMO = double.Parse(dataLinea[1]);
                //item.MINIMO = double.Parse(dataLinea[2]);
                //item.CIERRE = double.Parse(dataLinea[3]);
                //datos.Add(item);
                line = sr.ReadLine();
                contador++;
            }
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(arrayData[i].APERTURA + " " + arrayData[i].MAXIMO + " " + arrayData[i].MINIMO + " " + arrayData[i].CIERRE);
            }

            //foreach (var item in datos)
            //{
            //    Console.WriteLine(item.APERTURA);
            //}
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine(APERTURA[i]+" "+ MAXIMO[i]+" "+ MINIMO[i]+" "+ CIERRE[i]);
            //}
            Console.ReadKey();


        }
    }

}