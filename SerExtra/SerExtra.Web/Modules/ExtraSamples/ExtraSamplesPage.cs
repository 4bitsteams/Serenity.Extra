﻿
namespace SerExtra.ExtraSamples.Pages
{
    using MVC;
    using System.Web.Mvc;

    [Authorize, RoutePrefix("ExtraSamples"), Route("{action=index}")]
    public partial class ExtraSamplesController : Controller
    {
        public ActionResult MainGridInlineEditing()
        {
            return View(Views.ExtraSamples.MainGridInlineEditing.Index);
        }

        public ActionResult MainGridMultiEditing()
        {
            return View(Views.ExtraSamples.MainGridMultiEditing.Index);
        }

        public ActionResult CustomTemplatedGrid()
        {
            return View(Views.ExtraSamples.CustomTemplatedGrid.Index);
        }

        public ActionResult ReactSamplePage()
        {
            return View(Views.ExtraSamples.ReactSamplePage.Index);
        }

        public ActionResult ChatSamplePage()
        {
            return View(Views.ExtraSamples.Chat.ChatPage);
        }

    }
}
