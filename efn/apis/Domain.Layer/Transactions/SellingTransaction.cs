
using Domain.Layer.Constants;
namespace Domain.Layer.Transactions
{

    /// <summary>
    /// The selling transaction domain class.
    /// </summary>
    public class SellingTransaction : ISellingTransaction
    {
        /// <summary>
        /// THe main public method to expose to orchastrator.
        /// </summary>
        /// <param name="lastBuyingTransaction">The method which gives last buying transaction.</param>
        /// <returns></returns>
        public ProfitOrLoss GetProfitOrLoss(BuyingTransaction lastBuyingTransaction)
        {
            return GetProfitOrLoss(CalculatePurchasedPricePerGram(lastBuyingTransaction.PurchasedRatePerGram), CalculateSellingPricePerGram(lastBuyingTransaction));
        }

        /// <summary>
        /// The method to calculate selling price per gram.
        /// </summary>
        /// <param name="buyingRatePerGram">The base buying rate per gram.</param>
        /// <returns></returns>
        private decimal CalculateSellingPricePerGram(BuyingTransaction lastBuyingTransaction)
        {
            return (decimal)CurrentGoldPricePerGram.Instance.currentGoldPricePerGram + DomainConstants.COMMISSION_PER_GRAM + (lastBuyingTransaction.PurchasedRatePerGram * 5) / 100;
        }

        /// <summary>
        /// The method to calculate last purchased price per gram.
        /// </summary>
        /// <param name="PurchasedRatePerGram">The base purchased rate per gram</param>
        /// <returns></returns>
        private decimal CalculatePurchasedPricePerGram(decimal purchasedRatePerGram)
        {
            return purchasedRatePerGram + DomainConstants.COMMISSION_PER_GRAM + ((purchasedRatePerGram * DomainConstants.GST_PERCENTAGE) / 100);
        }

        /// <summary>
        /// The method to return the selling the gold would be in profit or loss.
        /// </summary>
        /// <param name="purchasedPricePerGram">If this price is greater than selling price per gram then the seller is in profit; else loss</param>
        /// <param name="sellingPricePerGram">Selling price per gram</param>
        /// <returns>The profit or loss object.</returns>
        private ProfitOrLoss GetProfitOrLoss(decimal buyingPrice, decimal sellingPrice)
        {
            ProfitOrLoss profitOrLoss = new ProfitOrLoss();
            if (buyingPrice <= sellingPrice)
            {
                //The selling trnsaction is in profit.
                return new ProfitOrLoss()
                {
                    IsProfit = true,
                    Amount = sellingPrice - buyingPrice
                };
            }
            else
            {
                //The selling trnsaction is in loss.
                return new ProfitOrLoss()
                {
                    IsProfit = false,
                    Amount = buyingPrice - sellingPrice
                };
            }
        }
    }
}
