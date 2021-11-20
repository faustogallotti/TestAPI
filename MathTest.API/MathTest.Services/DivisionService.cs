using MathTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTest.Services
{
    public class DivisionService : IDivisionService
    {
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
