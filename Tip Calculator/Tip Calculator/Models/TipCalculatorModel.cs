namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        public decimal MealCost { get; set; }
        public string ErrorMessage { get; set; }

        public decimal CalculateTip(decimal percentage)
        {
            return MealCost * percentage / 100;
        }
    }
}
