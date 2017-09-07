using NFine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.IRepository.SystemManage
{
    public interface ICommonRepository<T> : IRepositoryBase<T> where T : class,new()
    {
    }
}
