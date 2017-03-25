using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TimeTabling.Application;
using TimeTabling.CORE;
using TimeTabling.DAL;
using Microsoft.AspNet.Identity;
using WebApplication1.Models;

namespace WebApplication1.Admin
{
    public partial class SubjectList : System.Web.UI.Page
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
        /// Metodo que retorna las asignaturas con detalles para admin
        /// </summary>
        /// <returns></returns>
        public List<SubjectListDetails> GetData()
        {
            TimeTabling.DAL.ApplicationDbContext context = new TimeTabling.DAL.ApplicationDbContext();
            SubjectManager subjectManager = new SubjectManager(context);
            SubjectDetailsManager subjectDetailsManager = new SubjectDetailsManager(context);

            var subjects = subjectManager.GetByUserId(User.Identity.GetUserId()).ToList()
                .Select(i => new SubjectListDetails()
                {
                    Id = i.Id,
                    SubjectName = i.SubjectName,
                    Horas = i.Horas,
                    PracticeClassType = i.PracticeClassType,
                    TeoryClassStatus = i.TeoryClassStatus,
                    TeacherName = subjectDetailsManager.GetFirstTeacher(i.Id)
                });

            return subjects.ToList();
        }
    }
}