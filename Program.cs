using System;
using System.Collections.Generic;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World4!");
            var names = new List<string> {"henry","Pancho", "Fatima","Sofia","Daniel" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("numero");
            string numParImp=Console.ReadLine();
            int num= Int32.Parse(numParImp);
            if (num % 2==0)
                Console.WriteLine("PAR") ;
            else
                Console.WriteLine("Impar") ;

            Console.WriteLine("numero Factorial");
            string numfact=Console.ReadLine();
            int nfac=1;
            int num2= Int32.Parse(numfact);
            for (int i = 1; i <= num2; i++)
            {
                nfac=nfac * i;
            }
            Console.WriteLine(nfac);

            Console.WriteLine("numero sumaenteros");
            numfact=Console.ReadLine();
            num2= Int32.Parse(numfact);
            Console.WriteLine(SumaEnt(num2));

            Console.WriteLine("numero base triangulo");
            numfact=Console.ReadLine();
            int numbase= Int32.Parse(numfact);
            For (int i=1 ; i<=numbase; i++)
            {
               Console.WriteLine("base(i, numbase)");
            }

        }

     static int SumaEnt (int valor)
        {
        int valres;
        valres=0;
        //for (int i = 2; i <= valor; i++)
        //    {
        //       valres=valres+i++;
        //    } 
        for (int i = 1; i <= valor; i++)
            {
               if ((i % 2)==0) 
               valres=valres+i;
            } 
            return valres;  
        }

        static string base (int Cant, int numbase)
        {
          string espacio = "";
          //int nesp= (numbase - Cant;
          //for (int i=1 ; i<=nesp; i++)
          //{
           //  espacio=espacio+" ";
          //}

          string base="";
          //for (int i=1 ; i<=cant; i++)
          //{
          //   base=base+"*";
          //}
          //base=espacio+base;
          return base;
        }
    }
}
