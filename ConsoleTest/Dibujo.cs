namespace ConsoleTest{

    public class Dibujo{

        private ILista<IFigura> _figuras;
        private ILista<int> _lista2;

        public Dibujo(){
            _figuras = new Lista<IFigura>(10);
            _figuras.Add(new Texto(10,5, "HOLA asdf dsf ")) ; 
            // Aunque _figuras es una lista de Ifugras, una vez se le añade algo, solo se le pueden añadir nuevos elementos del mismo tipo.
            
            var lista2 = new Lista<Texto>(10);

            IFigura f = new Texto(1,2,"fghj");
           
           /*
           ERROR DE COMPILACIÓN: Un texto es una Ifigura (jerarquia), pero una lista de Texto SOLO PUEDE CONTENER TEXTO, no derivados de IFigura
            Podrias añadir elementos que cumpliesen la jerarquia Ifigura -> Tipo, Por ejemplo, Cuadrado : IFigura; Circulo : IFigura,...
            PERO, si creases un metodo que admitiese como parametro una Lista<Ifigura>, podrias añadirle a la lista elementos que no serian Texto,
            pero que implementasen la interfaz IFigura. Y acabarias teniendo una lista<T> con mas de un tipo de elemento dentro. Lo cual no estaria bien
            Esto explotaria:
                     Foo(lista2); 
                    public void Foo(Lista<IFigura> parametro){

                        parametro.Add(new Cuadrado())
                        }
            
            */
            // ALSO
            /*
            En el caso anterior, explotaba porque podias romper jerarquias. Un Lista<T> solo admite un tipo, Lista<Texto>, Lista<Int>, etc
            Pero en el caso de que la jerarquia no lo haga explotar, se puede llegar a hacer. 
            Por ejemplo, crear un metodo Foo(IEnumerable<IFigura> f){

            }

            La interfaz IEnumberable no permite hacer nada que rompa la jerarquia, ya que solo permite iterar. 
            Esto se explicita al definir la interfaz asi: IEnumerable<out T>
            Lo cual permite hacer:
            Lista<Texto> lista2 = new Lista<Texto>(10);
            Foo(lista2)
             */


        }
  
        public void Foo(Lista<IFigura> parametro){

                
        }
        public void Dibujar(){
/*

 
            foreach(var figura in _figuras)
            {
                
                figura?.Dibujar();

                //Paso por valor: Evalua una copia del parametro
                //Paso por referencia: El parametro pasado es el mismo objeto

                // Doble interrogacion return _figura[i] ?? ""
                
            }
             */
             for (int i = 0; i < _figuras.Count; i++)
             {
                 //Casting Directo. Excepcion si no puede hacer el casting
                 ((Figura)_figuras.GetAt(i)).Dibujar();
                 //casting inteligente. Variable nula si no es capaz de hacer el casting.
                 var figura = _figuras.GetAt(i) as Figura;
                 figura.Dibujar();
             }
        }

       

    }
}