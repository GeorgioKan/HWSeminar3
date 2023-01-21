// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordsA = new int[3];
for (int i = 0; i < coordsA.Length; i++)
{
    switch (i)
    {
        case 0:
            System.Console.WriteLine("Ax:");
            break;
        case 1:
            System.Console.WriteLine("Ay:");
            break;
        case 2:
            System.Console.WriteLine("Az:");
            break;
    }
    coordsA[i] = Convert.ToInt32(Console.ReadLine());
}

int[] coordsB = new int[3];
for (int i = 0; i < coordsA.Length; i++)
{
    switch (i)
    {
        case 0:
            System.Console.WriteLine("Bx:");
            break;
        case 1:
            System.Console.WriteLine("By:");
            break;
        case 2:
            System.Console.WriteLine("Bz:");
            break;
    }
    coordsB[i] = Convert.ToInt32(Console.ReadLine());
}

double d = Math.Sqrt(Math.Pow(coordsB[0] - coordsA[0], 2) +
                     Math.Pow(coordsB[1] - coordsA[1], 2) +
                     Math.Pow(coordsB[2] - coordsA[2], 2));
System.Console.WriteLine(Math.Round(d, 2));