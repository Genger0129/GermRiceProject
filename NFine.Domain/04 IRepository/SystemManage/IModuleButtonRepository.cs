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
    public interface IModuleButtonRepository : IRepositoryBase<Sys_ModuleButton>
    {
        void SubmitCloneButton(List<Sys_ModuleButton> entitys);
    }
}
