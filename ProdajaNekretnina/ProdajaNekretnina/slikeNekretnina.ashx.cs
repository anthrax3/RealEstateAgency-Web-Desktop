using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    /// <summary>
    /// Summary description for slikeNekretnina
    /// </summary>
    public class slikeNekretnina : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request["id"] != null)
            {
                int slikaID = Convert.ToInt32(context.Request["id"]);

                if (slikaID > 0)
                {
                    SlikeNekretnina sl = DANekretnine.SelectSlika(slikaID);

                    if (sl.SlikaNekretnine != null)
                    {
                        context.Response.ContentType = "image/jpg";
                        context.Response.BinaryWrite(sl.SlikaNekretnine);
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