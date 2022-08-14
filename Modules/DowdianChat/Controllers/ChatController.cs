using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Web.Mvc;

namespace Dowdian.Modules.DowdianChat.Controllers
{
    /// <summary>
    /// ChatController
    /// </summary>
    [DnnHandleError]
    public class ChatController : DnnController
    {
        /// <summary>
        /// Chat
        /// </summary>
        /// <returns></returns>
        public ActionResult Chat()
        {
            return View();
        }
    }
}
