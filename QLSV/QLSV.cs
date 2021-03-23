using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class QLSV
    {
        private static QLSV _Instance;
        public static QLSV Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new QLSV();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public SV[] arr { get; set; }
        public int n { get; set; }
        private QLSV()
        {
            arr = null;
            n = 0;
        }
        public void Add(SV s)
        {
            if(n == 0)
            {
                arr = new SV[n + 1];
                arr[n] = s;
            }
            else
            {
                SV[] t = new SV[n];
                for(int i = 0; i < n; i++)
                {
                    t[i] = arr[i];
                }
                arr = new SV[n + 1];
                for(int i = 0; i < n; i++)
                {
                    arr[i] = t[i];
                }
                arr[n] = s;
            }
            n++;
        }
        public void Insert(SV s, int k)
        {
            if(n == 0)
            {
                arr[n] = s;
            }
            else if(n < k)
            {
                this.Add(s);
            }
            else
            {
                SV[] t = new SV[n];
                for(int i = 0; i < n ; i++)
                {
                    t[i] = arr[i];
                }
                arr = new SV[n + 1];
                for(int i = 0; i < k; i++)
                {
                    arr[i] = t[i];
                }
                for(int i = k; i < n; i++)
                {
                    arr[i + 1] = t[i];
                }    
                arr[k] = s;
            }
            n++;
        }
        public int IndexOF(SV s)
        {
            int index = -1;
            for(int i = 0; i < n; i++)
            {
                if(arr[i] == s)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void RemoveAt(int index)
        {
            if(index >=n )
            {
                Console.Write("Vi tri can xoa khong nam trong danh sach");
            }
            else if(n == 1)
            {
                arr = null;
            }
            else
            {
                SV[] t = new SV[n];
                for(int i = 0; i < n; i++)
                {
                    t[i] = arr[i];
                }
                arr = new SV[n - 1];
                for(int i = 0; i < index; i++)
                {
                    arr[i] = t[i];
                }
                for(int i = index; i < n - 1; i++)
                {
                    arr[i] = t[i + 1];
                }
            }
            n--;
        }
        public void Remove(SV s)
        {
            RemoveAt(IndexOF(s));
        }
        public void Update(int m)
        {
            for(int i = 0; i < n; i++)
            {
                if(arr[i].MSSV == m)
                {
                    Console.WriteLine("Nhap Ten SV: ");
                    arr[i].Name = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("MSSV khong ton tai");
                }
            }
        }
        public void Sort()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if((string.Compare(arr[j].Name, arr[i].Name) < 0))
                    {
                        SV a = new SV();
                        a = arr[j];
                        arr[j] = arr[i];
                        arr[i] = a;
                    }
                }
            }
        }
        public override string ToString()
        {
            string r = "";
            foreach(SV i in arr)
            {
                r += i.ToString() + "\n";
            }
            return r;
        }
    }
}
