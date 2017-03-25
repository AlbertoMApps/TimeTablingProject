using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTabling.CORE
{
    /// <summary>
    /// Clase de dominio de asignaturas
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Identificador de la asignatura
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
        /// Tipo de clase practica para esta asignatura
        /// </summary>
        public Course CourseType { get; set; }

        /// <summary>
        /// Tipo de trimestre cuando se imparte para la asignatura
        /// </summary>
        public Term TermType { get; set; }

        /// <summary>
        /// Lista de detalles por asignaatura
        /// </summary>
        public List<SubjectDetails> SubjectDetails { get; set; }

        /// <summary>
        /// Profesor asignado a la asignatura -FK
        /// </summary>
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUser_Id { get; set; }

    }
}
