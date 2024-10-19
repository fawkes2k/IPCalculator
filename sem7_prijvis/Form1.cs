using System.Net;
using System.Text.RegularExpressions;

namespace sem7_prijvis
{
    public partial class Form1 : Form
    {
        public string IPString = "";
        public int Maska = 24;
        public uint uMaska = 0; //
        public uint uIP = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public string uint2ip(uint address)
        {
            return new IPAddress(BitConverter.GetBytes(address).Reverse().ToArray()).ToString();
        }

        public string ipString(uint address, string opis) { 
        
            string sip = uint2ip(address);
            var bc = BitConverter.GetBytes(address).Reverse().ToArray();
            string ip2 = "";
            foreach (byte b in bc) { 
                if(ip2!="") ip2 += ".";
                ip2 += Convert.ToString(b,2).PadLeft(8,'0');
            }
            
            return $"{ip2} {sip} - {opis}";

        }

        private void genMaki()
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("0.0.0.0 / 0");
            for (int i = 1; i <= 32; i++)
            {
                uint maska = uint.MaxValue << (32 - i);
                var maskaStr = uint2ip(maska) + " / " + i;
                comboBox1.Items.Add(maskaStr);
            }
            comboBox1.SelectedIndex = 24;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            genMaki();
            WalidacjaIP(textBox1, null);
        }

        private void WalidacjaIP(object sender, KeyEventArgs e)
        {
            if (sender is TextBox tb)
            {
                // 255.255.255.255
                string reg = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
                var test = new Regex(reg);
                
                if (test.IsMatch(tb.Text))
                {
                    IPString = tb.Text;
                    string reg1 = @"^(\d+)\.(\d+)\.(\d+)\.(\d+)$";
                    Match match = Regex.Match(IPString, reg1);
                    for (int i = 1; i < 5; i++)
                    {
                        uIP <<= 8;
                        uIP += uint.Parse(match.Groups[i].Value);
                    }



                    licz();
                }
                else IPString = "";

            }
        }
        public uint ileHostow()
        {
            return (uint)Math.Pow(2, 32-Maska)-2;
        }

        public string adresSieciLicz()
        {
            uint adresS = uIP & uMaska;
            return uint2ip(adresS);
        }

        public void licz()
        {
            if (IPString == "") return;

            /**
            0 - klasa A
            10 - Klasa B
            110 - klasaC
            1110 - klasa D
            11110 - klasa E
             
            */ 


            uint rozgAdres = (uIP & uMaska) + (uint.MaxValue & ~uMaska);
            uint siecadres = (uIP & uMaska);
            uint ip = uIP;
            if(ip==rozgAdres || ip ==siecadres) ip = siecadres+1;


            maska.Text = ipString(uMaska, "Maska");
            adresIP.Text = ipString(ip, "Adres IP");
            adresRozgloszeniowy.Text = ipString(rozgAdres, "Adres rozg³oszeniowy");
            adresSieci.Text = ipString(siecadres, "Adres sieci");
            liczbaHostow.Text = "Hostów w sieci: " + ileHostow();
            minimalnyHost.Text = ipString(siecadres + 1, "Adres minimalny hosta");
            maksymalnyHost.Text = ipString(rozgAdres-1, "Adres maksymalny hosta");
        }

        private void zmienMaske(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb) {
                Maska = cmb.SelectedIndex;
                uMaska = uint.MaxValue << (32 - Maska); // 255.255.255.0
                licz();
            }
        }
    }
}
