using System;
using System.Collections.Generic;
using System.Text;

namespace PlugBase
{
    public interface Generator
    {
        object generate(Type t);
    }
}
