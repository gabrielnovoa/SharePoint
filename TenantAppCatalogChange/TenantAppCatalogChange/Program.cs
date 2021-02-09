using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace TenantAppCatalogChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your SharePoint Online Admin Center URL");
            string adminCenterUrl = Console.ReadLine();

            var authManager = new OfficeDevPnP.Core.AuthenticationManager();
            ClientContext ctx = authManager.GetWebLoginClientContext(adminCenterUrl);

            Console.WriteLine("\nYou are connected to " + adminCenterUrl + "\n");

            Console.WriteLine("\nEnter your SharePoint App Catalog URL");
            string appCatalogUrl = Console.ReadLine();

            var settings = TenantSettings.GetCurrent(ctx);
            settings.SetCorporateCatalog(appCatalogUrl);
            ctx.ExecuteQuery();

            Console.WriteLine("\nYou changed your App Catalog to " + appCatalogUrl);
        }
    }
}
