﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCart3BL
{
    public class Purchase
    {
        private Customer customer;
        private DateTime dateOfPurchase;
        private string paymentType;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;
        int purchaseCounter;

        public Customer Customer { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public string PaymentType { get; set; }

        public string PurchaseId { get; set; }

        public int QuantityOrdered { get; set; }

        public string ShippingAddress { get; set; }

        public double CalculateBillAmount(params Product[] products)
        {
            
        }

        public double CalculateBillAmount(Product product, int quantityRequired)
        {

        }
        public double CalculateDiscount()
        {
            return 0.05;
        }

        public Purchase()
        {

        }

        public Purchase(Customer customer, int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {

        }
    }
}
