using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSuite.Models.Templates;

public class GAction
{
    public string MacroName { get; set; }

    public Dictionary<string, string> Parameter { get; set; }
}
