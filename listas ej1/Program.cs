
Console.WriteLine("Ingresa una serie de números enteros separados por espacios:");
string entrada = Console.ReadLine();

string[] serie = entrada.Split(' ');

List<int> numeros = new List<int>();

int suma = 0;
int valoresNoValidos = 0;

foreach (string numeroTexto in serie)
{
    try
    {
        int numero = int.Parse(numeroTexto);
        numeros.Add(numero);
        
    }
    catch (FormatException)
    {
        Console.WriteLine($"Error: '{numeroTexto}' no es un número válido.");
        valoresNoValidos++;
    }
}


foreach (int numero in numeros)
{
    suma += numero;
}
Console.WriteLine($"La suma total de los números ingresados es: {suma}");
