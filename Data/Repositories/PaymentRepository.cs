using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>
    {
        public PaymentRepository(DbContext context) : base(context)
        {

        }
    }
}
