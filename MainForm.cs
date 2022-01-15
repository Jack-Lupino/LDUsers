using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LDUsers
{
    public partial class MainForm : Form
    {
        private PrincipalContext pc;
        private UserPrincipal user;
        private string machineName;
        private string ipAdress;
        private IPHostEntry host;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PCNameButton_Click(object sender, EventArgs e)
        {
            string inputName = PCNameTBox.Text;
            machineName = "-";
            ipAdress = "-";
            Match match = Regex.Match(inputName, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            if (match.Success)
            {
                try
                {
                    host = Dns.GetHostEntry(inputName);

                    machineName = host.HostName;
                    ipAdress = inputName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IP nerastas, klaida:\n" + ex.Message);
                }
                if (machineName.Contains("."))
                {
                    machineName = machineName.Split('.')[0].ToUpper();
                }
            }
            else
            {
                if (inputName.ToLower().StartsWith("m"))
                {
                    inputName = inputName.Replace("m", "llx");
                }
                else if (inputName.ToLower().StartsWith("k"))
                {
                    inputName = inputName.Replace("k", "glx") + "000";
                }
                try
                {
                    host = Dns.GetHostEntry(inputName);
                }
                catch(Exception ex)
                {
                    if (inputName.ToLower().StartsWith("llx"))
                    {
                        inputName = inputName.Replace("llx", "ldx");
                    }
                    else if (inputName.ToLower().StartsWith("ldx"))
                    {
                        inputName = inputName.Replace("ldx", "llx");
                    }
                    else if (inputName.ToLower().StartsWith("glx"))
                    {
                        inputName = inputName.Replace("glx", "gdx");
                    }
                    else if (inputName.ToLower().StartsWith("gdx"))
                    {
                        inputName = inputName.Replace("gdx", "glx");
                    }
                    
                }
                try
                {
                    //IPAddress[] ipAddresses = Dns.GetHostAddresses(inputName);
                    host = Dns.GetHostEntry(inputName);

                    string test = "";
                    foreach (IPAddress entry in host.AddressList)
                    {
                        match = Regex.Match(entry.ToString(), @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
                        if (match.Success)
                        {
                            test = entry.ToString();
                        }
                    }
                    
                    //IPAddress ip = ipAddresses[0];
                    machineName = inputName.ToUpper();
                    ipAdress = test;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kompiuteris nerastas, klaida:\n" + ex.Message);
                }
            }
            if (machineName != "-" && ipAdress != "-")
            {
                Ping ping = new Ping();
                try
                {
                    PingReply pingReply = ping.Send(ipAdress);
                    if (pingReply.Status != IPStatus.Success)
                    {
                        machineName = "Nepasiekiamas.";
                        ipAdress = "Nepasiekiamas.";
                    }
                }
                catch (PingException ex)
                {
                    MessageBox.Show("Klaida: " + ex.InnerException.Message);
                }
            }
            PCNameL.Text = "PC: " + machineName;
            PCipL.Text = "IP: " + ipAdress;
            PCNameTBox.Text = "";
        }

        private void PCNameTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PCNameButton_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void ADNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ADNameButton_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ADNameButton_Click(object sender, EventArgs e)
        {
            pc = new PrincipalContext(ContextType.Domain, "panbaltic.int");
            user = UserPrincipal.FindByIdentity(pc, ADNameTBox.Text);
            DirectoryEntry entry = (DirectoryEntry)user.GetUnderlyingObject();
            //ActiveDs.IADsUser native = (IADsUser)entry.NativeObject;
            var maxPasswordAge = (int) entry.Properties.Cast<PropertyValueCollection>().First(p => p.PropertyName == "MaxPasswordAge").Value;
            var passwordAge = (int) entry.Properties.Cast<PropertyValueCollection>().First(p => p.PropertyName == "PasswordAge").Value;
            TimeSpan exp = TimeSpan.FromSeconds(maxPasswordAge) - TimeSpan.FromSeconds(passwordAge);
            //user.UserPrincipalName = PCNameTBox.Text;
            //MessageBox.Show(user.UserPrincipalName);

            //PrincipalSearcher searcher = new PrincipalSearcher(user);
            //PrincipalSearchResult<Principal> results = searcher.FindAll();

            ADNameL.Text = "AD: " + user.SamAccountName;
            ADfnL.Text = "Vardas: " + user.DisplayName;
            //string expiration = "Never expires";
            //if (user.AccountExpirationDate.HasValue)
            //{
            //    expiration = user.AccountExpirationDate.Value.ToLocalTime().ToString();
            //}
            ADInfoTBox.Text =
                "Enabled: " + user.Enabled + "\n" +
                "Locked: " + user.IsAccountLockedOut() + "\n" +
                "Pass Expiration: " + exp + "\n" +
                "Last pass set: " + user.LastPasswordSet + "\n" +
                "Last logon: " + user.LastLogon + "\n" +
                "Permitted WSs: " + user.PermittedWorkstations + "\n";
            /*
             *  "Paštas: " + user.EmailAddress + "\n" +
                "Telefonas: " + user.VoiceTelephoneNumber + "\n\n" +
            string str = string.Empty;
            foreach (var result in searcher.FindAll())
            {
                DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                str += "First Name: " + de.Properties["givenName"].Value +
                "\nLast Name : " + de.Properties["sn"].Value +
                "\nSAM account name   : " + de.Properties["samAccountName"].Value +
                "\nUser principal name: " + de.Properties["userPrincipalName"].Value;
            }
            MessageBox.Show(str);*/
        }

        private void FNameButton_Click(object sender, EventArgs e)
        {

        }

        private void ADUnlockButton_Click(object sender, EventArgs e)
        {
            user.UnlockAccount();
            user.Save();
            ADNameButton_Click(sender, e);
        }

        private void ADpassButton_Click(object sender, EventArgs e)
        {
            user.SetPassword("Naujas456");
            user.Save();
        }

        private void ADEnableButton_Click(object sender, EventArgs e)
        {
            user.Enabled = true;
        }

        private void AutoPButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process useprocess;
                useprocess = new System.Diagnostics.Process();
                useprocess.StartInfo.FileName = "C:\\Users\\zygzal\\AutoPagalba.cmd";
                useprocess.Start();
                useprocess.WaitForExit();
                MessageBox.Show("Bat file executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                throw;
            }
        }

        private void BOButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process useprocess;
                useprocess = new System.Diagnostics.Process();
                useprocess.StartInfo.FileName = "Z:\\TELIA\\PKINST\\BDC\\BackOffice_LD.cmd";
                useprocess.Start();
                useprocess.WaitForExit();
                MessageBox.Show("Bat file executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                throw;
            }
        }
    }
}
