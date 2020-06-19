using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace AddFieldToList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your SharePoint Online Site URL");
            string siteURL = Console.ReadLine();

            var authManager = new OfficeDevPnP.Core.AuthenticationManager();
            ClientContext ctx = authManager.GetWebLoginClientContext(siteURL);

            Console.WriteLine("\nYou are connected to " + siteURL + "\n");

            Console.WriteLine("\nEnter your List Name");
            string listName = Console.ReadLine();

            Console.WriteLine("\nEnter your Field Internal Name");
            string fieldInternalName = Console.ReadLine();

            Console.WriteLine("\nEnter your Field Display Name");
            string fieldDisplayName = Console.ReadLine();

            Web web = ctx.Web;
            ctx.Load(web);

            List list = web.Lists.GetByTitle(listName);
            ctx.Load(list); 

            ctx.ExecuteQuery();

            string schemaTextField = string.Format("<Field Type='Text' Name='{0}' StaticName='{0}' DisplayName='{1}' />",fieldInternalName,fieldDisplayName);
            Field simpleTextField = list.Fields.AddFieldAsXml(schemaTextField, true, AddFieldOptions.AddFieldInternalNameHint);
            ctx.ExecuteQuery();

            Console.WriteLine("\nField '" + fieldDisplayName + "' was added successfully");
            Console.ReadKey();
        }
    }
}
