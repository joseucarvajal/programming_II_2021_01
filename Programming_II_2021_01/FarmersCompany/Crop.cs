using System;
namespace Programming_II_2021_01.FarmersCompany
{
    public class Crop
    {
        public String Name;
        public float UnitPrice;
        public float TaxPerUnit;
        public float UnitsXKm;
        public float ExtensionKm;

        float RealPriceMinusTaxesPerUnit(int gender) {
            if(gender == 0)
            {
                return UnitPrice - ((UnitPrice * (TaxPerUnit/100))/2);
            }
            return UnitPrice - (UnitPrice * (TaxPerUnit / 100));
        }

        float TotalProductionUnits()
        {
            return UnitsXKm * ExtensionKm;
        }

        public float GetTotalProductionPrice(int gender)
        {
            float realPrice = RealPriceMinusTaxesPerUnit(gender);
            float totalProductionUnits = TotalProductionUnits();

            return realPrice * totalProductionUnits;
        }
    }
}
