using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_2022_Blazor.Service
{
    public class Services
    {

    }
    public class SingletonService
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Value { get; set; }

        public void Inc(ref int increment)
        {
            increment++;
            Value = increment;

        }
    }
}
