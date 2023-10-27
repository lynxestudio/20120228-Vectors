using System;
using System.Text;

namespace VectorSpaces
{
public class Vector
{
delegate double Operation(double x, double y);
double[] _components;
Vector(){}
public Vector(double[] components){
this._components = components;
}
public double[] GetComponents(){
return _components;
}
public Vector(Vector v){
this._components = v.GetComponents();
}
public static Vector operator +(Vector u,Vector v){
return new Vector(Operating(u, v, (x, y) => (x + y)));	
}
public static Vector operator *(Vector u, Vector v) { 
return new Vector(Operating(u,v,(x,y) => (x * y)));
}
public static Vector operator -(Vector u){
if(u != null)
	return scalarMultiplicacion(-1,u);
else
	throw new ApplicationException("Vector is null");
}
public static Vector operator *(double d,Vector v){
return scalarMultiplicacion(d,v);
}
public static Vector operator *(Vector v,double d){
return scalarMultiplicacion(d,v);
}
        
static double[] Operating(Vector u, Vector v, Operation op) {
double[] resp = null;
            
if (u != null && v != null)
{
    resp = new double[u.Length];
    if (u.Length != v.Length)
        throw new ApplicationException("Vectors length must be equals in Length");
    else
    {
        for (int i = 0; i < u.Length; i++)
        {
            resp[i] = op(u.GetComponents()[i], v.GetComponents()[i]);
        }
            
    }
}
return resp;
}
static Vector scalarMultiplicacion(double d,Vector v){
double[] resp = new double[v.Length];
Vector r = null;
for(int i = 0;i < v.Length;i++)
	resp[i] = d * v.GetComponents ()[i];
r = new Vector(resp);
return r;
}
public int Length{ get{ return _components.Length;}}
public override string ToString ()
{
StringBuilder buf = new StringBuilder();
buf.Append("[ ");
foreach(double d in _components){
	buf.AppendFormat("{0} ",d.ToString());
}
buf.Append(" ]");
return buf.ToString();
}
        
}
}

