using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class DataAccessLayer
    {
        public static string CalculateAverageGrade(string key)
        {
            using (SqlConnection conn = new SqlConnection("Server=tcp:j39hzwwo2q.database.windows.net,1433;Database=StudentsGrade;User ID=weiszdavid@j39hzwwo2q;Password=Daywa314!;Trusted_Connection=False;Encrypt=True;"))
            {
                string result = "";
                SqlDataReader reader = null;
                try
                {
                    // Open connection
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT AVG(Grade) FROM [StudentsGrade].[dbo].[Grades]", conn);

                    // Get query results
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    // Save the value into the result var
                    result = reader.GetValue(0).ToString();

                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                finally
                {
                    if (null != reader)
                        reader.Close();

                    if (null != conn)
                        conn.Close();
                }

                return result;
            }
        }

        public static bool UpdateStudentGrade(string studentID, int grade)
        {
            var result = false;
            using (SqlConnection conn = new SqlConnection("Server=tcp:j39hzwwo2q.database.windows.net,1433;Database=StudentsGrade;User ID=weiszdavid@j39hzwwo2q;Password=Daywa314!;Trusted_Connection=False;Encrypt=True;"))
            {
                try
                {
                    // Open connection
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
@"begin tran
if exists (select * from Grades with (updlock,serializable) where StudentID = '" + studentID + @"')
begin
   update Grades set Grade = " + grade + @"
   where StudentID = '" + studentID + @"'
end
else
begin
   insert Grades (StudentID, Grade)
   values ('" + studentID + @"'," + grade + @")
end
commit tran", conn);

                    // Execute command
                    cmd.ExecuteNonQuery();

                    // Save successful state
                    result = true;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                finally
                {
                    if (null != conn)
                        conn.Close();
                }
            }

            return result;
        }
    }
}
