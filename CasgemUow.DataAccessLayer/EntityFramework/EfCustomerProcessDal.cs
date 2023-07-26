using CasgemUow.DataAccessLayer.Abstract;
using CasgemUow.DataAccessLayer.Concrete;
using CasgemUow.DataAccessLayer.Repositories;
using CasgemUow.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUow.DataAccessLayer.EntityFramework
{
    public class EfCustomerProcessDal : GenericRepository<CustomerProcess>, ICustomerProcessDal
    {
        public EfCustomerProcessDal(Context context) : base(context)
        {
        }
    }
}
