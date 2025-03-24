    public class Palabra {
        public string Texto { get; }
        public Posicion Inicio { get; }
        public Posicion Fin { get; }
        public Palabra(string texto, Posicion inicio, Posicion fin) {
            Texto = texto.ToLower();
            Inicio = inicio;
            Fin = fin;
        }
    }