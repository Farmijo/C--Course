namespace ConsoleTest{
    public class FiguraFactory
    {
        private int _numCuadrados;
        private int _numTextos;
        public FiguraFactory()
        {
            _numCuadrados = 0;
            _numTextos = 0;

        }
        public Cuadrado GetCuadrado(int fila, int columna){
            var cuadrado = new Cuadrado( fila, columna, "Cuadrado " + _numCuadrados);
            _numCuadrados = _numCuadrados+1;
            return cuadrado;

        }

        public Texto GetTexto(int fila, int columna, string texto){
            var text = new Texto(fila, columna, texto, $"Texto {_numTextos}");
            _numTextos = _numTextos++;
            return text;
        }
    }
}