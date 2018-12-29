namespace ConsoleTest{

    public class Cuadrado : Figura, IFigura{

        public Cuadrado(int fila, int columna, string name) : base(fila, columna, name ){}
        
        public override void Dibujar(){}
    }
}