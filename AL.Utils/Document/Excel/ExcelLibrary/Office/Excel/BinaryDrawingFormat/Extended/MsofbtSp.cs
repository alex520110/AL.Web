﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AL.Utils.ExcelLibrary.BinaryDrawingFormat
{
	public partial class MsofbtSp : EscherRecord
	{
        public ShapeType ShapeType
        {
            get
            {
                return (ShapeType)Instance;
            }
            set
            {
                Instance = (ushort)value;
            }
        }
	}
}
