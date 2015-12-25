using System;
using System.Collections.Generic;
using System.Text;

namespace AL.Utils.NPOI.HSSF
{
    [Serializable]
    public class OldExcelFormatException:Exception
    {
        public OldExcelFormatException(String s)
            : base(s)
        { }

    }
}
