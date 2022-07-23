namespace WPSOnline.Api.Model
{
    /// <summary>
    /// 基础model，包含了code和msg，基本上wps回调接口的出参都继承了它，方便出错的时候直接返回错误信息
    /// </summary>
    public class WPSBaseModel
    {
        public int code { get; set; } = 200;
        public string msg { get; set; } = "success";
    }
}