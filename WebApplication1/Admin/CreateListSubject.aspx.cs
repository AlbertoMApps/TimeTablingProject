using Microsoft.AspNet.Identity;
using System;
using TimeTabling.Application;
using TimeTabling.CORE;
using TimeTabling.DAL;

namespace WebApplication1.Admin
{
    public partial class CreateListSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                ApplicationDbContext context = new ApplicationDbContext();
                SubjectManager subjectManager = new SubjectManager(context);
                Subject subject = null;
                int h;
                if (int.TryParse(txtHours.Text, out h))
                {

                    subject = new Subject()
                    {
                        SubjectName = txtSubjectName.Text,
                        Horas = h,
                        TeoryClassStatus = (TeoryClass)Enum.Parse(typeof(TeoryClass), ddTeory.SelectedValue),
                        PracticeClassType = (PracticeClass)Enum.Parse(typeof(PracticeClass), ddPractice.SelectedValue),
                        CourseType = (Course)Enum.Parse(typeof(Course), ddCourseType.SelectedValue),
                        TermType = (Term)Enum.Parse(typeof(Term), ddTerm.SelectedValue),
                        ApplicationUser_Id = User.Identity.GetUserId()

                    };

                    subjectManager.Add(subject);



                    //SubjectDetailsManager subjectDetailsManager = new SubjectDetailsManager(context);

                    //subjectDetailsManager.Add(new SubjectDetails()
                    //{

                    //});


                    context.SaveChanges();
                    Response.Redirect("SubjectList");
                }

            }
            catch
            {
                //TODO - Guardar el ex.Message en el log
                lblResult.Text = "El registro no se ha guardado correctamente";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}