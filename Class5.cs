using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_library
{
    public delegate void YearofServiceDelegate(int _joiningyear);
    public class Employee
    {
        private int _joiningyear;

        public int JoiningYear
        {
            get { return _joiningyear; }
            set { _joiningyear = value; }
        }
        static void Main(string[] args)
        {

            Employee f = new Employee();
            e.YearOfService
            YearofServiceDelegate f = new YearofServiceDelegate(e.YearOfService);
            f.Invoke();
            f();

        }
    }
}
