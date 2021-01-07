using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class ExcelFile : DataProcessor
    {
        
        public override void ReadData()
        {
            Console.WriteLine("Read Excel data");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Excel data");
        }
       
    }
}
