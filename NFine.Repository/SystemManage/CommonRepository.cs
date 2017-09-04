using NFine.Data;
using NFine.Domain.IRepository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Repository.SystemManage
{
    public class CommonRepository<T> : RepositoryBase<T>, ICommonRepository<T> where T : class,new()
    {
    }
}
