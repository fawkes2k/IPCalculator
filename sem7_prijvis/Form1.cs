using System.Net;

namespace sem7_prijvis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Masked_IPAddress_FocusLeave(Masked_IPAddress, EventArgs.Empty);

            Combo_SubnetMask.Text = "255.255.255.0/24";
            Combo_SubnetMask_SelectionChangeCommitted(Combo_SubnetMask, EventArgs.Empty);
        }

        private static string IPAddressToText(IPAddress ip, string name)
        {
            var binary = ip.GetAddressBytes().Select(i => Convert.ToString(i, 2).PadLeft(8, '0'));
            string[] elements = [string.Join('.', binary), ip.ToString(), name];
            return string.Join(" - ", elements);
        }

        private void Masked_IPAddress_FocusLeave(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox maskedTextBox)
            {
                bool parsed = IPAddress.TryParse(maskedTextBox.Text, out IPAddress? ip);
                if (!parsed || ip == null)
                {
                    Label_IPAddress.Text = "";
                    return;
                }
                Label_IPAddress.Text = IPAddressToText(ip, "Adres IP");
            }
        }

        private void Combo_SubnetMask_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string[] selected = comboBox.Text.Split('/');
                bool parsed = IPAddress.TryParse(selected[0], out IPAddress? mask);
                if (!parsed || mask == null)
                {
                    Label_SubnetMask.Text = "";
                    return;
                }
                Label_SubnetMask.Text = IPAddressToText(mask, "Maska");

                parsed = byte.TryParse(selected[1], out byte int_mask);
                if (parsed)
                {
                    ulong hosts = (ulong)Math.Pow(2, 32 - int_mask);
                    Label_HostsInSubnet.Text = $"Hostów w sieci: {hosts}";
                }
            }
        }
    }
}