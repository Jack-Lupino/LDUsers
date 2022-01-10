﻿using System;
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
                    IPHostEntry host = Dns.GetHostEntry(inputName);
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
                    IPHostEntry host = Dns.GetHostEntry(inputName);

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
    }
}
