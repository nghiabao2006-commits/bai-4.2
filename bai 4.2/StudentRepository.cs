using System;
using System.Data;
using System.Data.SqlClient;

namespace bai_4._2
{
    public static class StudentRepository
    {
        public static DataTable GetCourses()
        {
            using (var c = Database.Open())
            using (var da = new SqlDataAdapter("SELECT Id, Name FROM Courses ORDER BY Id", c))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Add(string name, string phone, DateTime birth, int courseId,
                               string gender, bool newsletter, bool materials)
        {
            using (var c = Database.Open())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Students (FullName, Phone, BirthDate, CourseId, Gender, Newsletter, Materials)
                VALUES (@name, @phone, @birth, @course, @gender, @news, @mat)", c))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@birth", birth.Date);
                cmd.Parameters.AddWithValue("@course", courseId);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@news", newsletter);
                cmd.Parameters.AddWithValue("@mat", materials);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAll()
        {
            using (var c = Database.Open())
            using (var da = new SqlDataAdapter(@"
                SELECT s.Id, s.FullName AS [Name], s.Phone, s.BirthDate AS [Birth date],
                       co.Name AS Course, s.Gender, s.Newsletter, s.Materials
                FROM Students s JOIN Courses co ON co.Id = s.CourseId
                ORDER BY s.Id DESC", c))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}