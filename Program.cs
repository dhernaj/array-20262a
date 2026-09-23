//función de Imprimir notas
static void ImprimirNotas(int[] notas)
{
    for(int i=0; i<notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }
}

//Función Calcular promedio 
static double CalcularPromedio(int[] notas)
{
    int suma=0;
    for(int i=0; i<notas.Length; i++)
    {
        suma+=notas[i];
    }
    return (double)suma / notas.Length;
}   

//Calcular nota mayor
static int CalcularNotaMayor(int[] notas)
{
    int mayor = notas[0];
    for(int i=1; i<notas.Length; i++)
    {
        if(notas[i] > mayor)
        {
            mayor = notas[i];
        }
    }
    return mayor;
}   

//Calcular nota menor
static int CalcularNotaMenor(int[] notas)
{
    int menor = notas[0];
    for(int i=1; i<notas.Length; i++)
    {
        if(notas[i] < menor)
        {
            menor = notas[i];
        }
    }
    return menor;
}   


int[] notas={15,18,12,17,20};

//Imprimir las notas
ImprimirNotas(notas);

//Calcular el promedio de las notas
double promedio = CalcularPromedio(notas);
Console.WriteLine($"El promedio es: {promedio}");

// Imprimir las nota mayor y menor
int mayor = CalcularNotaMayor(notas);
int menor = CalcularNotaMenor(notas);
Console.WriteLine($"La nota mayor es: {mayor}");
Console.WriteLine($"La nota menor es: {menor}");