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
        | PLC S7-1200 Data Type | C# Data Type      | Description                               | Attribute                           |
        |-----------------------|-------------------|-------------------------------------------|-------------------------------------|
        | BOOL                  | bool              | Boolean value (true or false)             | [MarshalAs(UnmanagedType.U1)]       |
        | BYTE                  | byte              | 8-bit unsigned integer                    | [MarshalAs(UnmanagedType.U1)]       |
        | WORD                  | ushort            | 16-bit unsigned integer                   | [MarshalAs(UnmanagedType.U2)]       |
        | DWORD                 | uint              | 32-bit unsigned integer                   | [MarshalAs(UnmanagedType.U4)]       |
        | INT                   | short             | 16-bit signed integer                     | [MarshalAs(UnmanagedType.I2)]       |
        | DINT                  | int               | 32-bit signed integer                     | [MarshalAs(UnmanagedType.I4)]       |
        | REAL                  | float             | 32-bit IEEE 754 floating-point number     | [MarshalAs(UnmanagedType.R4)]       |
        | LREAL                 | double            | 64-bit IEEE 754 floating-point number     | [MarshalAs(UnmanagedType.R8)]       |
        | CHAR                  | char              | Single 8-bit ASCII character              | [MarshalAs(UnmanagedType.I1)]       |
        | STRING                | string            | Array of characters (null-terminated)     | [MarshalAs(UnmanagedType.LPStr)]    |
        | S5TIME                | int               | S5 Time (16-bit, requires conversion)     | [MarshalAs(UnmanagedType.I4)]       |
        | TIME                  | uint              | IEC time (32-bit unsigned integer)        | [MarshalAs(UnmanagedType.U4)]       |
        | DATE                  | DateTime          | Date (converted to .NET DateTime)         | [MarshalAs(UnmanagedType.Struct)]   |
        | TIME_OF_DAY           | DateTime          | Time of day (converted to .NET DateTime)  | [MarshalAs(UnmanagedType.Struct)]   |
        | DATE_AND_TIME         | DateTime          | Date and time (converted to .NET DateTime)| [MarshalAs(UnmanagedType.Struct)]   |
        */


        //******************************** PLC DATA DB**************************************//
        //[StructLayout(LayoutKind.Sequential, Pack = 1)]
           public  class PlcDataRead
        {
            //[MarshalAs(UnmanagedType.U1)]
            public  byte Tag1 { get; set; }

           //[MarshalAs(UnmanagedType.U1)]
            public  byte Tag2 { get; set; }

          // [MarshalAs(UnmanagedType.U1)]
            public  byte Tag3 { get; set; }

           // MarshalAs(UnmanagedType.U4)]
            public  byte Tag4 { get; set; } // Real value (4 bytes)

            //check why properties works but witout propertis - only class id does not works!
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
            private static readonly short _plcPos = Properties.Settings.Default.Plcpos;
            private static readonly short _plcRack = Properties.Settings.Default.plcRack;

            public static string PLC_IP { get { return _plcAddr; } }
            public static short PLC_POS { get { return _plcPos; } }
            public static short PLC_RACK { get { return _plcRack; } }
        }
    }   
}
