using C_EgitimKampi301.DataAccessLayer.Abstract;
using C_EgitimKampi301.DataAccessLayer.Repositories;
using C_EgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>, ICustomerDal
    {
    }
}
