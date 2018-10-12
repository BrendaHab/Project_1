using System;
using System.Collections.Generic;
using Classes;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Crearemos tres figuras, un circulo, un rectangulo, y un triangulo");

            List<Figures> figs = new List<Figures>();
            figs.Add(new Circle());
            Console.WriteLine("Ingrese el radio");
            figs[0].setSides();

            figs.Add(new Triangle());
            Console.WriteLine("Lados del triangulo");
            figs[1].setSides();

            figs.Add(new Rectangle());
            Console.WriteLine("Lados del rectangulo");
            figs[2].setSides();


            Console.WriteLine("Se imprimiran area y perimetro del circulo, triangulo y rectangulo respectivamente");

            foreach(Figures item in figs){
                Console.WriteLine(item.GetType());
                
                Console.Write("El perimetro es ");
                Console.Write (item.Perimeter());

                Console.WriteLine("");

                Console.Write("El area es ");
                Console.Write(item.Area());

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");            
            }                 
            
        } 
    }
}
