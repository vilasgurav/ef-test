using Domain.Layer.Transactions;

namespace Repository.Transactions
{
    /// <summary>
    /// The interface buying transaction.
    /// </summary>
    public interface IBuyingTransactionRepository
    {
        /// <summary>
        /// The method to create 
        /// </summary>
        /// <param name="buyingTransaction"></param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        bool CreateBuyingTransaction(Domain.Layer.Transactions.BuyingTransaction urchaseTransaction);

        /// <summary>
        /// The method to get last buying transaction.
        /// </summary>
        /// <returns>The buying transaction domain object.</returns>
        Domain.Layer.Transactions.BuyingTransaction GetLastBuyingTransaction(short userId);
    }
}
