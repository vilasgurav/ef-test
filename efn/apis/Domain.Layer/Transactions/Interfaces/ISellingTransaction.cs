
using Domain.Layer.Constants;
namespace Domain.Layer.Transactions
{

    /// <summary>
    /// The selling transaction domain class.
    /// </summary>
    public interface ISellingTransaction
    {
        /// <summary>
        /// THe main public method to expose to orchastrator.
        /// </summary>
        /// <param name="lastBuyingTransaction">The method which gives last buying transaction.</param>
        /// <returns>The profit or loss object.</returns>
        ProfitOrLoss GetProfitOrLoss(BuyingTransaction lastBuyingTransaction);

    }
}
