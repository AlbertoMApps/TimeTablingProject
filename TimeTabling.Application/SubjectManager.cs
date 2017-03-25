using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTabling.CORE;
using TimeTabling.DAL;

namespace TimeTabling.Application
{
    /// <summary>
    /// Clase para manejar las asignaturas
    /// </summary>
    public class SubjectManager : Manager<Subject>
    {
        /// <summary>
        /// Contructor SubjectManager
        /// </summary>
        /// <param name="context"></param>
        public SubjectManager (ApplicationDbContext context) : base (context)
        {

        }

        /// <summary>
        /// Metodo que retorna las asignaturas por userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>

        public IQueryable <Subject> GetByUserId(string userId)
        {
            return Context.SubjectList.Where(i=>i.ApplicationUser_Id == userId);
        }

        /// <summary>
        /// Metodo que retorna una incidencia por id y userId
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <returns></returns>

        public Subject GetByIdUserId(int id, string userId)
        {
            return Context.SubjectList.Where(i => i.ApplicationUser_Id == userId && i.Id == id).SingleOrDefault();
        }

    }
}
