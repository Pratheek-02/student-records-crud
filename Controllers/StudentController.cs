using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OurProject.Models;

namespace StudentCRUDapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentDBContext _studentDbContext;

        public StudentController(StudentDBContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        // GET: api/Student/GetStudent
        [HttpGet("GetStudent")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _studentDbContext.Students.ToListAsync();
        }

        // POST: api/Student/AddStudent
        [HttpPost("AddStudent")]
        public async Task<ActionResult<Student>> AddStudent(Student objStudent)
        {
            _studentDbContext.Students.Add(objStudent);
            await _studentDbContext.SaveChangesAsync();

            return Ok(objStudent);
        }
        //update API Call
        //user enter the student id-> we will find the  record and we willl update the fields
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            var existingstudent = await _studentDbContext.Students.FindAsync(id);
            if (existingstudent == null)

                return NotFound();
            existingstudent.Name = student.Name;
            existingstudent.Course = student.Course;
            await _studentDbContext.SaveChangesAsync();
            return Ok(existingstudent);

        }
        //Delete API
        //we need to find student basd on ID
        //Find->True=remove  the student
        //Find ->False-Return Not found
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)

        {
            var student = await _studentDbContext.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            _studentDbContext.Students.Remove(student);

            await _studentDbContext.SaveChangesAsync();
            return Ok("Deleted Successfully");
        }
        //Update based on Name


        // UPDATE by Name
        [HttpPatch("byname/{Name}")]
        public async Task<IActionResult> UpdateStudentByName(string Name, Student student)
        {
            var existingstudent = await _studentDbContext.Students
                .FirstOrDefaultAsync(s => s.Name == Name);

            if (existingstudent == null)
                return NotFound();

            existingstudent.Name = student.Name;
            existingstudent.Course = student.Course;
            await _studentDbContext.SaveChangesAsync();
            return Ok(existingstudent);
        }

        // DELETE by Name
        [HttpDelete("byname/{Name}")]
        public async Task<IActionResult> DeleteStudentByName(string Name)
        {
            var student = await _studentDbContext.Students
                .FirstOrDefaultAsync(s => s.Name == Name);

            if (student == null)
                return NotFound();

            _studentDbContext.Students.Remove(student);
            await _studentDbContext.SaveChangesAsync();
            return Ok("Deleted Successfully");
        }
    }
}