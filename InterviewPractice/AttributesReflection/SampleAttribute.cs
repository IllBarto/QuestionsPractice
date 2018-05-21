using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AttributesReflection
{
    class SampleAttribute: Attribute
    {
        public string SampleName { get; set; }
    }
}
