using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    public class ClinicFactory : TransactionFactory
    {
        public override ITransaction Create(int transactionId) => new ClinicTransaction();
    }
}
