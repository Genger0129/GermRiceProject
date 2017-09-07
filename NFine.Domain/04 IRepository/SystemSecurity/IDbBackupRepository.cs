/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Data;

namespace NFine.Domain.IRepository.SystemSecurity
{
    public interface IDbBackupRepository : IRepositoryBase<Sys_DbBackup>
    {
        void DeleteForm(string keyValue);
        void ExecuteDbBackup(Sys_DbBackup dbBackupEntity);
    }
}
