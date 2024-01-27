using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cannon
{
   
    enum DesktopMaterials{
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
    enum RushOrder
    {
        ThreeDays = 3,
        FiveDays = 5,
        SevenDays =7
    }
    internal class Desk
    {
        // Properties instead of constants
        public static int MinWidth = 24; 
        public static int MaxWidth = 96;
        public static int MinDepth = 12;
        public static int MaxDepth = 48;
        public static int BaseCost = 200;
        private string __name;
        private int __width;
        private int __depth;
        private int __drawers;
        private DesktopMaterials __desktopMaterial;
        private RushOrder __rushOrderType;
        public string Name { get => __name; }
        public int Width { get => __width; }
        public int Depth { get => __depth; }
        public int Drawers { get => __drawers;}
        internal DesktopMaterials DesktopMaterial { get => __desktopMaterial; }
        internal RushOrder RushOrderType { get => __rushOrderType; }



        public Desk(string name, int width, int depth, int drawers, string materialString, string rushString) {
            __name = name;
            __width = width;
            __depth = depth;
            __drawers = drawers;
            

            //Rush Order Conversion
            string firstRushChar = rushString.Substring(0, 1);
            if (firstRushChar == "3")
            {
                string rushType = "ThreeDays";
                try
                {
                    if (Enum.TryParse<RushOrder>(rushType, true, out RushOrder rush))
                    {
                        __rushOrderType = rush;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine("Error Converting Rush input to Rush Order Enum " + ex.Message);
                }
            }

            //Desktop Material conversion
            //Cut out only the name
            string[] materialStringParts = materialString.Split(':');
            // Make sure the split worked
            if (materialStringParts.Length >= 2)
            {
                // Clear white space
                string materialText = materialStringParts[0].Trim();

                // Convert text to Enum type
                if (Enum.TryParse<DesktopMaterials>(materialText, true, out DesktopMaterials material))
                {
                    __desktopMaterial = material;
                }
            }

        }

    }

}
