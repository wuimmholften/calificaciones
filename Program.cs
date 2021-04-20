using System;
using System.Collections.Generic;

namespace calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Parcial primerParcial = new Parcial();
            primerParcial.AgregarCriterio(new Criterio("Trabajo en clase", 0.25f));
            primerParcial.AgregarCriterio(new Criterio("Prácticas", 0.25f));
            primerParcial.AgregarCriterio(new Criterio("Participación/Esfuerzo", 0.1f));
            primerParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));

            Parcial segundoParcial = new Parcial();
            segundoParcial.AgregarCriterio(new Criterio("Trabajo en clase", 0.25f));
            segundoParcial.AgregarCriterio(new Criterio("Prácticas", 0.25f));
            segundoParcial.AgregarCriterio(new Criterio("Participación/Esfuerzo", 0.1f));
            segundoParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));

            Parcial tercerParcial = new Parcial();
            tercerParcial.AgregarCriterio(new Criterio("Trabajo en clase", 0.25f));
            tercerParcial.AgregarCriterio(new Criterio("Prácticas", 0.25f));
            tercerParcial.AgregarCriterio(new Criterio("Participación/Esfuerzo", 0.1f));
            tercerParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));

            List<float> calificacionCriteriosPrimerParcial = new List<float>();
            calificacionCriteriosPrimerParcial.Add(8);
            calificacionCriteriosPrimerParcial.Add(9);
            calificacionCriteriosPrimerParcial.Add(10);
            calificacionCriteriosPrimerParcial.Add(9);
            int calificacionPrimerParcial = primerParcial.CalcularCalificacion(calificacionCriteriosPrimerParcial);

            List<float> calificacionCriteriosSegundoParcial = new List<float>();
            calificacionCriteriosSegundoParcial.Add(6);
            calificacionCriteriosSegundoParcial.Add(6);
            calificacionCriteriosSegundoParcial.Add(6);
            calificacionCriteriosSegundoParcial.Add(7);
            int calificacionSegundoParcial = segundoParcial.CalcularCalificacion(calificacionCriteriosSegundoParcial);

            List<float> califiacionesCriteriosTercerParcial = new List<float>();
            califiacionesCriteriosTercerParcial.Add(7);
            califiacionesCriteriosTercerParcial.Add(4);
            califiacionesCriteriosTercerParcial.Add(10);
            califiacionesCriteriosTercerParcial.Add(9);
            int califiacionTercerParcial = tercerParcial.CalcularCalificacion(califiacionesCriteriosTercerParcial);

            Materia teoriaDeLaComputacion = new Materia();
            teoriaDeLaComputacion.CalcularPromedioFinal();

            

           
            

        }
    }
}
