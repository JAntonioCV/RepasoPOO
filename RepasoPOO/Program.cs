using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");

            //Persona persona = new Persona();

            //persona.Cedula = "0001-10057-455";

            //Persona persona2 = new Persona();

            //persona2.Cedula = "151561-141255-114";

            //Console.WriteLine("Persona 1: " + persona.Cedula);
            //Console.WriteLine("Persona 2: {0} {1}",persona2.Cedula, persona2.Cedula);
            //Console.WriteLine($"Persona 2: {persona.Cedula}");

            //persona.Nombre = "sakjhsdfds";


            Persona persona = new Persona();

            persona.Cedula = "0001-10057-455";


            Console.WriteLine("Ingrese una cedula: ");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese una nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese una apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese una edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una estatura: ");
            double estatura = double.Parse(Console.ReadLine());

            Persona persona1 = new Persona(cedula,nombre,apellido,edad,peso,estatura);

            persona1.MostrarInformacion("004");

            List<Persona> personas = new List<Persona>();

            personas.Add(persona1);


            Console.ReadKey();
        }
    }
}
