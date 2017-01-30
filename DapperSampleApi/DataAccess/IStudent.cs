using DapperSampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSampleApi.DataAccess
{
    public interface IStudent
    {
        List<Models.Student> GetStudent();

        Models.Student GetSingleStudent(int studentId);

        bool InsertStudent(Models.Student newStudent);

        bool DeleteStudent(int studentId);

        bool UpdateStudent(Models.Student UpdatedStundet);
    }
}
