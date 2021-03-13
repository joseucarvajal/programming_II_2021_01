using System;
namespace Programming_II_2021_01.FarmersCompany
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Crop strawberryCrop = new Crop();
            strawberryCrop.Name = "Strawberry";
            strawberryCrop.UnitsXKm = 45;
            strawberryCrop.TaxPerUnit = 10;
            strawberryCrop.ExtensionKm = 10;
            strawberryCrop.UnitPrice = 15;

            Farmer pepito = new Farmer();
            pepito.Name = "Pepito";
            pepito.Gender = 1;
            pepito.AddCrop(strawberryCrop);


            Crop tomatoesCrop = new Crop();
            tomatoesCrop.Name = "Tomatoes";
            tomatoesCrop.UnitsXKm = 45;
            tomatoesCrop.TaxPerUnit = 15;
            tomatoesCrop.ExtensionKm = 10;
            tomatoesCrop.UnitPrice = 15;

            Farmer maria = new Farmer();
            maria.Name = "Maria";
            maria.Gender = 0;
            maria.AddCrop(tomatoesCrop);

            FarmerCompany farmerCompany = new FarmerCompany();
            farmerCompany.AddFarmer(pepito);
            farmerCompany.AddFarmer(maria);

            float totalSales = farmerCompany.GetTotalSales();
            Console.WriteLine("total amount to the entire set of farmers: " + totalSales);

            Crop cheapestCropSale = farmerCompany.CheapestSaleCrop();
            Console.WriteLine("Lowest price sell: " + cheapestCropSale.Name);
            Console.WriteLine(cheapestCropSale.ExtensionKm);
        }
    }
}
