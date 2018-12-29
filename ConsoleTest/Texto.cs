using System;

namespace ConsoleTest{

    public class Texto : Figura{

        private readonly string _texto;

        public Texto(int fila, int columna, string texto, string name) : base(fila, columna, name){

            _texto = texto;

        }
        public override void  Dibujar(){

            Console.SetCursorPosition(Columna, Fila);
            Console.Write(_texto);

        }

    }
}