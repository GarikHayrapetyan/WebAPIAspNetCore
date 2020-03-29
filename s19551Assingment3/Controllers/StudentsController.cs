using Microsoft.AspNetCore.Mvc;
using s19551Assingment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

///Attention!!!
///I could not implement interface for real database, which I will clearify during next class.
///Therefor I have implemented the interface for an artifical database using StudentsLocalController class. 

namespace s19551Assingment3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController:ControllerBase
    {
        StudentsContext db;

        public StudentsController(StudentsContext context)
        {
            db = context;

            if (!db.GetStudents.Any())
            {
                db.GetStudents.Add(new Student { Name="A",Surname="B", IndexNumber="s1236"});
                db.SaveChanges();
            }
        }

      //  [HttpGet()]
      //  public string Index()
      //  {
      //      return "Garik, Aram, Narek";
      //  }

        [HttpGet("{id}")]
        public IActionResult GetStudents(int id)
        {
            if (id == 1)
            {
                return Ok("Garik");
            }
            else if (id == 2)
            {
                return Ok("Aram");
            }
            return NotFound("Not found any student");
        }

        [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Garik, Aram, Narek oreder by{orderBy}";
        }


        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1,10000)}";

            db.GetStudents.Add(student);
            db.SaveChanges();

            return Ok(student);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            Student student = db.GetStudents.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            db.GetStudents.Remove(student);
            db.SaveChangesAsync();
            return Ok(student);
            
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int id)
        {
            Student student = db.GetStudents.FirstOrDefault(x => x.Id == id);

            if (!db.GetStudents.Any(x => x.Id == id))
            {
                return NotFound();
            }

            student.IndexNumber = "S7894";

            db.Update(student);
            db.SaveChanges();
            return Ok(student);
        }


    }
}
