using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SV
    {
        public int MSSV { get; set; }
        public string Name { get; set; }
        public void Show()
        {
            Console.WriteLine("MSSV = {0}, Name = {1}, DTB = {2}", MSSV, Name);
        }
        public override string ToString()
        {
            return "MSSV = " + MSSV + "; Name = " + Name ; 
        }

    }
}
