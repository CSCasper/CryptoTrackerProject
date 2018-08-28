using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoTracker.Models
{
    public class Coin : ICoin
    {
        protected int coinId;
        protected string coinName;
        protected float currentPrice;
        protected int currentVolume;
        protected string proofType;
    
        public int CoinId
        {
            get { return coinId; }
        }

        public string CoinName
        {
            get { return coinName; }
        }

        public float CurrentPrice
        {
            get { return currentPrice; }
        }

        public int CurrentVolume
        {
            get { return currentVolume; }
        }

        public string ProofType
        {
            get { return proofType; }
        }
    }
}