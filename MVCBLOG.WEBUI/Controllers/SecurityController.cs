using MVCBLOG.BLL.UIServices.Class;
using MVCBLOG.ENTITY.Model_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBLOG.WEBUI.Controllers
{
    public class SecurityController : Controller
    {

        #region Variables

        private readonly ContactUIService ContactUIService;


        #endregion


        #region ctor

        public SecurityController()
        {
            ContactUIService = new ContactUIService();
        }

        #endregion


        #region Methods

        // GET: Security
        public ActionResult Csrf()
        {
            return View();
        }

        [HttpPost]
        // POST: Security
        public ActionResult Csrf(ContactDTO model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    bool insertOk = ContactUIService.Insert(model);

                    if (insertOk)
                    {
                        ViewBag.Message = 1;
                        ModelState.Clear();
                    }

                    else
                    {
                        ViewBag.Message = 2;
                        ModelState.Clear();
                    }

                }
            }


            return View();
        }

        #endregion




    }
}