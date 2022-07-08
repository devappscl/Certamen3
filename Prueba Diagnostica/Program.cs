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
           

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');
                
                //*********Con lista de objetos
                data item = new data();
                item.APERTURA = double.Parse(dataLinea[0]);
                item.MAXIMO = double.Parse(dataLinea[1]);
                item.MINIMO = double.Parse(dataLinea[2]);
                item.CIERRE = double.Parse(dataLinea[3]);
                datos.Add(item);
                line = sr.ReadLine();
                contador++;
            }

            //MOSTRAR EL MAYOR VALOR DE CADA UNA DE LAS LISTAS.
            buscaMayor(datos);


            Console.ReadKey();


        }

        //Busca mayor en la lista de objetos.
        public static void buscaMayor(List<data> datos)
        {
            foreach (var item in datos)
            {
                
            }
        }


       
    }

}