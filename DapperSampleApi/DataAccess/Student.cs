using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DapperSampleApi.Models;

namespace DapperSampleApi.DataAccess
{
    public class Student : IStudent
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString);
       
        public bool DeleteStudent(int studentId)
        {
            if (studentId != 0)
            {
                int rowsAffected = this._db.Execute("DELETE FROM Students WHERE Id = @studentID",new { studentID = studentId});
                if (rowsAffected > 0)
                    return true;
                return false;                
            }
            return false;
        }

        public Models.Student GetSingleStudent(int studentId)
        {
            var Result = this._db.Query<Models.Student>("SELECT * FROM Students WHERE Id = @studentId", new { studentId}).SingleOrDefault();
            return Result;
        }

        public List<Models.Student> GetStudent()
        {
            var result = this._db.Query<Models.Student>("SELECT * FROM Students").ToList();
            return result;
        }

        public bool InsertStudent(Models.Student newStudent)
        {
            if (newStudent != null)
            {
                using (var __db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    int rowEffected = __db.Execute("INSERT INTO Students(Username,Email,Password) VALUES (@Username,@Email,@Password)",new {
                        Username = newStudent.Username,
                        Email = newStudent.Email,
                        Password = newStudent.Password
                    });
                    if (rowEffected > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;  
        }

        public bool UpdateStudent(Models.Student UpdatedStundet)
        {
            throw new NotImplementedException();
        }
        
    }
}