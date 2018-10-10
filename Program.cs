using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AGREGAR COLLECTIONS
using System.Collections;

namespace ConsoleApplication1
{
   class CapturaDeCalificaciones
    {
       //DECLARACION DE VARIABLES
       string NombreA;
       int Calificacion;

       //DECLARACION DE LISTAS
        ArrayList Lista1;
        ArrayList Lista2;
        ArrayList Lista3;

        public CapturaDeCalificaciones()
        {
            //NEW LIST
            Lista1 = new ArrayList();
            Lista2 = new ArrayList();
            Lista3 = new ArrayList();
        }

       //CREACION DE PUBLIC VOID
        public void Datos()
        {
            int XX;
            //CAPTURA DE ALUMNOS QUE DESEAS INGRESAR
            Console.WriteLine("¿Cuantos alumnos deseas capturar? ");
            XX = int.Parse(Console.ReadLine());
            //FOR PARA CICLAR LA CAPUTRA DE ALUMNOS
            for (int i = 0; i < XX; i++)
            {
                Console.WriteLine("Ingresa el nombre del alumno numero {0}: ", i + 1);
                NombreA = Console.ReadLine();
                //GUARDAR LISTA DE ALUMNOS EN "Lista1"
                Lista1.Add(NombreA);
            }

            //----------------------------------
            
            //FOR PARA ACUMULAR CALIFICACIONES
            for (int x = 0; x < Lista1.Count; x++)
            {
                //INGRESAR CALIFICACIONES
                Console.WriteLine("Ingresa calificacion del alumno numero {0}: ", x+1);
                Calificacion = int.Parse(Console.ReadLine());
                //GUARDAR CALIFICACIONES EN "Lista2"
                Lista2.Add(Calificacion);

            }
        }

        public void Imprimir()
        {
          //IMPRIMIR ALUMNOS
            Console.WriteLine("Nombre de alumnos: ");
            foreach(var pug in Lista1)
            {
                Console.WriteLine(pug);
            }
            //IMPRIMIR CALIFICACIONES
            Console.WriteLine("Calificaciones de alumnos:");
            foreach (var pong in Lista2)
            {
                Console.WriteLine("Calificacion: " + pong);                    
            }

            Console.ReadKey();
        }
   
        static void Main(string[] args)
        {
            //CREACION DEL OBJETO
            CapturaDeCalificaciones figura1 = new CapturaDeCalificaciones();
            figura1.Datos();
            Console.Clear();
            figura1.Imprimir();
            Console.ReadKey();
        }
    }
}
