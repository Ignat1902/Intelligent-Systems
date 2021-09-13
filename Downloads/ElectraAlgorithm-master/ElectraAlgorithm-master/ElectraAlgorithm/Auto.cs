using System;

namespace ParetoAlgorithm
{
   public class Auto
    {
        public string Brand;             // Название
        public float Price;              // Цена
        public int fuelConsumption;      // Расход топлива
        public int safetyAssessment;     // Оценка безопасности 
        public int qualityAssessment;    // Оценка качества
        public int Rating;               // Рейтинг
       
        public Auto(string brand, float price, 
                        int fuel, int safety,
                        int quality, int rating)
        {
            this.Brand = brand;
            this.Price = price;
            this.Rating = rating;
            this.fuelConsumption = fuel;
            this.qualityAssessment = quality;
            this.safetyAssessment = safety;
        }
        public override string ToString()
        {
            return $"{Brand}\t{Price}\t" +
                   $"{fuelConsumption}\t" +
                   $"{safetyAssessment}\t" +
                   $"{qualityAssessment}\t{Rating}";
        }
        public float GetField(string fieldName)
        {
            switch (fieldName)
            {
                case "Цена":
                    return Price;
                case "Расход топлива":
                    return fuelConsumption;
                case "Оценка безопасности":
                    return safetyAssessment;
                case "Оценка качества":
                    return qualityAssessment;
                case "Рейтинг":
                    return Rating;
                default:
                    return 0;   
            }
        }

    }
}
