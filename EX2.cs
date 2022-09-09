void PrintResult(int[,] array)
{
string result = " ";
int schet = 0;

Console.WriteLine("Enter a coef:");
int n = int.Parse(Console.ReadLine() ?? "0");


for(int i = 0; i<array.GetLength(0); i++)
{
for(int j = 0; j<array.GetLength(1); j++)
{
array[i, j] = array[i, j] * n;
schet = schet + 1;
if (schet%2 != 0)
{
result = result + ($"({array[i, j]},");
}
else if (schet%2==0)
{
result = result + ($"{array[i, j]}) ");
}
}
}
Console.WriteLine($"Second coordinat: {result}");
}


int[,] array0 = new int[2, 4];
Console.WriteLine("Enter a coordinat:");
string coordinat = Console.ReadLine();

int[] c = new int[coordinat.Length];

for(int i=0; i<coordinat.Length; i++)
{
c[i] = Convert.ToInt32(Convert.ToString(coordinat[i]));
}

int y = 0;
for (int i = 0; i < array0.GetLength(0); i++)
{
for (int j = 0; j < array0.GetLength(1); j++)
{
array0[i, j] = c[y];
y++;
}
}
Console.WriteLine($"Current coordinat: ({array0[0,0]},{array0[0, 1]}) ({array0[0, 2]},{array0[0, 3]}) ({array0[1, 0]},{array0[1, 1]}) ({array0[1, 2]},{array0[1, 3]})");
// Console.Write("X-coordinat of 1 pic: ");
// int x1 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Y-coordinat of 1 pic: ");
// int y1 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("X-coordinat of 2 pic: ");
// int x2 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Y-coordinat of 2 pic: ");
// int y2 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("X-coordinat of 3 pic: ");
// int x3 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Y-coordinat of 3 pic: ");
// int y3 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("X-coordinat of 4 pic: ");
// int x4 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Y-coordinat of 4 pic: ");
// int y4 = int.Parse(Console.ReadLine() ?? "0");

//Console.WriteLine($"Current coordinat: ({x1},{y1}) ({x2},{y2}) ({x3},{y3}) ({x4},{y4}) ");
//int[,] array0 = new int[,] {{x1, y1}, {x2, y2}, {x3, y3}, {x4, y4}};

//FillArray(array0, 1, 11);
//PrintArray(array0);
PrintResult(array0);