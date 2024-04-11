using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPOO
{
    //Definicion clase persona
    internal class Persona
    {
        //Atributos
        public string Cedula { get; set; }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public string Apellido { get; set; }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Peso { get; set; }

        private double estatura;

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        //Constructor Simple
        public Persona()
        {

        }

        //Constructor con parametros
        public Persona(string cedula, 
                       string nombre, 
                       string apellido, 
                       int edad, 
                       double peso,
                       double estatura)
        {
            Cedula = cedula;
            this.nombre = nombre;
            Apellido = apellido;
            this.edad = edad;
            Peso = peso;
            this.estatura = estatura;
        }

        //Metodos
        public void MostrarInformacion(string cedulaborrar) 
        {
            Console.WriteLine("Cedula {0}",Cedula);
            Console.WriteLine("Nombre {0}",nombre);
            Console.WriteLine("Apellido {0}",Apellido);
            Console.WriteLine("Edad {0}",edad);
            Console.WriteLine("Peso {0}",Peso);
            Console.WriteLine("Estatura {0}",Estatura);
        }

        private void Eliminar()
        {
            MostrarInformacion("001");
        }
    }
}
