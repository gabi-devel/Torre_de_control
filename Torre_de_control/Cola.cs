using System;

namespace Torre_de_control
{
    public class Cola
    {
        public Nodo frente, final;
        public Cola() {
            frente = null;
            final = null;
        }
        public void Poner(Nodo.InformacionVuelo informacion) { // Enqueue
            Nodo nuevo = new Nodo();
                nuevo.Info = informacion;
                nuevo.Sig = null;
            if (frente == null) { // si no hay ninguno, frente y final apuntan a nuevo
                                    // y final.Sig apunta a null
                frente = nuevo;
                final = nuevo;
            }
            else { // sino: final.Sig apunta al nuevo nodo. Y final es el nuevo nodo
                    // frente ya tiene uno asignado, y no cambia
                final.Sig = nuevo;
                final = nuevo;
            }
        }
        public Nodo.InformacionVuelo Sacar() { // Dequeue
            if (frente != null) { // si hay nodos
                Nodo.InformacionVuelo informacion = frente.Info;
                if (frente == final) {
                    frente = null;
                    final = null;
                }
                else {
                    frente = frente.Sig;
                }
                return informacion;
            }
            else throw new InvalidOperationException("Retornar absurdo");
        }
        public int Contar() {
            int cant = 0;
            Nodo reco = frente;
            while (reco != null) {
                cant++;
                reco = reco.Sig;
            }
            return cant;
        }
        public void Desplegar() {
            Nodo reco = frente;
            while (reco != null) {
                Console.Write("{0} - {1} - {2} - {3}", reco.Info.Num_vuelo, reco.Info.Matricula, reco.Info.Hora, reco.Info.Operacion);
                reco = reco.Sig;
                Console.WriteLine();
            }
        }

    }
}
