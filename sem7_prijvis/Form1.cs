using System.Net;
using System.Text.RegularExpressions;

namespace sem7_prijvis
{
    public partial class Form1 : Form
    {
        public string IPString = "";
        public int Maska = 24;

        public Form1()
        {
            InitializeComponent();
        }

        public string uint2ip(uint address)
        {
            return new IPAddress(BitConverter.GetBytes(address).Reverse().ToArray()).ToString();
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
                    licz();
                }
                else IPString = "";

            }
        }
        public uint ileHostow()
        {
            return (uint)Math.Pow(2, 32-Maska)-2;
        }

        public void licz()
        {
            if (IPString == "") return;

            liczbaHostow.Text = "Hostów w sieci: " + ileHostow();
        }

        private void zmienMaske(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb) {
                Maska = cmb.SelectedIndex;
                licz();
            }
        }
    }
}
