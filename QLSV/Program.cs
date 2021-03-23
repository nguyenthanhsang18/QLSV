using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            SV s1 = new SV { MSSV = 1, Name = "NVA"};
            SV s2 = new SV { MSSV = 2, Name = "NVB" };
            SV s3 = new SV { MSSV = 3, Name = "NVC" };
            SV s4 = new SV { MSSV = 4, Name = "NVD" };
            QLSV.Instance.Add(s1);
            QLSV.Instance.Add(s4);
            QLSV.Instance.Insert(s3, 0);
            QLSV.Instance.Insert(s2, 1);
            QLSV.Instance.Sort();
            Console.WriteLine(QLSV.Instance);
            Console.ReadKey();
        }
    }
}
