namespace R22A1_FranGV
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Punto posicion;
            posicion = new Punto(TipoCoordenada.X, 23.02f);

            Forma forma1 = new Forma("triangulo", "amarillo", posicion);


            



            

            Rectangulo rectangulo = new Rectangulo(1, 2);





            Console.WriteLine(posicion.X + posicion.ToString(), rectangulo.ToString());
        }
    }
}