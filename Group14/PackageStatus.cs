using System;
using System.ComponentModel;

namespace Group14
{
    public enum PackageStatus
    {
        [Description("Delivered")] Delivered,
        [Description("Not Delivered Yet")] Not_Delivered_Yet,
        [Description("Out For Delivery")] Out_For_Delivery
    }
}