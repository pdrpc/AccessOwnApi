using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessOwnApi.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            //Requisição com lista endpoint api/address
            return View();
        }

        public ActionResult GetById() 
        {
            //Requisição GET com Id api/address/id
            return View();
        }

        public ActionResult RegisterNewAddress() 
        {
            //requisição POST com o cep api/address
            return View();
        }

        public ActionResult ModifyAddress() {
            //requisição PUT com o Address no Body
            return View();
        }

        public ActionResult DeleteAddress() {
            //Requisição DELETE com o Id
            return View();
        }
    }
}