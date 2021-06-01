using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace kalkulator_ip
{
    public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^|\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
            
        }
     

        private void CalculateIP(object sender, EventArgs e) {

            String ipString = IpTextBox.Text;
            ipString = rgx.Replace(ipString, ".");
            
            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPAddress maskAddress = IPAddress.Parse(MaskTextBox.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            byte[] reversedMask = maskAddress.GetAddressBytes();
            byte[] network = new byte[4];
            byte[] broadcast = new byte[4];
            for (int i = 0; i < 4; i++) {
                network[i] = (byte)(ip[i] & mask[i]);
                reversedMask[i] = (byte)~mask[i];
                broadcast[i] = (byte)(network[i] | reversedMask[i]);
            }
            Array.Copy(network, broadcast, 4);
            //TODO: wypelnij adres rozgloszeniowy jedynkami od prawej
            string networAddressString = "";
            string broadcastAddressString = "";
            for (int i = 0; i < 4; i++)  {
                //network
               
                String ipFragment = network[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                networAddressString += ipFragment;
                //broadcast
                ipFragment = broadcast[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                broadcastAddressString += ipFragment;
            }

            networkAddressTextBox.Text = networAddressString;
            BroadcastTextBox.Text = broadcastAddressString;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] ipAddress = new byte[4];
            ipAddress[0] = (byte)ipOctet1.Value;
            ipAddress[1] = (byte)ipOctet2.Value;
            ipAddress[2] = (byte)ipOctet3.Value;
            ipAddress[3] = (byte)ipOctet4.Value;
            IPAddress ip = new IPAddress(ipAddress);
            IPNetwork network = IPNetwork.Parse(ip.ToString(), (byte)cidrText.Value);
            IpTextBox.Text = network.Value;
            MaskTextBox.Text = network.Netmask.ToString();
            networkAddressTextBox.Text = network.Network.ToString();
            BroadcastTextBox.Text = network.Broadcast.ToString();
            PierwszyUzytecznyText.Text = network.FirstUsable.ToString();
            OstatniUzytecznyText.Text = network.LastUsable.ToString();


        }
    }
}
