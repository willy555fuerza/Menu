// See https://aka.ms/new-console-template for more information
int c;
Console.WriteLine("Menu de opciones");
Console.WriteLine("1: Los 38 ejercicios");
Console.WriteLine("2: Vectores");
Console.WriteLine("3: Matrices");
Console.WriteLine("digite la opcion");

c = int.Parse(Console.ReadLine());
switch (c)
{
    case 1:
        Console.Clear();

        double a, b;
        int opcion;
        Console.WriteLine("Menu de opciones");
        Console.WriteLine("1: Suma (a+b)");
        Console.WriteLine("2: Resta (a-b)");
        Console.WriteLine("3: Multiplicacion (a*b)");
        Console.WriteLine("4: Division (a/b)");
        Console.WriteLine("0: Salir");
        Console.WriteLine("digite la opcion");                             

        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.Write("digite el valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite el valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("la suma de {0} + {1} = {2}", a, b, (a + b));
                break;
            case 2:
                Console.Clear();
                Console.Write("digite el valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite el valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("la suma de {0} - {1} = {2}", a, b, (a - b));
                break;
            case 3:
                Console.Clear();
                Console.Write("digite el valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite el valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("la suma de {0} * {1} = {2}", a, b, (a * b));
                break;
            case 4:
                Console.Clear();
                Console.Write("digite el valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite el valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("la suma de {0} / {1} = {2}", a, b, (a / b));
                break;
            case 0:
                Console.WriteLine("chauuu la kevin.......");
                break;
            default:
                Console.WriteLine("valor incorrecto");

                break;
        }
        break;
    case 2:
        Console.Clear();

        int d;

        Console.WriteLine("Menu de opciones");
        Console.WriteLine("1: numero par e impar");
        Console.WriteLine("2: ................");
        Console.WriteLine("3: ................");
        Console.WriteLine("digite la opcion");

        d = Convert.ToInt32(Console.ReadLine());

        switch (d)
        {
            case 1:
                Console.Clear();

                int i, n;
                Console.WriteLine("ingrese la cantida de numeros que quiere ingresar");
                n = Convert.ToInt32(Console.ReadLine());
                int[] vec = new int[n];
                Console.WriteLine("ingre sus digitos");
                for (i = 0;i < n;i++)
                {
                    vec[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Los numeros pares son:");
                for (i = 0; i < n; i++)
                {
                    if(vec[i] % 2 == 0)
                    {
                        Console.WriteLine(vec[i]);
                    }
                }
                Console.WriteLine("Los numeros impares son:");
                for (i = 0; i < n; i++)
                {
                    if (vec[i] % 2 != 0){
                        Console.WriteLine(vec[i]);
                    }
                }

                break;
        }
        break;
        default:
            Console.WriteLine("valor incorrecto");
        break;
}


Console.ReadKey();