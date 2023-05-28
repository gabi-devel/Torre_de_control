using System;

namespace Torre_de_control
{
    public class Program
    {
        public static Cola prioritaria;
        public static Cola salida;
        public static Cola arribo;
        public static Cola despegue;
        public static void Main(string[] args) {
            prioritaria = new Cola();
            arribo = new Cola();
            despegue = new Cola();
            Entrada(1234, "OFP", 1800, 'A');
            Entrada(2120, "VPO", 1805, 'D'); 
            Entrada(421, "LPV", 815, 'A');
            Entrada(2003, "FOP", 1810, 'A');
            Entrada(1022, "YTP", 1812, 'A');
            Entrada(22, "YTP", 1812, 'A');
            Entrada(1855, "GVP", 1805, 'A');
            Entrada(-1, "YTP", 1812, 'A');


        }
        public static void Entrada(int num_vuelo, string matricula, int hora, char operacion) {
            Nodo nodo = new Nodo();
            nodo.Info = new Nodo.InformacionVuelo();
            nodo.Info.Num_vuelo = num_vuelo;
            nodo.Info.Matricula = matricula;
            nodo.Info.Hora = hora;
            nodo.Info.Operacion = operacion;

            if (num_vuelo < 1000 && num_vuelo > 0) { prioritaria.Poner(nodo.Info); }
            if (num_vuelo > 1000) {
                if (operacion == 'A') { arribo.Poner(nodo.Info); }
                if (operacion == 'D') { despegue.Poner(nodo.Info); }
            }
            if (num_vuelo < 0) { Operaciones(); }
        }
        public static void Operaciones() {
            salida = new Cola();

            Console.WriteLine("Prioritaria:");
            prioritaria.Desplegar();
            Console.WriteLine("Arribo:");
            arribo.Desplegar();
            Console.WriteLine("Despegue:");
            despegue.Desplegar();

            while (prioritaria.Contar() > 0) {
                Nodo.InformacionVuelo algo = prioritaria.Sacar();
                salida.Poner(algo);
            }
            while (arribo.Contar() > 0) {
                Nodo.InformacionVuelo algo = arribo.Sacar();
                salida.Poner(algo);
            }
            while (despegue.Contar() > 0) {
                Nodo.InformacionVuelo algo = despegue.Sacar();
                salida.Poner(algo);
            }
            //Console.WriteLine("Salida:");
            //salida.Desplegar();

            Ordenar(salida);

            Console.WriteLine("Salida ordenada por Hora:");
            salida.Desplegar();

            Console.ReadKey();
        }

        public static void Ordenar(Cola cola)
        {
            Nodo actual = cola.frente;

            while (actual != null) {
                Nodo minNodo = actual;
                Nodo siguiente = actual.Sig;
                while (siguiente != null) {
                    if (siguiente.Info.Hora < minNodo.Info.Hora) {
                        if(minNodo.Equals(siguiente)) {
                            if (minNodo.Info.Num_vuelo < 1000 && minNodo.Info.Num_vuelo > 0) break;
                        }
                        minNodo = siguiente;
                    } 
                    siguiente = siguiente.Sig;
                }
                if (minNodo != actual) {
                    
                    Nodo.Intercambio(actual, minNodo);
                }
                actual = actual.Sig;
            }
        }
    }
}

            //int cantVeces = 100; //10 Cantidad de veces a imprimir por segundo
            //for (int i = 0; i < 2000; i++)
            //{
            //    Console.WriteLine(" {0}", i);
            //    i = i + 99;
            //    Thread.Sleep(1000 / cantVeces); // Calcula el intervalo en milisegundos
            //}
//for (int i = 0; i < cantVeces; i++)
//{
//    Console.WriteLine(" {0}", i );
//    Thread.Sleep(1000 / cantVeces); // Calcula el intervalo en milisegundos
//}