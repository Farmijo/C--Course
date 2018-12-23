using System;

namespace ConsoleTest{

    public class Texto : Figura{

        private readonly string _texto;

        public Texto(int fila, int columna, string texto) : base(fila, columna){

            _texto = texto;

        }
        public override void  Dibujar(){

            Console.SetCursorPosition(Columna, Fila);
            Console.Write(_texto);

        }

    }
}