using System;
using System.ComponentModel;

namespace Group14
{
    public enum EmployeeRole
    {
        [Description("CEO")] CEO,
        [Description("Deputy CEO")] DeputyCEO,
        [Description("Accountant")] Accountant,
        [Description("Lawyer")] Lawyer,

    }
}