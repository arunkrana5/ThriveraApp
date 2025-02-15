using Common.Helpers;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ThriveraApp.Controllers
{
    public class MasterController : BaseController
    {
        GetResponse getResponse;
        public IActionResult Country(string src)
        {
            getResponse = new GetResponse();
            ViewBag.src = src;
            string[] GetQueryString = AppSettings.DecryptQueryString(src);
            ViewBag.GetQueryString = GetQueryString;
            ViewBag.MenuID = GetQueryString[0];
            ViewBag.TableName = "Country";
            ViewBag.Import = "True";
            ViewBag.CompanyCode = "bluestar";
            getResponse.DocType = ViewBag.TableName;
            List<Masters.List> list = new List<Masters.List>();
            return View(list);
        }
    }
}
