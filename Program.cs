using ListasExam1.ListaSimple;

namespace ListasExam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista li = new Lista();
            li.insertar();
            li.insertar();
            li.insertar();
            li.insertar();
            li.insertar();
            Console.Clear();
            Console.WriteLine("Los datos ingresados son: ");
            Console.WriteLine("\n Del primero al ultimo: ");
            li.MostrarListaDO();
            Console.WriteLine("\nDel ultimo al primero: ");
            li.MostrarListaUP();
            Console.ReadLine();
        }
    }
}