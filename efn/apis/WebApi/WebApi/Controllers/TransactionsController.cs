using Domain.Layer.Transactions;
using Orchastrator.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/v1/transaction")]
    public class TransactionsController : ApiController
    {
        ITransactionsOrc transactions;

        [HttpPost]
        [Route("selling-transaction")]
        public IHttpActionResult CreateSellingTransaction(SellingTransaction sellingTransaction)
        {
            transactions = new TransactionsOrc();
            return Ok(transactions.CreateSellingTransaction(sellingTransaction));
        }

        [HttpPost]
        [Route("buying-transaction")]
        public IHttpActionResult CreateBuyingTransaction(BuyingTransaction buyingTransaction)
        {
            transactions = new TransactionsOrc();
            return Ok(transactions.CreateBuyingTransaction(buyingTransaction));
        }

        [HttpGet]
        [Route("profit-or-loss-calculator")]
        public IHttpActionResult getProfitOrLoss(short userId)
        {
            transactions = new TransactionsOrc();
            return Ok(transactions.GetProfitOrLoss(userId));
        }
    }
}
