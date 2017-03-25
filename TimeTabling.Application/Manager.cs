using System.Linq;
using TimeTabling.DAL;

namespace TimeTabling.Application
{
    /// <summary>
    /// Clase generica
    /// </summary>
    public class Manager <T>
        where T : class
    {
        ApplicationDbContext context = null;

        /// <summary>
        /// Contructor del manager generico
        /// </summary>
        /// <param name="pContext"></param>
        public Manager(ApplicationDbContext pContext){
            context = pContext;
            }

        /// <summary>
        /// metodo get de contexto
        /// </summary>
        public ApplicationDbContext Context
        {
            get
            {
                return context;
            }
        }


        /// <summary>
        /// Metodo que retorna los elementos
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        /// <summary>
        /// Metodo que anade los elementos
        /// </summary>
        public T Add(T entity)
        {
           return Context.Set<T>().Add(entity);
        }



    }
}
