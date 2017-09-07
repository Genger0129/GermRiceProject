/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Data;
using System.Collections.Generic;

namespace NFine.Domain.IRepository.SystemManage
{
    public interface IRoleRepository : IRepositoryBase<Sys_Role>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(Sys_Role roleEntity, List<Sys_RoleAuthorize> roleAuthorizeEntitys, string keyValue);
    }
}
