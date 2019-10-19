using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_tareas
{
    class Principal
    { //aqui se crea un metodo llamado bienvenido y lo llamos desde el program
        public void Bienvenido()
        {
            Console.WriteLine("Sea bienvenido a la lista de tareas");
            Menu();
            Console.ReadLine();

        }

        //Aqui creamos el metodo menu y damos la opcion al usuario que eliga algunas de las siguientes opciones
        public void Menu()
        {
            Console.WriteLine("Seleccione alguna de estas opciones");
            Console.WriteLine("1-Crear Tarea");
            Console.WriteLine("2-Ver lista de tareas");
            Console.WriteLine("3-Tarea(Detalles)");
            Console.WriteLine("4-Status");
            Console.WriteLine("5-Cambiar estatus");

            String b = Console.ReadLine();

            //Aqui creamos el switch departe los metodos que estan abajo que tienen un arreglo y se usa como una lista y llamamos los metodos y se elige dependiendo del usuario
            switch(b)
            {
                case "1":
                    Creacion_Tarea();
                    break;

                case "2":
                    TareasM(ListaT);
                    break;

                case "3":
                    Tarea_detalles(ListaT);
                    break;

                case "4":
                    Status(ListaT);                   
                    break;

                case "5":
                    CambiarStatus(ListaT);
                    break;

            }
            
        }


        //Creamos un arreglo tareas ya que sera el arreglo que utilizaremos en todos los metodos
        Tareas[] ListaT = new Tareas[2];
            
// aqui creamos el metodo de creacion de tareas 
        public void Creacion_Tarea()
        {
            for (int a=0; a < ListaT.Length; a++)
            {
                Tareas T = new Tareas();
                Console.WriteLine("Nombre:");
                T.Nombre = Console.ReadLine();
                Console.WriteLine("Nombre de la tarea");
                T.NombreT = Console.ReadLine();
                Console.WriteLine("Fecha");
                T.Fecha = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Hora");
                T.Hora = Console.ReadLine();
                Console.WriteLine("Status(Iniciado, En proceso, en Terminacion)");
                T.Status = Console.ReadLine();

                ListaT[a] = T;
                Console.Clear();
                

            }
            Menu();
        }
        //Metodo en donde se muestran las tareas
        public void TareasM(Tareas[] T)
        {
            Console.WriteLine("Tareas:");
            for (int a = 0; a < T.Length; a++)
            {
                Console.WriteLine("Nombre de la tarea:" + T[a].NombreT);
            }
            Console.ReadKey();
            Console.Clear();
            Menu();

        }

        //Metodos en donde se muestran los detalles de la tarea
        public void Tarea_detalles(Tareas [] De)
        {
            //Se intancia la clase principal
            Principal Pi = new Principal();
            string Nombre;
            //Se le indica al usuario que ingrese el nombre que agrego a la lista
            Console.WriteLine("Favor de ingresae su nombre:");
            Nombre = Console.ReadLine();

            //Se imprime los datos de la tarea siempre y cuando coincida el nombre que agrego
            for(int a = 0; a < De.Length; a++)
            {
                if (De[a].Nombre==Nombre)
                {
                    Console.WriteLine("Nombre:" + De[a].Nombre);
                    Console.WriteLine("Nombre de la tarea:" + De[a].NombreT);
                    Console.WriteLine("Fecha:" + De[a].Fecha);
                    Console.WriteLine("Hora:" + De[a].Hora);
                    Console.WriteLine("Status:" + De[a].Status);

                }

            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        //Metodo donde se muestra el nombre de tarea y el status de ella
        public void Status(Tareas[] St)
        {
            //Aqui se imprime los status y nom bre de la tarea
            Console.WriteLine("Mostrar Status");
            for (int a = 0; a < St.Length; a++)
            {
                Console.WriteLine("Nombre de la tarea:" + St[a].NombreT);
                Console.WriteLine("Detalles de Status:" + St[a].Status);
            }
            Console.ReadLine();
            Console.Clear();
            Menu();
                
        }
        //aqui se cambiaria el status(metodo)
        public void CambiarStatus(Tareas[] cs)
        {
         //Aqui se imprime el status anteior y se modifica y se actualiza la lista

            Console.WriteLine("Cambiar status:");
            for (int a = 0; a <cs .Length; a++)
            {
                

                Console.WriteLine("Status:"+ cs[a].Status);
                cs[a].Status = Console.ReadLine();
                
                
            }
            Console.ReadLine();
            Console.Clear();
            Menu();
        }


    }
}
