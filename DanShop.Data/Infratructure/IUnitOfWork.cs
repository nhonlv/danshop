using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanShop.Data.Infratructure
{
    interface IUnitOfWork
    {
        void Commit();
    }
}