using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lyweb2.Controllers
{
    public class HomeController : Controller
    {

        List<Scenery> lst=new List<Scenery>();


        public ActionResult Index()
        {
            //lst.Add(new Scenery()
            //{
            //    id = 1,name="Geneva",image="1.jpeg",description="Geneva is the second largest of Switzerland. In 2004,Geneva`s population is 185526 people",area="Europe"

            //});
            //lst.Add(new Scenery()
            //{
            //    id = 2,
            //    name="Ukraine",
            //    image="2.jpeg",
            //    description="In Ukraine，National aviation museum is located in Kiev, near progenitor hani Airport(Zhulyany Airport), founded in 2003, for Ukraine's youngest museum, is also the largest museum about Ukraine aviation history and technology. ",
            //    area="Europe"

            //});
            //lst.Add(new Scenery()
            //{
            //    id = 3,
            //    name="Guizhou",
            //    image="3.jpeg",
            //    description="Guizhou Province is located in the hinterland of the southwestern inland region and is a transportation hub in the southwestern region. It is an important component of the Yangtze River Economic Belt. ",
            //    area="Asia"

            //});

            //lst.Add(new Scenery()
            //{
            //    id = 4,
            //    name="the Nile",
            //    image="4.jpeg",
            //    description="The Nile Valley keeps a temperate climate throughout the year.",
            //    area="Africa"

            //});
            //lst.Add(new Scenery()
            //{
            //    id = 5,
            //    name="Bali",
            //    image="5.jpeg",
            //    description="In India and Bali students learn to vocalize music before ever picking up instruments.",
            //    area="Asia"

            //});
            //lst.Add(new Scenery()
            //{
            //    id = 6,
            //    name="Auckland",
            //    image="6.jpeg",
            //    description="The winner will face the Oakland A's in the playoffs this weekend..",
            //    area="Australia;"

            //});

            if(tempData.sceneries==null||tempData.sceneries.Count==0)
            {
                tempData.CreateData();
            }
            ViewBag.lst = tempData.sceneries;
            ViewBag.TestStr="Test Home Data";

            return View();
        }

        public ActionResult About()
        {
         
            return View();
        }

        public ActionResult List()
        {

            if (tempData.sceneries==null||tempData.sceneries.Count==0)
            {
                tempData.CreateData();
            }

            string value = Request.QueryString["key"].ToString();
            Console.WriteLine(value);
            var ls = tempData.sceneries.Where(p => p.name.Contains(value)).ToList();

            if(ls.Count > 0)
            {
                ViewBag.lst = ls;
            }else
            {
                ls= tempData.sceneries.Where(p=>p.area==value).ToList();
                if(ls.Count==0)
                {
                   ViewBag.lst=null;
                }else
                {
                    ViewBag.lst=ls;
                }
                
            }

         

            return View();
        }

        public ActionResult Detail()
        {

            if (tempData.sceneries==null||tempData.sceneries.Count==0)
            {
                tempData.CreateData();
            }
            int id = Convert.ToInt32(Request.QueryString["id"]);


            var ls = tempData.sceneries.FirstOrDefault(p => p.id==id);
            if (ls != null)
            {
                ViewBag.obj = ls;
            }
            else
            {
                ViewBag.obj="";
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}