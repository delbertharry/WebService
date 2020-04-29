using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WcfLibrary;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://kabrit.mwen.org/", Name = "Test Web Service")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(Description ="Première Web service", MessageName ="Hello")]
    public string HelloWorld()
    {
        TempService ts = new TempService();

        return ts.GetDelbertTest("Hello World");
    }

}
