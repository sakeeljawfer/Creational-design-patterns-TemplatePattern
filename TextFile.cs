using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public  class TextFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read Text data");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Text data");
        }
       
    }
}
