using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public static class GlobalData
    {

         /*
        | PLC S7-1200 Data Type | C# Data Type      | Description                               |
        |-----------------------|-------------------|-------------------------------------------|
        | BOOL                  | bool              | Boolean value (true or false)             |
        | BYTE                  | byte              | 8-bit unsigned integer                    |
        | WORD                  | ushort            | 16-bit unsigned integer                   |
        | DWORD                 | uint              | 32-bit unsigned integer                   |
        | INT                   | short             | 16-bit signed integer                     |
        | DINT                  | int               | 32-bit signed integer                     |
        | REAL                  | float             | 32-bit IEEE 754 floating-point number     |
        | LREAL                 | double            | 64-bit IEEE 754 floating-point number     |
        | CHAR                  | char              | Single 8-bit ASCII character              |
        | STRING                | string            | Array of characters (null-terminated)     |
        | S5TIME                | int               | S5 Time (16-bit, requires conversion)     |
        | TIME                  | uint              | IEC time (32-bit unsigned integer)        |
        | DATE                  | DateTime          | Date (converted to .NET DateTime)         |
        | TIME_OF_DAY           | DateTime          | Time of day (converted to .NET DateTime)  |
        | DATE_AND_TIME         | DateTime          | Date and time (converted to .NET DateTime)|
        */

        //******************************** PLC DATA DB**************************************//
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public class PlcData
        {
            [MarshalAs(UnmanagedType.U1)]
            public byte Tag1;

            [MarshalAs(UnmanagedType.U1)]
            public byte Tag2;

            [MarshalAs(UnmanagedType.U1)]
            public byte Tag3;

            [MarshalAs(UnmanagedType.R4)]
            public float Tag4; // Real value (4 bytes)
        }
        public static class mySpecialColor
        {
            //*************************** COLOR DATA ***********************************//
            //Color.FromArgb(255, 55, 168, 41)
            private static readonly Color _color = Color.FromArgb(255, 55, 168, 41);
            public static Color ColorGreen { get { return _color; } }

        }
        public static class WebPageAdresses
        {
            //*************************** WEBPAGE ADRESSES ***********************************//
            private static readonly string _grafanaWebPage = "http://192.168.107.100:3000";
            private static readonly string _noderedaWebPage = "http://192.168.107.100:1880";

            public static string GrafanaWebPageAdress { get { return _grafanaWebPage; } }
            public static string NodeRedaWebPageAdress { get { return _noderedaWebPage; } }
        }

        //*************************** PLC DATA ***********************************//
        public static class PlcGlobalData
        {
            private static readonly string _plcAddr = Properties.Settings.Default.plcipAddr;
            private static readonly uint _plcPos = Properties.Settings.Default.Plcpos;
            private static readonly uint _plcRack = Properties.Settings.Default.plcRack;

            public static string PLC_IP { get { return _plcAddr; } }
            public static uint PLC_POS { get { return _plcPos; } }
            public static uint PLC_RACK { get { return _plcRack; } }
        }
    }   
}
