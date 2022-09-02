using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword_Exercise_01_Answers;
public class RegularClass2
{
    public int _regularClassTotal;

    public RegularClass2()
    {
        StaticClass._regularClassesTotal++;
    }
}
