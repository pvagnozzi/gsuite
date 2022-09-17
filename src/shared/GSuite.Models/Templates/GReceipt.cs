using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSuite.Models.Templates;

public class GBox
{
    public string Name { get; set; }

    public int Position { get; set; }
}


public class GReceipt
{
    public string Name { get; set; }

    public IList<GBox> Boxes { get; set; }

    public IList<GAction> Actions { get; set; }
}

