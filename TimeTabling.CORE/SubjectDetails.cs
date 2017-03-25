using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTabling.CORE
{
    /// <summary>
    /// Clase de dominio para detalles de una asignatura
    /// </summary>
    public class SubjectDetails
    {
        /// <summary>
        /// Identificador de detalles para una asignatura
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero de horas que se imparte por el profesor 
        /// </summary>
        public int NumHoras { get; set; }

        /// <summary>
        /// Profesor que va a impartir la asignatura
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// Dia de la semana que se impartira esta asignatura
        /// </summary>
        public DayOfWeek DayOfWeekType { get; set; }

        /// <summary>
        /// Mensaje para profesores
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Subject foreign key -FK
        /// </summary>
        public Subject Subject { get; set; }

        [ForeignKey("Subject")]
        public int Subject_Id { get; set; }

        /// <summary>
        /// Profesor que ha creado detalles para inscribirse a esta asignatura -FK
        /// </summary>
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUser_Id { get; set; }

    }
}