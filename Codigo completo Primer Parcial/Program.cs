{
    Console.Write("Escriba un número entero positivo  mayor que cero: ");
    int num = int.Parse(Console.ReadLine());

    // operar cuadrados y almacenar en arreglo
    int[] numcuadrados = new int[num];
    for (int a = 1; a <= num; a++)
    {
        numcuadrados[a - 1] = a * a;
    }

    //  números primos menores o iguales 
    Console.Write("\nNúmeros primos menores o iguales  : ");
    for (int a = 2; a <= num; a++)
    {
        bool esPrimo = true;
        for (int b = 2; b < a; b++)
        {
            if (a % b == 0)
            {
                esPrimo = false;
                break;
            }
        }
        if (esPrimo)
        {
            Console.Write(a + " ");
        }
    }

    //  múltiplos de 4 menores o iguales 
    Console.Write("\nMúltiplos de 4 menores o iguales : ");
    for (int a = 4; a <= num; a += 4)
    {
        Console.Write(a + " ");
    }

    // números que se incrementan en 3
    Console.Write("\n números que se incrementan en 3: ");
    int x = 1;
    while (x <= num)
    {
        Console.Write(x + " ");
        x += 3;
    }
    Console.Write(x);
    //  numeros cuadrados
    Console.Write("\nCuadrados de los números menores o iguales  : ");
    for (int a = 0; a < num; a++)
    {
        Console.Write(numcuadrados[a] + " ");
    }

    Console.ReadKey();
}
