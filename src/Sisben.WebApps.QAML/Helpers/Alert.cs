using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sisben.WebApps.QAML.Helpers
{
    /// <summary>
    /// La clase Alert es una clase "helper" estática con un método para determinar el tipo de alerta
    /// que amerita la puntuación de una variable de un hogar.
    /// </summary>
    public static class Alert
    {
        /// <summary>
        /// Obtiene la clase de alerta de bootstrap correspondiente para la puntuación de la variable.
        /// </summary>
        /// <param name="score">Puntuación de nivel de confianza que obtuvo la variable.</param>
        /// <returns>
        /// Retorna los siguientes resultados dependiendo de la puntuación (score):
        /// * "alert-danger" para el intervalo [0, 0.25)
        /// * "alert-warning" para el intervalo [0.25, 0.75)
        /// * "alert-success" para el intervalo [0.75, 1]
        /// </returns>
        public static string GetClass(double score)
        {
            string result = string.Empty;
            if (score >= 0.75)
                result = "alert-success";
            else if (score >= 0.25)
                result = "alert-warning";
            else
                result = "alert-danger";
            return result;
        }
    }
}