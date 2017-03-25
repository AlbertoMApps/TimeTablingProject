using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using TimeTabling.DAL;
using TimeTabling.Application;
using TimeTabling.CORE;

namespace WebApplication1.User
{
    public partial class ListSubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Render la GridView1 en el caso de que haya o no datos en ella
            if ((GridView1.ShowHeader == true && GridView1.Rows.Count > 0)
                  || (GridView1.ShowHeaderWhenEmpty == true))
            {
                //Force GridView to use <thead> instead of <tbody>
                GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            if (GridView1.ShowFooter == true && GridView1.Rows.Count > 0)
            {
                //Force GridView to use <tfoot> instead of <tbody>
                GridView1.FooterRow.TableSection = TableRowSection.TableFooter;
            }
            base.OnPreRender(e);

        }

        /// <summary>
        /// Metodo que retorna las asignaturas para el profesor como usuario
        /// </summary>
        /// <returns></returns>
        public List<Subject> GetData()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            Manager<Subject> manager = new Manager<Subject>(context);
            SubjectManager subjectManager = new SubjectManager(context);
            SubjectDetailsManager subjectDetailsManager = new SubjectDetailsManager(context);
            var subjects = subjectManager.GetAll().ToList()
                .Select(i => new Subject()
                {
                    Id = i.Id,
                    SubjectName = i.SubjectName,
                    Horas = i.Horas,
                    PracticeClassType = i.PracticeClassType,
                    TeoryClassStatus = i.TeoryClassStatus,
                    TermType = i.TermType,
                    CourseType = i.CourseType,
                    ApplicationUser_Id = User.Identity.GetUserId()
                });

            return subjects.ToList();
        }

        protected void CmdNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateListSubject");

        }
    }
}