using System;
using System.ComponentModel;

namespace Group14
{
    public enum VolunteerRole
    {
        [Description("Packer")] Packer,
        [Description("Collector")] Collector,
        [Description("Distributor")] Distributor,
        [Description("Driver")] Driver
    }
}
