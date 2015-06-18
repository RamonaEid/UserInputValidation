using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIV.BL
{
    public class ValidatedItem : IValidatedItem
    {
        public string TextString { get; set; }

        public string MessageResult { get; set; }
    }
}
