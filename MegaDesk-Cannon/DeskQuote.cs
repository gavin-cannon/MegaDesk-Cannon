using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cannon
{
    internal class DeskQuote
    {
        private string __quoteDescription;
        private decimal __quotePrice;
        private Desk __desk;

        public string QuoteDescription { get => __quoteDescription; }

        private decimal CalculateQuotePrice(){
            decimal total = Desk.BaseCost;
            decimal surfaceArea = (decimal)__desk.Width * (decimal)__desk.Depth;
            total += surfaceArea;
            decimal drawerCost = (decimal)__desk.Drawers * 50;
            total += drawerCost;
            total += (decimal)__desk.DesktopMaterial;
            if ((int)__desk.RushOrderType == 3) { 
                if(surfaceArea < 1000)
                {
                    total += 60;
                }
                else if(surfaceArea > 1000 &&  surfaceArea < 2000)
                {
                    total += 70;
                }
                else if(surfaceArea > 2000)
                {
                    total += 80;
                }
            }
            else if((int)__desk.RushOrderType == 5)
            {
                if (surfaceArea < 1000)
                {
                    total += 40;
                }
                else if (surfaceArea > 1000 && surfaceArea < 2000)
                {
                    total += 50;
                }
                else if (surfaceArea > 2000)
                {
                    total += 60;
                }
            }
            else if((int)__desk.RushOrderType == 7)
            {
                if (surfaceArea < 1000)
                {
                    total += 30;
                }
                else if (surfaceArea > 1000 && surfaceArea < 2000)
                {
                    total += 35;
                }
                else if (surfaceArea > 2000)
                {
                    total += 40;
                }
            }
            return total;

        }
        public void CreateQuote()
        {
            this.CalculateQuotePrice();

        }

        public DeskQuote(Desk desk, DateTime submissionDate)
        {
            __desk = desk;
            __quotePrice = CalculateQuotePrice();
            
            __quoteDescription = $"Name: {__desk.Name}\nWidth: {__desk.Width}\nDepth: {__desk.Depth}\nDrawers: {__desk.Drawers}\nMaterial: {Enum.GetName(typeof(DesktopMaterials), __desk.DesktopMaterial)}\nRush Order: {(int)__desk.RushOrderType} days\nTotal Price: {__quotePrice}";
        }
    }
}
