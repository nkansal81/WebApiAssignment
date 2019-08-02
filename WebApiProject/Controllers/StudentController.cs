using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public List<Student> Get()
        {
            Student st4 = new Student();
            List<Student> lss4 = st4.people();
            return lss4;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public List<Student> Post([FromBody] Student value)
        {
            Student st1 = new Student();
            List<Student> lss1 = st1.people();
            lss1.Add(value);
            return lss1;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public List<Student> Put ([FromBody] Student value)
        {
            Student st = new Student();
            List<Student> lss = st.people();
            int i;
            for(i=0;i<lss.Count;i++)
            { 
                if ((lss[i].ID==value.ID) || (lss[i].FirstName==value.FirstName)||(lss[i].LastName==value.LastName)||(lss[i].Division==value.Division)||(lss[i].Grade==value.Grade))
                {
                    lss[i].ID = value.ID;
                    lss[i].FirstName = value.FirstName;
                    lss[i].LastName = value.LastName;
                    lss[i].Division = value.Division;
                    lss[i].Grade = value.Grade;
                }
               
            }
            
            return lss;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public List<Student> Delete(int id,[FromBody] Student value)
        {
            Student st3 = new Student();
            List<Student> lss3 = st3.people();
            for (int i = 0; i < lss3.Count; i++)
            {
                if (lss3[i].ID == value.ID || (lss3[i].FirstName == value.FirstName) || (lss3[i].LastName == value.LastName) || (lss3[i].Division == value.Division) || (lss3[i].Grade == value.Grade))
                {
                    lss3.RemoveAt(i);
                    break;
                }
                
            }
            

            return lss3;
        }

    }
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Division { get; set; }
        public string Grade { get; set; }

        public List<Student> people()
        {
             List<Student> students = new List<Student>();

            students.Add(new Student { ID = 110402, FirstName = "Nitika", LastName = "Kansal", Division = "1st", Grade = "A" });
            students.Add(new Student { ID = 110404, FirstName = "Anita", LastName = "Kansal", Division = "1st", Grade = "B" });
            students.Add(new Student { ID = 110403, FirstName = "Ruchika", LastName = "Aggarwal", Division = "2nd", Grade = "C" });
            students.Add(new Student { ID = 110401, FirstName = "Himadari", LastName = "Bajaj", Division = "1st", Grade = "A+" });
            return students;

        }
       
    }
    
}
