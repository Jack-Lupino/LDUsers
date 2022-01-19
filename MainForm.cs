using Microsoft.Win32;
using System;
using System.Collections;
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
            PCNameL.Text = machineName;
            PCipL.Text = ipAdress;
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
            //var maxPasswordAge = (int) entry.Properties.Cast<PropertyValueCollection>().First(p => p.PropertyName == "MaxPasswordAge").Value;
            //var passwordAge = (int) entry.Properties.Cast<PropertyValueCollection>().First(p => p.PropertyName == "PasswordAge").Value;
            //TimeSpan exp = TimeSpan.FromSeconds(maxPasswordAge) - TimeSpan.FromSeconds(passwordAge);
            //user.UserPrincipalName = PCNameTBox.Text;
            //MessageBox.Show(user.UserPrincipalName);

            //PrincipalSearcher searcher = new PrincipalSearcher(user);
            //PrincipalSearchResult<Principal> results = searcher.FindAll();

            ADNameL.Text = user.SamAccountName;
            ADfnL.Text = user.DisplayName;
            //string expiration = "Never expires";
            //if (user.AccountExpirationDate.HasValue)
            //{
            //    expiration = user.AccountExpirationDate.Value.ToLocalTime().ToString();
            //}
            DateTime passExpiry = (DateTime) entry.InvokeGet("PasswordExpirationDate");
            ADInfoTBox.Text =
                "Galioja: " + user.Enabled + "\r\n" +
                "Užrakinta: " + user.IsAccountLockedOut() + "\r\n" +
                "Pasibaigęs slaptažodis: " + (DateTime.Now >= passExpiry) + "\r\n\r\n" +
                "Slaptažodis pasibaigs:\r\n" + passExpiry + "\r\n" +
                "Slaptažodis keistas:\r\n" + user.LastPasswordSet + "\r\n" +
                "Paskutinį kartą jungtąsi:\r\n" + user.LastLogon + "\r\n";
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
            ADNameButton_Click(sender, e);
        }

        private void ADEnableButton_Click(object sender, EventArgs e)
        {
            user.Enabled = true;
            user.Save();
            ADNameButton_Click(sender, e);
        }

        private void AutoPButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "C:\\Users\\zygzal\\AutoPagalba.cmd";
                proc.StartInfo.Arguments = $"{machineName} {user.SamAccountName}";
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void BOButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "Z:\\TELIA\\PKINST\\BDC\\BackOffice_LD.cmd";
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "C:\\Tools\\PsTools\\PsExec.exe";
                proc.StartInfo.Arguments = $"\\\\{machineName} -s cmd";
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void PshellButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "C:\\Tools\\PsTools\\PsExec.exe";
                proc.StartInfo.Arguments = $"\\\\{machineName} -s Powershell";
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void DWButton_Click(object sender, EventArgs e)
        {
            string flag;
            if (DWipChBox.Checked)
            {
                flag = $"-c: -h: -m:{ipAdress} -a:1";
            }
            else
            {
                flag = $"-c: -h: -m:{machineName} -a:1";
            }
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "C:\\Program Files\\SolarWinds\\DameWare Mini Remote Control x64\\DWRCC.exe";
                proc.StartInfo.Arguments = flag;
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void PCtoADButton_Click(object sender, EventArgs e)
        {
            if (machineName != "-")
            {
                string location = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI";
                var registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (var hive = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName, registryView))
                {
                    using (var key = hive.OpenSubKey(location))
                    {
                        var item = key.GetValue("LastLoggedOnUser");
                        string itemValue = item == null ? "No Logon Found" : item.ToString();
                        ADNameTBox.Text = itemValue.Split('\\')[1];
                        ADNameButton_Click(sender, e);
                    }
                }
                /*
                try
                {
                    System.Diagnostics.Process proc;
                    proc = new System.Diagnostics.Process();
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.Arguments = $"/C WMIC /NODE:\"{machineName}\" COMPUTERSYSTEM GET USERNAME";
                    proc.Start();
                    string adName = proc.StandardOutput.ReadToEnd().Trim();
                    proc.WaitForExit();
                    ArrayList str = new ArrayList();
                    foreach (var item in adName.Split('\\'))
                    {
                        str.Add(item);
                    }
                    string yet = str[str.Count - 1].ToString();
                    ADNameTBox.Text = yet.Substring(0, yet.Length);
                    ADNameButton_Click(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message);
                }
                */
            }
        }

        private void ADtoPCButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = "powershell.exe";
                proc.StartInfo.Arguments = $"C:\\Users\\Downloads\\test.ps1 {machineName}";
                proc.Start();
                string pcName = proc.StandardOutput.ReadToEnd().Trim();
                proc.WaitForExit();
                PCNameTBox.Text = pcName;
                PCNameButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void TiaButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc;
                proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "C:\\Users\\zygzal\\Downloads\\frmservlet.jnlp";
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void TopCBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }
    }
}
