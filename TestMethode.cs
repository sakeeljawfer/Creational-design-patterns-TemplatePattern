using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class TestMethode
    {
        static void Main()
        {
            ExcelFile obj = new ExcelFile();
            obj.ReadProcessAndSave();
            TextFile obj1 = new TextFile();
            obj1.ReadProcessAndSave();
        }
    }
}
