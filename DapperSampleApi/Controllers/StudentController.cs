using DapperSampleApi.DataAccess;
using System.Web.Http;
using System.Web.Services;

namespace DapperSampleApi.Controllers
{
    public class StudentController : ApiController
    {
        private Student _Student = new Student();
        
        [Route("api/getStudent/{id}")]
        public Models.Student Get(int id)
        {
            return _Student.GetSingleStudent(id);
        }
        [Route("api/AddStudent")]
        [HttpPost]
        public bool AddStudent(Models.Student newStudent)
        {
            return _Student.InsertStudent(newStudent);
        }
        [Route("api/deletestudent")]
        [HttpDelete]
        public string Delete(int StudentId)
        {
            if (_Student.DeleteStudent(StudentId))
                return "Silme işlemi başarılı";
            return "olmadi";
        }

    }
}
