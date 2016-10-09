using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    /// <summary>
    /// Summary description for imageHandler
    /// </summary>
    public class imageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request["id"] != null)
            {
                int nekretninaID = Convert.ToInt32(context.Request["id"]);

                if (nekretninaID > 0)
                {
                    Nekretnine n = DANekretnine.SelectById(nekretninaID);

                    if (n.SlikaThumb != null)
                    {
                        context.Response.ContentType = "image/jpg";
                        context.Response.BinaryWrite(n.SlikaThumb);
                    }
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}