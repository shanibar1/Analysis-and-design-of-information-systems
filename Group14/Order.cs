using System;

namespace Group14
{
    public class Order {
        private string orderId;
        private OrderStatus orderStatus;
        private float totalAmount;
        private DateTime orderDate; // PAY ATTENTION - DATE!!!
        private PaymentMethod paymentMethod;

        public float CalculateTotalAmount() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void SendToAccountant() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void SetDelivery() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void UpdateBudget() {
            throw new System.NotImplementedException("Not implemented");
        }
        public void AccessToPrevious() {
            throw new System.NotImplementedException("Not implemented");
        }
        public Order() {
            throw new System.NotImplementedException("Not implemented");
        }


    }
}