using PilasColasApp.Clases;
internal class Program
{
    static void Main(string[] args)
    {
        var pila = new Pila();
        var cola = new Cola();
        for (int i = 0; i < 5; i++)
        {
            int nro = Convert.ToInt32(Console.ReadLine());
            pila.Añadir(nro);
            cola.Añadir(nro);
        }
        Console.WriteLine("Primero \nPila: " + pila.Primero() + "\nCola: " + cola.Primero());

        Console.WriteLine("Extraer primero \nPila: " + pila.Extraer() + "\nCola: " + cola.Extraer());

        Console.WriteLine("Primero \nPila: " + pila.Primero() + "\nCola: " + cola.Primero());

    }
}