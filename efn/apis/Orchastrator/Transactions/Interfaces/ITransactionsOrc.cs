
using Domain.Layer.Transactions;
namespace Orchastrator.Transactions
{
    public interface ITransactionsOrc
    {
        /// <summary>
        /// The method to create selling transaction.
        /// </summary>
        /// <param name="sellingTransaction">Selling Transaction domain object.</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        bool CreateSellingTransaction(SellingTransaction sellingTransaction);

        /// <summary>
        /// The method to create 
        /// </summary>
        /// <param name="buyingTransaction"></param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        bool CreateBuyingTransaction(BuyingTransaction buyingTransaction);

        /// <summary>
        /// The method to get last buying transaction.
        /// </summary>
        /// <returns>The buying transaction domain object.</returns>
        BuyingTransaction GetLastBuyingTransaction(short userId);

        /// <summary>
        /// The method to calculate profit or loss.
        /// </summary>
        /// <param name="userId">The User id.</param>
        /// <returns>The profi or loss object.</returns>
        ProfitOrLoss GetProfitOrLoss(short userId);
    }
}
