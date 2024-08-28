using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beauty_salon_project.Utils
{
    internal interface INationalCodeValidator
    {
        bool isvalid(string nationalCode);
        bool IsNotExist(string nationalCode);
        bool EditIsExist(string nationalCode, int pc);
    }
}
