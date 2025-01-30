using System;
using System.ComponentModel;

namespace Group14
{
    public enum ItemStatus
    {
        [Description("In Stock")] In_Stock,
        [Description("Out Of Stock")] Out_Of_Stock,
        [Description("Damage")] Damage,
        [Description("Expired")] Expired
    }
}