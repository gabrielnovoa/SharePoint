using Microsoft.SharePoint.Client;
using System;
using System.Security;
using System.Windows.Forms;

namespace RetentionLabelRemover
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            SecureString password = GetPasswordOfYourSite(txtPassword.Text);
            string siteUrl = txtURL.Text;

            using (var clientContext = new ClientContext(siteUrl))
            {
                clientContext.Credentials = new SharePointOnlineCredentials(userName, password);

                Web web = clientContext.Web;
                clientContext.Load(web.Lists,
                                    lists => lists.Include(list => list.Title,
                                    list => list.Id));

                clientContext.ExecuteQuery();
                foreach (List list in web.Lists)
                {
                    cbbLists.Items.Add(list.Title);
                }

                cbbLists.SelectedIndex = 1;

                label5.Text = "Your lists were loaded. Please select one below to proceed";
                label5.Visible = true;
                pnlListData.Visible = true;
                pnlSPOData.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlListData.Enabled = false;            

            string userName = txtUsername.Text;
            SecureString password = GetPasswordOfYourSite(txtPassword.Text);
            string siteUrl = txtURL.Text;

            using (var clientContext = new ClientContext(siteUrl))
            {
                clientContext.Credentials = new SharePointOnlineCredentials(userName, password);

                Web web = clientContext.Web;
                List listToClear = web.Lists.GetByTitle(cbbLists.SelectedItem.ToString());
                clientContext.Load(listToClear);
                ListItemCollection listItems = listToClear.GetItems(new CamlQuery());
                clientContext.Load(listItems);
                clientContext.ExecuteQuery();                

                foreach (ListItem item in listItems)
                {
                    item.SetComplianceTag(string.Empty, false, false, false, false);
                    item.Update();
                    label5.Text = "Loading...";
                }
                clientContext.ExecuteQuery();
                pnlListData.Enabled = true;
                var result = MessageBox.Show(string.Format("Your Retention Labels were successfully cleaned on List {0}", listToClear.Title),
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Visible = false;
            }
        }

        private static SecureString GetPasswordOfYourSite(string password)
        {
            SecureString securePassword = new SecureString();

            foreach (char character in password)
            {
                securePassword.AppendChar(character);
            }
            return securePassword;
        }
    }
}