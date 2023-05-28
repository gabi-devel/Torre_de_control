namespace Torre_de_control
{
    public class Nodo
    {
        private InformacionVuelo info;
        private Nodo sig;
        public InformacionVuelo Info { get => info; set => info = value; }
        public Nodo Sig { get => sig; set => sig = value; }

        public class InformacionVuelo {
            public int Num_vuelo { get; set; }
            public string Matricula { get; set; }
            public int Hora { get; set; }
            public char Operacion { get; set; }

        }
        public static void Intercambio(Nodo primero, Nodo segundo)
        {
            // Intercambiar los valores de los nodos
            InformacionVuelo temp = primero.Info;
            primero.Info = segundo.Info;
            segundo.Info = temp;
        }
    }
}
