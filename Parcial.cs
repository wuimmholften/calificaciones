using System;
using System.Collections.Generic;
using System.Linq;

namespace calificaciones
{
        class Parcial
    {
        public List<Criterio> criterios = new List<Criterio>();
        public List<float> Conversion = new List<float>(); 

        // TODO: calcularlo
        float suma = 0; 
        float total = 0;
        float division = 0;
        public void AgregarCriterio(Criterio criterio)
        {
            this.criterios.Add(criterio);
        }

        // Criterios distintos
        

        // Debe haber por lo menos 1 criterio

        public bool ValidarSumaCriterios(float porcentaje)
        {
            // TODO: validar que la suma de criterios nos de un 100%
            float SumaCriterios = porcentaje*4;

            if(SumaCriterios == 1.00f)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("La suma de los criterios de dar 100%");
            }
        }

        public bool ValidarCriteriosDistintos()
        {
            // TODO: validar que todos los criterios tienen nombre distinto
            return true;
        }

        public bool ValidarCriteriosDefinidos()
        {
            // TODO: validar que por lo menos hay 1 criterio
            return true;
        }

        public int CalcularCalificacion(List<float> calificacionesDeCadaCriterio)
        {
            
            //float CalFinal = 0;
            
            foreach(int item in calificacionesDeCadaCriterio)
            {
                total = total+item;
                division = total/criterios.Count;
                suma += division;
                //Conversion.Add(division);
                
            }  
            
            Console.WriteLine("Probando: "+ suma);
            return 10;
        }

        
    }

}