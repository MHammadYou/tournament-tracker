namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            
            int.TryParse(placeNumber, out var placeNumberValue);
            PlaceNumber = placeNumberValue;
            
            decimal.TryParse(prizeAmount, out var prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out var prizePercentageValue);
            PrizePercentage = prizePercentageValue;
            
        }
        
    }
}