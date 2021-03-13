using System;
namespace Programming_II_2021_01.FarmersCompany
{
    public class Farmer
    {
        public String Name;
        public int Gender; //0:female, 1:male
        Crop[] Crops = new Crop[10];
        int cropCount = 0;

        public void AddCrop(Crop newCrop)
        {
            Crops[cropCount] = newCrop;
            cropCount++;
        }

        public float CalculateTotalCropsSales()
        {
            float totalSales = 0;
            for (int i=0; i<cropCount; i++)
            {
                float totalCropSale = Crops[i].GetTotalProductionPrice(Gender);
                totalSales = totalSales
                                +
                             totalCropSale;
                Console.WriteLine("Crop " + Crops[i].Name + ", total: " + totalCropSale);
            }

            return totalSales;
        }

        public Crop CheapestSaleCrop()
        {
            Crop crop = Crops[0];

            for (int i=1; i<cropCount; i++)
            {
                if(Crops[i].GetTotalProductionPrice(Gender) < crop.GetTotalProductionPrice(Gender))
                {
                    crop = Crops[i];
                }
            }

            return crop;
        }
    }
}
