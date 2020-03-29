using s19551Assingment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s19551Assingment3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
