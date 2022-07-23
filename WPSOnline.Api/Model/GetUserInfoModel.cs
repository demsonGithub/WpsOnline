using System.Collections.Generic;

namespace WPSOnline.Api.Model
{
    /// <summary>
    /// 获取用户信息 入参model
    /// 通知此文件目前有那些人正在协作 入参model
    /// </summary>
    public class GetUserInfoRequest
    {
        /// <summary>
        /// 用户id数组
        /// </summary>
        public List<string> ids { get; set; }
    }
}