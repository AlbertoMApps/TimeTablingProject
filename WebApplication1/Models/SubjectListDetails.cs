using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeTabling.CORE;

namespace WebApplication1.Models
{
    /// <summary>
    /// Clase de dominio de lisa de asignaturas para administradores, etc
    /// </summary>
    public class SubjectListDetails
    {
        /// <summary>
        /// Identificador de la asignaturaConDetalles
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la asignatura
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Numero de horas por semana de la asignatura
        /// </summary>
        public int Horas { get; set; }

        /// <summary>
        /// Estado abierto o cerrado de clase teorica para la asignatura
        /// </summary>
        public TeoryClass TeoryClassStatus { get; set; }

        /// <summary>
        /// Tipo de clase practica para esta asignatura
        /// </summary>
        public PracticeClass PracticeClassType { get; set; }

        /// <summary>
        /// Profesor que va a impartir la asignatura
        /// </summary>
        public string TeacherName { get; set; }

    }
}