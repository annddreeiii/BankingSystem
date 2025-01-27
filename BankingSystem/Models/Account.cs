﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models
{
    internal class Account : Transaction
    {
        public string AccountId { get; set; }
        public double Balance { get; set; }
        public List<Transaction> TransactionHistory { get; set; }

        public Account(string accountId, string transactionId, double balance, string transactionType)
            : base(transactionId, balance, transactionType)
        {
            AccountId = accountId;
            Balance = balance;
            TransactionHistory = new List<Transaction>();
        }
    }
}
