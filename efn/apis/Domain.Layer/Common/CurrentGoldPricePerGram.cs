
namespace Domain.Layer
{
    public class CurrentGoldPricePerGram
    {
        private CurrentGoldPricePerGram()
        {
        }
        private static CurrentGoldPricePerGram instance = null;
        public static CurrentGoldPricePerGram Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CurrentGoldPricePerGram();
                }
                return instance;
            }
        }
        public decimal? currentGoldPricePerGram { get; set; }
    }
}
