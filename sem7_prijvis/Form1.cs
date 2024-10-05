using System.Net;

namespace sem7_prijvis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string IPAddressToText(IPAddress ip, string name)
        {
            var binary = ip.GetAddressBytes().Select(i => Convert.ToString(i, 2).PadLeft(8, '0'));
            string[] elements = [string.Join('.', binary), ip.ToString(), name];
            return string.Join(" - ", elements);
        }

        private void Masked_IPAddress_Validated(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            bool parsed = IPAddress.TryParse(maskedTextBox.Text, out IPAddress? ip);
            if (!parsed || ip == null)
            {
                maskedTextBox.Text = "";
                Label_IPAddress.Text = "";
                return;
            }
            Label_IPAddress.Text = IPAddressToText(ip, "Adres IP");
        }

        private void Combo_SubnetMask_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string[] selected = comboBox.Text.Split('/');
            bool parsed = IPAddress.TryParse(selected[0], out IPAddress? mask);
            if (!parsed || mask == null)
            {
                comboBox.Text = "";
                Label_SubnetMask.Text = "";
                return;
            }
            Label_SubnetMask.Text = IPAddressToText(mask, "Maska");
        }
    }
}