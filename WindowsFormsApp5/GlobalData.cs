﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public static class GlobalData
    {
        public static class mySpecialColor
        {
            private static readonly Color _color = Color.FromArgb(255, 55, 168, 41);
            public static Color ColorGreen { get { return _color; } }

        }
    //Color.FromArgb(255, 55, 168, 41)
    }
}
