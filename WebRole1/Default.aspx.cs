using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRole1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void GetAverageBtn_Click(object sender, EventArgs e)
        {
            AverageGrade.Text = BusinessLogic.BusinessLogicLayer.CalculateAverageGrade("average").ToString();

        }

        protected void UpdateGradeBtn_Click(object sender, EventArgs e)
        {
            // Converts the grade input to int
            int grade;
            Int32.TryParse(Grade.Text, out grade);

            var result = BusinessLogic.BusinessLogicLayer.UpdateStudentGrade(StudentID.Text, grade);

            if (!result)
                Message.Text = "Error trying to save to database";
        }
    }
}
