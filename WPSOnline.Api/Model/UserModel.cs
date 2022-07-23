namespace WPSOnline.Api.Model
{
    /// <summary>
    /// 用户信息model
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 用户头像地址
        /// </summary>
        public string avatar_url { get; set; }
    }
}