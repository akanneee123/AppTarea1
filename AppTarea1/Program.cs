// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;

//nombre de la clase
public class Estudiante
{
    //atributos de la clase 
    public String nombre = " ";
    private int edad = 0;
    public double promedio = 0.0;

    //Metodos de la clase 

    //Constructor 
    public Estudiante(string nombre, int edad, double promedio)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.promedio = promedio;
    }


    //Este metodo se encarga de validar si el estudiante mayor de edad o no 
    public bool EsMayorDeEdad()
    {
        if (this.edad >= 18)
        {
            return true;
        }else
        {
            return false;
        }
    }

    //Este metodo se encarga de imprimir en pantalla el nombre 
    // y el promedio del estudiate
    // se utiliza el void porque no va retornar ninguna informacion
    public void MostrarInfo()
    {
        //imprime el nombre
        //writeLine: hace el salto de linea  
        Console.WriteLine(nombre);
        //imprime el promedio
        Console.WriteLine(promedio);

    }


    public static void Main()
    {
        //Registramos la cantida de estudiantes que el usuario desea registrar
        //en esta linea le pedimos al usuario que nos ingrese la cantidad de estudiantes
        Console.WriteLine("Ingrese la cantidad de estudiantes que va a registrar: ");

        //y en esta lo convertimos a un Integer con el parse
        //para capturar la informacion
        int cantEstudiantes = int.Parse(Console.ReadLine());

        //Creacion de la listaEstudiantes
        List<Estudiante> listEstudiantes = new List<Estudiante>();

        //creamos un ciclo for para ingresar los datos de cada estudiante que el usuario ingreso 
        for (int i = 0; i < cantEstudiantes; i++)
        {
            Console.WriteLine($"\nEstudiante {i + 1}:");

            //le solicitamos al usuario que ingrese los valores necesarios 
            Console.Write("Ingrese el nombre del estudiante: ");
            //asignamos el valor ingresado a la variable 
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del estudiante: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el promedio del estudiante: ");
            double promedio = double.Parse(Console.ReadLine());

            // se crea el nuevo estudiante
            Estudiante newEstudiante = new Estudiante(nombre, edad, promedio);
            //agrega a los nuevos estudiantes a la lista
            listEstudiantes.Add(newEstudiante);
        }
        //el contador que ayuda a recorrer la lista 
        int contador = 0;

        Console.WriteLine("\nLos estudiantes con promedio mayor o igual a 70:");
        
        //recorre la lista de estudiantes ingresados por el usuario
        while (contador < listEstudiantes.Count)
        {
            //verifica que el promedio del estudiante sea mayo o igual a 70
            if (listEstudiantes[contador].promedio >= 70)
            {
                listEstudiantes[contador].MostrarInfo();

                // Verifica si el estudiante es mayor de edad
                if (listEstudiantes[contador].EsMayorDeEdad())
                {
                    Console.WriteLine("Este estudiante es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Este estudiante es menor de edad.");
                }

            }
            contador++;
        }


    }
}
