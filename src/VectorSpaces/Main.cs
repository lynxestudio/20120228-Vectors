using System;
using VectorSpaces;

namespace VectorSpaces
{
class MainClass
{
public static void Main (string[] args)
{
//Set of Vectors
double[] p = {4,12,20,28,36,44,52,60};
double[] q = {6,14,22,30,38,46,54,62};
double[] r = {8,16,24,32,40,48,56,64};
double[] s = {10,18,26,34,42,50,58,66};
//Set of scalars
double alpha = 3;
Vector Px = new Vector(p);
Vector Qx = new Vector(q);
Console.WriteLine("Set of vectors:\n");
PrintArray("P",p);
PrintArray("q", q);
PrintArray("r", r);
PrintArray("s", s);
Console.WriteLine("\nscalar:\n");
Console.WriteLine("a = 3");
Console.WriteLine("\nOperations:\n");
Console.WriteLine("A1) p + q = {0}", Px + Qx);
Console.WriteLine("\n");
Vector Rx = new Vector(r);
Console.WriteLine("A3) p + (q + r) = {0}",(Px + (Qx + Rx)).ToString());
Console.WriteLine("    (p + q) + r = {0}",((Px + Qx) + Rx).ToString());
Console.WriteLine("\n");
Vector Sx = new Vector(s);
Console.WriteLine("A5) -s + s   = {0}",(-Sx + Sx).ToString());
Console.WriteLine("    s + (-s) = {0}",(Sx + (-Sx)).ToString());
Console.WriteLine("\n");
Console.WriteLine("S1) ap = {0} ",(alpha * Px).ToString());
Console.WriteLine("\n");
Console.WriteLine("S3) (p + s)a = {0}",((Px + Sx) * alpha).ToString());
Console.WriteLine("    ap + as  = {0} ",((alpha * Px) + (alpha * Sx)).ToString());
Console.ReadLine();
}

static  void PrintArray(string l,double[] doubleArray) {
Console.Write("{0} = ", l);
for (int i = 0; i < doubleArray.Length; i++)
{
   Console.Write("{0} ",doubleArray[i]);
   if (i == (doubleArray.Length - 1))
       Console.Write("\n");
}
}
}
}
