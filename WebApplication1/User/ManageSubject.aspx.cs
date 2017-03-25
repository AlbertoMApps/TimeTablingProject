using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimeTabling.Application;
using TimeTabling.DAL;
using TimeTabling.CORE;

namespace WebApplication1.User
{
    public partial class ManageSubject : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        SubjectManager subjectManager = null;
        SubjectDetailsManager subjectDetailsManager = null;
        Subject subject = null;
        string subjectId = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            context = new ApplicationDbContext();
            subjectManager = new SubjectManager(context);
            subjectDetailsManager = new SubjectDetailsManager(context);

            int id;
            subjectId = Request.QueryString["subjectId"];
            bool parse = int.TryParse(subjectId, out id);

            if (parse)
            {
                subject = subjectManager.GetByIdUserId(id, User.Identity.GetUserId());
            }

            if (!parse || subject == null)
            {
                //Redirigir una pagina de error o un error en una label... etc
            }

            if (!Page.IsPostBack)
            {
                //cargamos datos 

                if (subject != null)
                {
                    //cargar datos al principio si necesitaramos

                    txtTotalHours.Text = subject.Horas.ToString();
                }
            }

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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                context = new ApplicationDbContext();
                subjectManager = new SubjectManager(context);
                subjectDetailsManager = new SubjectDetailsManager(context);
                int h;
                if (int.TryParse(txtHours1.Text, out h))
                {
                    subjectDetailsManager.Add(new SubjectDetails()
                    {
                        NumHoras = h,
                        TeacherName = txtTeacherName.Text.ToString(),
                        DayOfWeekType = (TimeTabling.CORE.DayOfWeek)Enum.Parse(typeof(TimeTabling.CORE.DayOfWeek), ddDayOfWeek.SelectedValue),
                        Message = txtComment.Text.ToString(),
                        ApplicationUser_Id = User.Identity.GetUserId(),
                        Subject_Id = subject.Id

                    });

                    context.SaveChanges();
                    Response.Redirect("ListSubjects");
                }

            }
            catch
            {
                //Mostar la incidencia en un log
                ErrorMessage.Text = "Se ha producido un error";
            }
        }

        public List<SubjectDetails> GetData(int subjectId)
        {
            context = new ApplicationDbContext();
            subjectManager = new SubjectManager(context);
            subjectDetailsManager = new SubjectDetailsManager(context);

            return subjectDetailsManager.GetAll().Where(sdm => sdm.Subject.Id == subjectId).ToList();
        }

    }
}