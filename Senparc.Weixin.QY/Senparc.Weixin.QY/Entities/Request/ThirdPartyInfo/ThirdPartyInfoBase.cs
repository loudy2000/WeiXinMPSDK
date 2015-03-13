﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：ThirdPartyInfoBase.cs
    文件功能描述：三方应用授权回调消息服务
    
    
    创建标识：Senparc - 20150313
    
    修改标识：Senparc - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.QY.Entities
{
    public interface IThirdPartyInfoBase : IRequestMessageBase
    {
        ThirdPartyInfo InfoType { get; }
        string SuiteId { get; set; }
        string TimeStamp { get; set; }
    }

    public class ThirdPartyInfoBase : RequestMessageBase, IThirdPartyInfoBase
    {
        #region 以下内容为第三方应用授权回调消息服务
        public virtual ThirdPartyInfo InfoType
        {
            get { return ThirdPartyInfo.SUITE_TICKET; }
        }

        /// <summary>
        /// 应用套件的SuiteId
        /// </summary>
        public string SuiteId { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string TimeStamp { get; set; }
        #endregion

        public ThirdPartyInfoBase()
            : base()
        {

        }
    }
}
