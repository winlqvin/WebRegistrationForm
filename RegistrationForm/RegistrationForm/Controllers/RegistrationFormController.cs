using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml;

namespace RegistrationForm.Controllers
{
    public class RegistrationFormController : Controller
    {
        //
        // GET: /RegistrationForm/

        public ActionResult Index(RegistrationAccount g)
        {

            RegistrationAccount registrationaccount = new RegistrationAccount();
            List<SelectListItem> sexs = new List<SelectListItem>();
            
            sexs.Add(new SelectListItem { Text = "Nam", Value = "0" });
            sexs.Add(new SelectListItem { Text = "Nữ", Value = "1" });

            
            ViewBag.SexyType = sexs;
            XmlDocument doc = new XmlDocument();
            string pathfile = Server.MapPath("~/Data.xml");
            doc.Load(pathfile);
            XmlElement goc = doc.DocumentElement;
            XmlNodeList listcity = goc.SelectNodes("TINH_THANH");
            List<SelectListItem> cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "Tỉnh/Thành", Value = "0" });
            int i = 1;
            foreach (XmlNode item in listcity)
            {
                cities.Add(new SelectListItem { Text = item.Attributes["ten"].Value, Value = i.ToString() });
                i++;
            }
            ViewBag.Citis = cities;

            return View(g);
        }

    }
}
