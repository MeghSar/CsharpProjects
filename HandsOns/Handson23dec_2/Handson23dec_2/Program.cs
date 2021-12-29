using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson23dec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CourseData> courseObj = new List<CourseData>();

            courseObj.Add(new CourseData { Name = "C#", Duration = 3, CourseFee = 3000, CourseType = "Part Time" });
            courseObj.Add(new CourseData { Name = "ASP.NET", Duration = 2, CourseFee = 4000, CourseType = "Part Time" });
            courseObj.Add(new CourseData { Name = "JAVA", Duration = 4, CourseFee = 6000, CourseType = "Part Time" });
            courseObj.Add(new CourseData { Name = "Python", Duration = 1, CourseFee = 1000, CourseType = "Part Time" });


        }
    }
}
