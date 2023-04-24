# Sobrecarga de operadores en C# utilizando vectores

Además de los operadores para los tipos primitivos, C# tiene una característica conocida como sobrecarga de operadores la cuál permite que los operadores para tipos primitivos puedan utilizarse con objetos, permitiéndonos definir el tipo de operación, como se va a efectuar, los tipos involucrados y valor que devuelve, un ejemplo típico de esta funcionalidad lo tenemos en la concatenación de objetos String en donde se utiliza el símbolo "+" para la concatenación de cadenas que igualmente es utilizado para la adicción de enteros, como se muestra en los siguientes ejemplos:


Adicción de enteros
--------------------
int a = 18;
int b = 66;
Console.Write(a + b); //imprime 84

Concatenación de cadenas
-------------------------

String s1 = "Once upon ";
String s2 = "a hero ";
Console.Write(s1 + s2); //imprime Once upon a hero
Para ejemplificar como funciona la sobrecarga de operadores en objetos utilizaremos las operaciones con vectores que se estudian en el álgebra lineal, por lo que antes de codificar daremos algunas definiciones.

Un vector es un objeto perteneciente a un espacio vectorial, que para los casos particulares de espacios R2 y R3 podemos representarlos gráficamente como segmentos de línea dirigidos con un punto inicial y un punto final describiendo la asociación de una magnitud y una dirección.

Un espacio vectorial consiste de:
Un campo F de escalares (en general los número reales).
Un conjunto V de elementos llamados vectores.
Un conjunto de reglas (u operaciones) llamadas suma y multiplicación que según los textos especialistas en la materia se dividen en dos categorías, una para la adicción y otra para la multiplicación.

Los axiomas para la adición espacios vectoriales son:
A1. Si u y v están en V, entonces u + v está dentro de V
A2. u + v = v + u para todos u y v que estan en V
A3. u + (v + w) = (u + v) + w para todos los u,v y w en V
A4. Un elemento 0 en V existe tal que v + 0 = v para cada v en V.
A5. Para cada v en V, existe un elemento -v en V tal que -v + v = 0 y v + (-v) = 0


Los axiomas para la multiplicación son:
S1. Si v esta en V entonces av esta en V para cada a en R.
S2. a(v + w) = av + aw para cada v y w en V y para cada a en R.
S3. (a+b)v = av + bv para cada v en V y para cada a y b en R.
S4. a(bv) = (ab)v para cada v en V y para todos cada a y b en R.
S5. 1v = v para cada v en V.

Ahora con estos conceptos pasemos al código, primeramente crearemos nuestra clase Vector en donde utilizando la palabra reservada operator definiremos las operaciones para demostrar algunos de los axiomas expuestos. A continuación el listado de dicha clase.



Como vemos en este código utilizamos la sobrecarga de operadores utilizando la palabra clave operator en los siguientes métodos:
<pre>
public static Vector operator +(Vector u,Vector v)
public static Vector operator *(Vector u, Vector v)
public static Vector operator -(Vector u)
public static Vector operator *(double d,Vector v)
public static Vector operator *(Vector v,double d)
</pre>

Aquí definimos la operación, el número de parámetros con los que se llevará a cabo y por supuesto su implementación.
Ahora con el siguiente listado mostraremos la utilización de clase Vector y el uso de la sobrecarga de operadores para vectores de números reales:



Si agregamos estas clases a un proyecto de consola en MonoDevelop podemos tener una solución lista para corregir y compilar.



Al ejecutar la solución, veremos el resultado como en la siguiente imagen:
