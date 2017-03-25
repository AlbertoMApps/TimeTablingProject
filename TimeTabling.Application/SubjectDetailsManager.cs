using System.Linq;
using TimeTabling.CORE;
using TimeTabling.DAL;

namespace TimeTabling.Application
{
    /// <summary>
    /// Clase para manejar los detalles
    /// </summary>
    public class SubjectDetailsManager : Manager<SubjectDetails>
    {
        /// <summary>
        /// Contructor SubjectDetailsManager
        /// </summary>
        /// <param name="context"></param>
        public SubjectDetailsManager(ApplicationDbContext context) : base (context)
        {

        }

        /// <summary>
        /// Retorna el primer profesor de esa asignatura
        /// </summary>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public string GetFirstTeacher(int subjectId)
        {
            SubjectDetails sd = Context.SubjectDetailsList.Where(m => m.Subject_Id == subjectId).FirstOrDefault();
            if (sd != null)
            {
                return sd.TeacherName;
            }
            return "";
        }

    }
}
