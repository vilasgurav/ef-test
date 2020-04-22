using Domain.Layer.Transactions;

namespace Repository.Transactions
{
    /// <summary>
    /// The interface selling transaction.
    /// </summary>
    public interface ISellingTransactionRepository
    {
        /// <summary>
        /// The method to create selling transaction.
        /// </summary>
        /// <param name="sellingTransaction">Selling Transaction domain object.</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        bool CreateSellingTransaction(SellingTransaction urchaseTransaction);
    }
}
