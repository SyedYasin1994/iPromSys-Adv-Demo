using iPromSys_Adv.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPromSys_Adv.Controllers
{
    public class ConstManagementController : Controller
    {
        // GET: ConstManagement
        public ActionResult Index()
        {
            List<CostSetupModel> model = new List<CostSetupModel>();
            model.Add(new CostSetupModel
            {
                CostCode = "C-123",
                Description = "C-123 Description"
            });
            model.Add(new CostSetupModel
            {
                CostCode = "B-146",
                Description = "B-146 Description"
            });
            model.Add(new CostSetupModel
            {
                CostCode = "X-098",
                Description = "X-098 Description"
            });
            return View(model);
        }
    }
}