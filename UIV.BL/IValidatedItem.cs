using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIV.BL
{
    public interface IValidatedItem
    {
        string TextString { get; set; }
        string MessageResult { get; set; }
    }
}
