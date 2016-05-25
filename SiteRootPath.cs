using Nancy;
using System;

namespace NancyTest02_HostOnOwin
{
    /// <summary>
    /// 提供网站物理路径的类
    /// </summary>
    public class SiteRootPath:IRootPathProvider
    {
        /**************************************************************
         * TinyFox Owin Server 默认情况下
         * 网站是放在 TinyFox 进程所在文件夹下的site/wwwroot中的
         * ----------------------------------------------------------
         * 如果你把 NancyFx 的 Views 页放在其它的地方，应该作相应修改
         *******************************************************************/

        /// <summary>
        /// 网站根文件夹物理路径(for tinyfox)
        /// </summary>
        static readonly string _siteRootPath = AppDomain.CurrentDomain.GetData(".appPath").ToString();

        /// <summary>
        /// 获取网站或WEB应用的根文件夹的物理路径
        /// </summary>
        /// <returns></returns>
        public string GetRootPath()
        {
            return _siteRootPath;
        }

    }
}