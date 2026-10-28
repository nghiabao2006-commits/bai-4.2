using System.Data.SqlClient;

namespace bai_4._2
{
    public static class Database
    {
        private const string Server = @"DESKTOP-KMNS09Q\MSSQLSERVER03";
        private const string DbName = "Bai42DB";

        private static readonly string MasterConn =
            "Server=" + Server + ";Database=master;Integrated Security=True;";
        public static readonly string Conn =
            "Server=" + Server + ";Database=" + DbName + ";Integrated Security=True;";

        public static SqlConnection Open()
        {
            var c = new SqlConnection(Conn);
            c.Open();
            return c;
        }

        public static void Init()
        {
            using (var c = new SqlConnection(MasterConn))
            {
                c.Open();
                using (var cmd = new SqlCommand(
                    "IF DB_ID(N'" + DbName + "') IS NULL CREATE DATABASE " + DbName, c))
                    cmd.ExecuteNonQuery();
            }

            string[] scripts =
            {
                @"IF OBJECT_ID(N'dbo.Courses', N'U') IS NULL
                  CREATE TABLE dbo.Courses (
                      Id   INT PRIMARY KEY,
                      Name NVARCHAR(100) NOT NULL
                  )",

                @"IF NOT EXISTS (SELECT 1 FROM dbo.Courses)
                  INSERT INTO dbo.Courses (Id, Name) VALUES
                      (1, N'C# Beginner'), (2, N'Windows Forms'),
                      (3, N'ASP.NET MVC'), (4, N'Data Structures')",

                @"IF OBJECT_ID(N'dbo.Students', N'U') IS NULL
                  CREATE TABLE dbo.Students (
                      Id         INT IDENTITY(1,1) PRIMARY KEY,
                      FullName   NVARCHAR(100) NOT NULL,
                      Phone      NVARCHAR(20)  NOT NULL,
                      BirthDate  DATE          NOT NULL,
                      CourseId   INT           NOT NULL REFERENCES dbo.Courses(Id),
                      Gender     NVARCHAR(10)  NOT NULL,
                      Newsletter BIT           NOT NULL DEFAULT 0,
                      Materials  BIT           NOT NULL DEFAULT 0,
                      CreatedAt  DATETIME      NOT NULL DEFAULT GETDATE()
                  )"
            };

            using (var c = Open())
            {
                foreach (var sql in scripts)
                    using (var cmd = new SqlCommand(sql, c))
                        cmd.ExecuteNonQuery();
            }
        }
    }
}