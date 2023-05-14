using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using bruteBro.Class.Network;

namespace bruteBro
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(ipTBOX.Text))
            {
                IPAddress ipAddr = null;
                if (IPAddress.TryParse(ipTBOX.Text, out ipAddr))
                {
                    //ObjectManager.BruteForce();
                }
            }


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LogText("Starting Program....");
            LogText("Init NICs....");
            LogText("Load avaible Protocols....");
            LoadNicCbox();
            LoadAvaibleProtocols();
        }

        private void LogText(string msg)
        {
            msg = "["+DateTime.Now.ToString("yyyy-MM-dd")+"] [" + DateTime.Now.ToString("HH:mm:ss") + "]:" + msg + Environment.NewLine;
            logTBOX.Text += msg;
        }

        private void LoadAvaibleProtocols()
        {
            if (portCBOX.Items.Count != 0)
                portCBOX.Items.Clear();

            portCBOX.Items.Add("23 - Telnet");
        }

        private void LoadNicCbox()
        {
            if (nicCBOX.Items.Count != 0)
                nicCBOX.Items.Clear();

            ObjectManager.NetworkAdapter = NetworkObjectManager.GetNetworkIntegratedCards();
            for (int i = 0; i < ObjectManager.NetworkAdapter.Count; i++)
            {
                string ipStr = null;
                List<IPAddress> ips = NetworkObjectManager.GetNICAddresses(ObjectManager.NetworkAdapter[i], AddressFamily.InterNetwork);
                for (int n = 0; n < ips.Count; n++)
                {
                    ipStr += " " + ips[n].ToString() + "";
                }
                string fullStr = ""+ ObjectManager.NetworkAdapter[i].Name+": "+ipStr+""; 
                nicCBOX.Items.Add(fullStr);
            }
        }

        private void LogonTryCHBOX_CheckedChanged(object sender, EventArgs e)
        {
            if(logonTryCHBOX.Checked == true)
            {
                LogText("Testing logon trys before bruteforce");
            }
            else
            {
                LogText("Not testing logon trys before bruteforce");
            }
        }

        private void PasswordLenghtTBAR_Scroll(object sender, EventArgs e)
        {
            pwlengthTBARLAB.Text = "PasswordLength - " + passwordLenghtTBAR.Value;
        }

        private void PasswordLenghtTBAR_MouseUp(object sender, MouseEventArgs e)
        {

            LogText("Passwordlenght updated to a lenght of " + passwordLenghtTBAR.Value + "");
        }

        private void NicCBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

            LogText("Selected working nic changed to: "+nicCBOX.SelectedItem.ToString()+"");
        }

        private void PortCBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

            LogText("Selected working nic changed to: " + portCBOX.SelectedItem.ToString() + "");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = ObjectManager.GetMaximumLogonTryCount("192.168.2.19", 23);
            MessageBox.Show(x.ToString());
        }
    }
}
