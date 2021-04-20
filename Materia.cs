using System;

namespace calificaciones
{
    class Materia
    {
        // Atributos - características, información
        public int primerParcial;
        public int segundoParcial;
        public int tercerParcial;

        /*public Materia(int primerParcial, int segundoParcial, int tercerParcial)
        {

            this.primerParcial = primerParcial;
            this.segundoParcial = segundoParcial;
            this.tercerParcial = tercerParcial;
        }*/

        // Métodos - acciones, para qué sirve

        // Calcular (a partir de 3 Parciales):
        


        // - 2 parciales (Promedio Parciales)

        // - semestral (Promedio Final)
        

        public float CalcularPromedioParciales()
        {
            // TODO: calcular el promedio entre los 2 primeros parciales
            float Promedioparciales_1_2 = (primerParcial+segundoParcial)/2;
            Console.WriteLine("El promedio es:" + Promedioparciales_1_2);

            if(Promedioparciales_1_2 <= 11)
            {
                Console.WriteLine("Estás descalificado!");
            }
            // TODO: calcular el promedio entre los 2 primeros parciales
            return 10f;
        }

        public float CalcularPromedioFinal()
        {
            // TODO: calcular el promedio final
            
            Parcial parcial = new Parcial();
            float CalFinal = 0;
            float x = 0;
            foreach(int item in parcial.Conversion)
            {
                x += item;
                Console.WriteLine(item);

            }
            Console.WriteLine("ss:" + x);
            CalFinal = x/3;
            Console.WriteLine("Probando: " + CalFinal);
             
            return 10f;
        }

        public bool RevisarRequiereAplicarEvaluacionExtraordinaria()
        {
            // TODO: revisar si se requiere aplicar o no una evaluación extraordinaria
            
            return false;
        }
    }
}