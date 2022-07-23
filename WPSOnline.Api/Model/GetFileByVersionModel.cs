namespace WPSOnline.Api.Model
{
    /// <summary>
    /// 获取特定版本的文件信息 出参
    /// </summary>
    public class GetFileByVersionResult : WPSBaseModel
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
        /// 文件大小，单位B
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// 创建者用户名
        /// </summary>
        public string creator { get; set; }

        /// <summary>
        /// 创建时间的时间戳（单位秒）
        /// </summary>
        public int create_time { get; set; }

        /// <summary>
        /// 修改者用户名
        /// </summary>
        public string modifier { get; set; }

        /// <summary>
        /// 修改时间的时间戳（单位秒）
        /// </summary>
        public int modify_time { get; set; }

        /// <summary>
        /// 下载链接
        /// </summary>
        public string download_url { get; set; }
    }
}