using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using WPSOnline.Api.Enum;

namespace WPSOnline.Api.Help
{
    /// <summary>
    /// wps生成签名的帮助类
    /// </summary>
    public class WPSSignatureHelper
    {
        // url示例： https://wwo.wps.cn/office/w/999888777?_w_appid=d2a400fa455e42208c74a3de41d3cb3b&_w_myName=self&_w_signature=G8lG%2Bf0A%2BSbqrVFoMpmuLVOE8tM%3D

        /// <summary>
        /// AppId
        /// </summary>
        private static string AppId = string.Empty;

        /// <summary>
        /// AppKey
        /// </summary>
        private static string AppSecretKey = string.Empty;

        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecretKey"></param>
        public static void Config(string appId, string appSecretKey)
        {
            AppId = appId;
            AppSecretKey = appSecretKey;
        }

        public static string GenerateUrl(string fileId, FileType fileType, Dictionary<string, string> dicParam = null)
        {
            if (string.IsNullOrEmpty(AppId) || string.IsNullOrEmpty(AppSecretKey))
            {
                throw new ArgumentException("未配置AppId和AppSecretKey,在Startup构造函数中配置");
            }
            if (dicParam == null)
            {
                dicParam = new Dictionary<string, string>();
            }
            dicParam.Add("_w_appid", AppId);
            var paramsStr = Signature(dicParam);
            return $"https://wwo.wps.cn/office/{fileType.ToString()}/{fileId}?{paramsStr}";
        }

        /// <summary>
        /// 对参数签名
        /// </summary>
        /// <param name="paramDic"></param>
        /// <returns>签名后的字符串</returns>
        public static string Signature(Dictionary<string, string> paramDic)
        {
            var sortParam = paramDic.OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            sortParam.Add("_w_secretkey", AppSecretKey);
            var paramStr = string.Join("", sortParam.Select(p => $"{p.Key}={p.Value}").ToArray());
            var signature = ToHMACSHA1(paramStr);
            sortParam.Remove("_w_secretkey");
            sortParam.Add("_w_signature", HttpUtility.UrlEncode(signature));
            return string.Join("&", sortParam.Select(p => $"{p.Key}={p.Value}").ToArray());
        }

        private static string ToHMACSHA1(string encryptText)
        {
            HMACSHA1 hmacsha1 = new HMACSHA1();
            hmacsha1.Key = System.Text.Encoding.Default.GetBytes(AppSecretKey);
            byte[] dataBuffer = System.Text.Encoding.Default.GetBytes(encryptText);
            byte[] hashBytes = hmacsha1.ComputeHash(dataBuffer);
            return Convert.ToBase64String(hashBytes);
        }
    }
}