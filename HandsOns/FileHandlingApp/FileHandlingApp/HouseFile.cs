using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingApp
{
    class HouseFile
    {
        public void CreatHouse() 
        {
            //step 1 file creation
            FileStream filestreamobj = new FileStream("E:\\Capgemini\\.Net core\\Test\\MyFile.txt",FileMode.Create,FileAccess.Write);
            //file wwrite operation
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.WriteLine("Welcome");
            sw.Close();
            filestreamobj.Close();
        
        }
        public void ReadHouseDetails()
        {

        }
    }
}
