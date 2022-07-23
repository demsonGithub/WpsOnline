using System.Collections.Generic;

namespace WPSOnline.Api.Model
{
    /// <summary>
    /// 获取历史版本入参
    /// </summary>
    public class GetHistoryRequest
    {
        /// <summary>
        /// 文件id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 记录偏移量
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        public int count { get; set; }
    }

    /// <summary>
    /// 获取历史版本出参
    /// </summary>
    public class GetHistoryResult : WPSBaseModel
    {
        /// <summary>
        /// 历史记录列表
        /// </summary>
        public List<HistroyModel> histories { get; set; }
    }

    /// <summary>
    /// 文件历史记录model
    /// </summary>
    public class HistroyModel
    {
        /// <summary>
        /// 文件id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public int version { get; set; }

        /// <summary>
        /// 文件大小，单位是B
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// 下载链接
        /// </summary>
        public string download_url { get; set; }

        /// <summary>
        /// 创建时间的时间戳（单位秒）
        /// </summary>
        public int create_time { get; set; }

        /// <summary>
        /// 修改时间的时间戳（单位秒）
        /// </summary>
        public int modify_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public UserModel creator { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public UserModel modifier { get; set; }
    }
}