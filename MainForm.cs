using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LDUsers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PCNameButton_Click(object sender, EventArgs e)
        {
            string inputName = PCNameTBox.Text;
            string machineName = "-";
            string ipAdress = "-";
            Match match = Regex.Match(inputName, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            if (match.Success)
            {
                try
                {
                    IPHostEntry hostEntry = Dns.GetHostEntry(inputName);

                    machineName = hostEntry.HostName;
                    ipAdress = inputName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IP nerastas, klaida:\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    //IPAddress[] ipAddresses = Dns.GetHostAddresses(inputName);
                    IPHostEntry host = Dns.GetHostEntry(inputName);

                    string test = "";
                    foreach (IPAddress entry in host.AddressList)
                    {
                        test += entry.ToString() + "\n";
                    }
                    MessageBox.Show(test);
                    //IPAddress ip = ipAddresses[0];
                    machineName = inputName;
                    //ipAdress = ip.ToString();
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
    }
}
