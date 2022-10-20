Console.WriteLine(   "+ - - - - - - - - - - ^ - - - - - - - - - - +");
Console.WriteLine(" 10| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  9| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  8| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  7| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  6| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  5| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  4| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  3| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  2| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  1| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  0| - - - - - - - - - - - - - - - - - - - - - >");
Console.WriteLine(" -1| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -2| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -3| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -4| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -5| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -6| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -7| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -8| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -9| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("-10| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("   + - - - - - - - - - - - - - - - - - - - - - +");
Console.WriteLine("    10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10");


//Coordinates of A
Console.WriteLine("Type Ax between -10,10:");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Ay between -10,10:");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A: " + (Ax, Ay));
Console.ReadKey();



//Coordinates of B
Random random = new Random();
int Bx;
Bx = random.Next(-10, 10);

Random random1 = new Random();
int By;
By = random.Next(-10, 10);
Console.WriteLine("B: " + (Bx, By));
Console.ReadKey();



//Coordinates of C
Random random3 = new Random();
int Cx;
Cx = random.Next(-10, 10);

Random random2 = new Random();
int Cy;
Cy = random.Next(-10, 10);
Console.WriteLine("C: " + (Cx, Cy));
Console.ReadKey();


//Their places on coordinate plane
Console.SetCursorPosition(((Ax + 11)*2 + 3), ((Ay * -1) + 11));
Console.Write("A");
Console.ReadKey();

Console.SetCursorPosition(((Bx + 11)*2 + 3), ((By * -1) + 11));
Console.Write("B");
Console.ReadKey();

Console.SetCursorPosition(((Cx + 11)*2 + 3), ((Cy * -1) + 11));
Console.Write("C");
Console.ReadKey();


Console.SetCursorPosition(0, 32);


//Sets of players
Random random8 = new Random();
int SetAx;
SetAx = random.Next(1, 4);
Console.WriteLine("PlayerA: Set" + SetAx);
Console.ReadKey();


Random random5 = new Random();
int SetBx;
SetBx = random.Next(1, 4);
Console.WriteLine("PlayerB: Set" + SetBx);
Console.ReadKey();

Random random6 = new Random();
int SetCx;
SetCx = random.Next(1, 4);
Console.WriteLine("PlayerC: Set" + SetCx);
Console.ReadKey();


//Healths of players
Random random9 = new Random();
int HealthA;
HealthA = random.Next(3, 6) * 20;
Console.WriteLine("PlayerA: " + HealthA + " Health");
Console.ReadKey();

Random random10 = new Random();
int HealthB;
HealthB = random.Next(3, 6) * 20;
Console.WriteLine("PlayerB: " + HealthB + " Health");
Console.ReadKey();

Random random11 = new Random();
int HealthC;
HealthC = random.Next(3, 6) * 20;
Console.WriteLine("PlayerC: " + HealthC + " Health");
Console.ReadKey();