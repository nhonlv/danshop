using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanShop.Data.Infratructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}