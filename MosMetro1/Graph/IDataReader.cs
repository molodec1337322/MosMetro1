using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    interface IDataReader
    {
        IUnderground DataRead(string filename);
    }
}
