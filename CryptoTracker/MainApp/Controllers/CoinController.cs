using CryptoTracker.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CryptoTracker.Controllers
{
    public class CoinController : Controller
    {
        IList<ICoin> coins;

        public IEnumerable<ICoin> GetAllCoins()
        {
            return coins;
        }
    }
}
