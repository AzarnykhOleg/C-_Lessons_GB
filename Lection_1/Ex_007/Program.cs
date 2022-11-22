int xa = 50, ya = 1,
xb = 1, yb = 40,
xc = 100, yc = 40;

//Console.Clear();
//Console.SetCursorPosition(xa, ya);
//Console.WriteLine("+");
//Console.SetCursorPosition(xb, yb);
//Console.WriteLine("+");
//Console.SetCursorPosition(xc, yc);
//Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int vertexTriangle = new Random().Next(0, 3);
    if (vertexTriangle == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (vertexTriangle == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (vertexTriangle == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
    Thread.Sleep(1);
}