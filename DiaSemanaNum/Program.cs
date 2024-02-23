using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 7 para obtener el día de la semana: ");
        int v= int.Parse(Console.ReadLine());
        int numeroDia = v;

        string diaSemana = ObtenerDiaSemana(numeroDia);

        if (diaSemana != null)
        {
            Console.WriteLine($"El día de la semana correspondiente al número {numeroDia} es {diaSemana}");
        }
        else
        {
            Console.WriteLine("Número no válido. Por favor, ingrese un número del 1 al 7.");
        }
    }

    static string ObtenerDiaSemana(int numero)
    {
        switch (numero)
        {
            case 1:
                return "Lunes";
            case 2:
                return "Martes";
            case 3:
                return "Miércoles";
            case 4:
                return "Jueves";
            case 5:
                return "Viernes";
            case 6:
                return "Sábado";
            case 7:
                return "Domingo";
            default:
                return null; // Indica que el número no es válido
        }
    }
}

