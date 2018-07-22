using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Query {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            txtResults.Text = string.Empty;

            string logid = txtLogID.Text.Trim();
            if (String.IsNullOrWhiteSpace(logid)) {
                txtResults.Text = "Please enter logon id.";
                return;
            }
            try { 

            //perform a search
            string ldapBindingStr = @"LDAP://helloworld.com/DC=hellods,DC=world,DC=com"; 
            DirectoryEntry ldapConnection = new DirectoryEntry(ldapBindingStr);
            DirectorySearcher search = new DirectorySearcher(ldapConnection);
            search.ReferralChasing = ReferralChasingOption.All;

            search.Filter = "(samaccountName=" + logid + ")"; // user's logon id  gzhou
            // search.Filter = "(cn=" + username + ")";  // this is full name, zhou, gary

            SearchResult result = search.FindOne();

            if (result != null) {             
                ResultPropertyCollection fields = result.Properties;

                foreach (String ldapField in fields.PropertyNames) {
                        //*************** output all properties  *********************************************************************
                        // cycle through objects in each field e.g. group membership  
                        // (for many fields there will only be one object such as name)
                        foreach (Object myCollection in fields[ldapField]) {
                            if (ldapField.Equals("accountexpires")) {
                                if ("9223372036854775807" == fields["accountexpires"][0].ToString()) // this is magic default value
                                    txtResults.Text = txtResults.Text + (String.Format(OutputFormatStr, ldapField, "never expire.")) + Environment.NewLine;
                                else                                    
                                    txtResults.Text = txtResults.Text + (String.Format(OutputFormatStr, ldapField, DateTime.FromFileTime(long.Parse(fields["accountexpires"][0].ToString())))) + Environment.NewLine;
                            }
                            else if (ldapField.Equals("pwdlastset"))
                                txtResults.Text = txtResults.Text + (String.Format(OutputFormatStr, ldapField, DateTime.FromFileTime(long.Parse(fields["pwdlastset"][0].ToString()))))  + Environment.NewLine;
                            else if (ldapField.Equals("objectguid"))
                                txtResults.Text = txtResults.Text + (String.Format(OutputFormatStr, ldapField, new Guid((byte[])myCollection))) + Environment.NewLine;
                            else
                                txtResults.Text = txtResults.Text + (String.Format(OutputFormatStr, ldapField, myCollection.ToString())) + Environment.NewLine;
                        }
                }
            }
            else {
                // user does not exist  
                txtResults.Text = "User not found!";
            }
            }
            catch (Exception ex){
                txtResults.Text = ex.Message;
            }
        }

        private string OutputFormatStr {
            get { return "{0,-20} : {1}"; }
        }
    }
}
