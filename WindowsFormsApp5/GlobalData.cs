using System;
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
