using Arboles;

Arbol arbol = new();
Random r = new();
for (int i = 0;i < 10; i++)
{
    arbol.Agregar(r.Next(100));
}
arbol.Raiz.inorden();
