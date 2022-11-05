using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public abstract class Person : Common
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
