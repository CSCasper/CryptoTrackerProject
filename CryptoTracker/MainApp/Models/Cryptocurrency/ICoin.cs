using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Models
{
    public interface ICoin
    {
        string CoinName { get; }
        int CoinId { get; }
        string ProofType { get; }
        float CurrentPrice { get; }
        int CurrentVolume { get; }
    }
}
