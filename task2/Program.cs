// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordsA = new int[3];
System.Console.WriteLine("Ax:");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ay:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Az:");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];
System.Console.WriteLine("Bx:");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("By:");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Bz:");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(coordsB[0] - coordsA[0], 2) +
                     Math.Pow(coordsB[1] - coordsA[1], 2) +
                     Math.Pow(coordsB[2] - coordsA[2], 2));
System.Console.WriteLine(Math.Round(d, 2));

