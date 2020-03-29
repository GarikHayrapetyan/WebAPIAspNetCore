using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using s19551Assingment3.DAL;

namespace s19551Assingment3.Controllers
{
    [ApiController]
    [Route("api/localstudent")]
    public class StudentsLocalController : ControllerBase
    {
        private readonly IDbService _db;
        public StudentsLocalController(IDbService db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_db.GetStudents());
        }
    }
}