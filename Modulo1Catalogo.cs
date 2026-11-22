using System;

// MODULO 1: CATALOGO (opcion 1 del menu)
class Program
{
    static string[] nombres = {
        "Polo basico",
        "Camisa manga larga",
        "Jean clasico",
        "Short deportivo",
        "Gorra",
        "Vestido de fiesta largo",
        "Vestido casual",
        "Vestido de noche",
        "Falda plisada",
        "Blusa elegante",
        "Chompa de lana",
        "Casaca de jean",
        "Pantalon jogger",
        "Polera con capucha",
        "Bufanda"
    };

    static double[] precios = {
        35, 80, 120, 45, 25, 180, 90, 250, 60, 70, 110, 150, 95, 130, 40
    };

    static void Main()
    {
        VerCatalogo();
    }

    static void VerCatalogo()
    {
        Console.WriteLine();
        Console.WriteLine("N".PadRight(4) + "Prenda".PadRight(26) + "Precio sin IGV");
        Console.WriteLine(new string('-', 46));

        for (int p = 1; p <= 15; p++)
        {
            Console.WriteLine(p.ToString().PadRight(4) +
                              nombres[p - 1].PadRight(26) +
                              "S/ " + precios[p - 1].ToString("0.00"));
        }

        Console.WriteLine(new string('-', 46));
        Console.WriteLine("Tallas: XS, S, M, L, XL (se elige al comprar)");
    }
}
