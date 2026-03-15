// See https://aka.ms/new-console-template for more information
var continuar = true;
var conversiones = new Dictionary<string, double>
{
    ["km"] = 1000,
    ["m"] = 1.0,
    ["cm"] = 0.01,
    ["mm"] = 0.001,
    ["mi"] = 1609.344,
    ["ft"] = 0.3048,
    ["in"] = 0.0254,
    ["yd"] = 0.9144
};

while (continuar)
{
    Console.Clear();
    Console.WriteLine("Bienvenidos a Convertidor de Unidades");


    Console.Write("Ingrese la cantidad a convertir: ");

    string entradaUser = Console.ReadLine()?.Trim() ?? "";

    if (Double.TryParse(entradaUser, out var valor))
    {
        Console.Write("Unidad origen  (km, m, cm, mm, mi, ft, in, yd): ");
        var unidadOrigen = Console.ReadLine()?.Trim().ToLower() ?? "";

        Console.Write("Unidad destino (km, m, cm, mm, mi, ft, in, yd): ");
        var unidadDestino = Console.ReadLine()?.Trim().ToLower() ?? "";

        if (!conversiones.TryGetValue(unidadOrigen, out var factorOrigen) || !conversiones.TryGetValue(unidadDestino, out var factorDestino))
        {
            Console.WriteLine($"Unidad no reconocida: '{unidadOrigen}' o '{unidadDestino}'");
        }
        else
        {
            var resultado = valor * factorOrigen / factorDestino;

            var nombreOrigen = unidadOrigen switch
            {
                "km" => "kilómetros",
                "m" => "metros",
                "cm" => "centímetros",
                "mm" => "milímetros",
                "mi" => "millas",
                "ft" => "pies",
                "in" => "pulgadas",
                "yd" => "yardas",
                _ => unidadOrigen
            };

            var nombreDestino = unidadDestino switch
            {
                "km" => "kilómetros",
                "m" => "metros",
                "cm" => "centímetros",
                "mm" => "milímetros",
                "mi" => "millas",
                "ft" => "pies",
                "in" => "pulgadas",
                "yd" => "yardas",
                _ => unidadDestino
            };

            Console.WriteLine($"{valor} {nombreOrigen} = {resultado:F4} {nombreDestino}");
        }

    }
    else
    {
        Console.WriteLine("Este número no es válido");
    }

    Console.Write("\n¿Desea realizar otra conversión? (s/n): ");
    var respuesta = Console.ReadLine()?.Trim().ToLower() ?? "";
    continuar = respuesta == "s";

}
Console.WriteLine("¡Hasta luego!");