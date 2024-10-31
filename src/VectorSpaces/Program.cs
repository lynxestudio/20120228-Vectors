using System;
using VectorSpaces;

Console.Clear();
//Set of Vectors
double[] p = {4,12,20,28,36,44,52,60};
double[] q = {6,14,22,30,38,46,54,62};
double[] r = {8,16,24,32,40,48,56,64};
double[] s = {10,18,26,34,42,50,58,66};
//Set of scalars
double alpha = 3;
Vector Px = new Vector(p);
Vector Qx = new Vector(q);
Console.WriteLine("\tSet of vectors:\n");
PrintArray("P",p);
PrintArray("q", q);
PrintArray("r", r);
PrintArray("s", s);
Console.WriteLine("\t\nscalar:\n");
Console.WriteLine("a = 3");
Console.WriteLine("\t\nOperations:\n");
Console.WriteLine("\tA1) p + q = {0}", Px + Qx);
Console.WriteLine("\n");
Vector Rx = new Vector(r);
Console.WriteLine("\tA3) p + (q + r) = {0}",(Px + (Qx + Rx)).ToString());
Console.WriteLine("\t    (p + q) + r = {0}",((Px + Qx) + Rx).ToString());
Console.WriteLine("\n");
Vector Sx = new Vector(s);
Console.WriteLine("\tA5) -s + s   = {0}",(-Sx + Sx).ToString());
Console.WriteLine("\t    s + (-s) = {0}",(Sx + (-Sx)).ToString());
Console.WriteLine("\n");
Console.WriteLine("\tS1) ap = {0} ",(alpha * Px).ToString());
Console.WriteLine("\n");
Console.WriteLine("\tS3) (p + s)a = {0}",((Px + Sx) * alpha).ToString());
Console.WriteLine("\t    ap + as  = {0} ",((alpha * Px) + (alpha * Sx)).ToString());
Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadKey(true);

static  void PrintArray(string l,double[] doubleArray) 
{
    Console.Write("\t{0} = ", l);
    for (int i = 0; i < doubleArray.Length; i++)
    {
        Console.Write("\t{0} ",doubleArray[i]);
        if (i == (doubleArray.Length - 1))
            Console.Write("\n");
    }
}