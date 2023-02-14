using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.DataComponents;

namespace WebAPI.Controllers
{
    
    public class StudentsController : ApiController
    {
        private readonly Entities data = new Entities();
        [ResponseType(typeof(List<Student>))]
        public async Task<IHttpActionResult> GetAllStudents()
        {
            var students=data.Students.ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(students));
        }
        [Route("api/Students/{StudentId}")]
        public async Task<IHttpActionResult> GetStudent(int StudentId)
        {
            var students = data.Students.ToList();
            var student = students.Find(e=>e.StudentId==StudentId);
            return await Task.Run<IHttpActionResult>(() => Ok(student));

        }
        [HttpPost]
        //[ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> AddStudent(Student student)
        {
            var std = new Student
            {
                StudentName=student.StudentName,
                StudentAddress=student.StudentAddress,
                MobileNo=student.MobileNo
            };
            data.Students.Add(std);
            data.SaveChanges();
            return await Task.Run<IHttpActionResult>(() => Ok());
        }
       

    }
}
