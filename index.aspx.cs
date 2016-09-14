using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetContent
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sample1
            Context.Response.Charset = Encoding.UTF8.WebName;
            WebClient clientzonh = new WebClient();

            string strclientzonh = clientzonh.DownloadString("http://www.zone-h.org/archive/special=1");
            framein.InnerHtml = strclientzonh;





            //sample2
            WebRequest request3 = WebRequest.Create("http://iranfile.ir/search/showdetails.aspx?id=8009407");
            WebResponse response3 = request3.GetResponse();
            Stream data3 = response3.GetResponseStream();
            string html3 = String.Empty;
            using (StreamReader sr = new StreamReader(data3, Encoding.UTF8, true))
            {
                html3 = sr.ReadToEnd();
            }

            Div1.InnerHtml = html3;
        }
    }
}