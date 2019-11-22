using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Payment
    {
        public Employee Employee { get; set; }
        public int Id { get; set; }
        public PaymentType Type { get; set; }
    }

    public enum PaymentType
    {
        Paycheck, Bonus
    }
}
