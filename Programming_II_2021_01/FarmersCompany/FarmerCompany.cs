using System;
namespace Programming_II_2021_01.FarmersCompany
{
    public class FarmerCompany
    {
        Farmer[] Farmers = new Farmer[10];
        int farmerCount = 0;

        public void AddFarmer(Farmer newFarmer)
        {
            Farmers[farmerCount] = newFarmer;
            farmerCount++;
        }

        public float GetTotalSales()
        {
            float totalSales = 0;
            for (int i=0; i<farmerCount; i++)
            {
                totalSales = totalSales + Farmers[i].CalculateTotalCropsSales();
            }

            return totalSales;
        }

        public Crop CheapestSaleCrop()
        {
            Crop crop = Farmers[0].CheapestSaleCrop();
            int cropGender = Farmers[0].Gender;

            for (int i = 1; i < farmerCount; i++)
            {
                if (Farmers[i].CheapestSaleCrop().GetTotalProductionPrice(Farmers[i].Gender) < crop.GetTotalProductionPrice(cropGender))
                {
                    crop = Farmers[i].CheapestSaleCrop();
                    cropGender = Farmers[i].Gender;
                }
            }

            return crop;
        }
    }
}
