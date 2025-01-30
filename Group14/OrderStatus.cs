using System;
using System.ComponentModel;

namespace Group14
{
    public enum OrderStatus
    {
        [Description("Pending")] Pending,
        [Description("Sent")] Sent,
        [Description("Arrived")] Arrived,
        [Description("Canceled")] Canceled
    }
}
