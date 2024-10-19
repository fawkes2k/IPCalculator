using System.Net;
using System.Text.RegularExpressions;

namespace IPCalculator
{
    public partial class IPCalculator : Form
    {
        public IPCalculator()
        {
            InitializeComponent();
            Updated(this, EventArgs.Empty);
        }

        private void CleanAllLabels()
        {
            Label_IPAddress.Text = Label_SubnetMask.Text = Label_NetworkAddress.Text = Label_BroadcastAddress.Text = Label_MinimumHost.Text = Label_MaximumHost.Text = Label_HostsInSubnet.Text = string.Empty;
        }

        private void IPAddressToText(IPAddress ip, Control target)
        {
            IEnumerable<string> binary = ip.GetAddressBytes().Select(i => Convert.ToString(i, 2).PadLeft(8, '0'));
            string?[] elements = [string.Join('.', binary), ip.ToString(), rm.GetString(target.Name)];
            target.Text = string.Join(" - ", elements);
        }

        private void Updated(object sender, EventArgs e)
        {
            bool parsed = IPAddress.TryParse(Masked_IPAddress.Text, out IPAddress? ip_address);
            if (!parsed || ip_address == null) { CleanAllLabels(); return; }
            
            string[] selected = Combo_SubnetMask.Text.Split('/');
            parsed = IPAddress.TryParse(selected[0], out IPAddress? mask_address);
            if (!parsed || mask_address == null) { CleanAllLabels(); return; }

            parsed = byte.TryParse(selected[1], out byte int_mask);
            if (!parsed || int_mask > 32) { CleanAllLabels(); return; }

            byte[] ip_address_bytes = ip_address.GetAddressBytes(), mask_address_bytes = mask_address.GetAddressBytes();
            IPAddressToText(ip_address, Label_IPAddress);
            IPAddressToText(mask_address, Label_SubnetMask);
            
            byte[] network_address = ip_address_bytes.AsParallel().Select((x, i) => (byte)(x & mask_address_bytes[i])).ToArray();
            IPAddressToText(new IPAddress(network_address), Label_NetworkAddress);
            network_address[3] += 1;
            IPAddressToText(new IPAddress(network_address), Label_MinimumHost);

            byte[] broadcast_address = ip_address_bytes.AsParallel().Select((x, i) => (byte)(x | (mask_address_bytes[i] ^ 0xFF))).ToArray();
            IPAddressToText(new IPAddress(broadcast_address), Label_BroadcastAddress);
            broadcast_address[3] -= 1;
            IPAddressToText(new IPAddress(broadcast_address), Label_MaximumHost);

            uint hosts = (uint)Math.Max(0, Math.Pow(2, 32 - int_mask) - 2);
            Label_HostsInSubnet.Text = $"{rm.GetString(Label_HostsInSubnet.Name)}: {hosts:N0}";

            string first_byte_bin = Convert.ToString(ip_address_bytes[0] >> 3, 2).PadLeft(5, '0');
            char IP_class = (char)(65 + Regex.Match(first_byte_bin, @"^(1+)(.+)").Groups[1].Length);
            Label_IPClass.Text = $"{rm.GetString(Label_IPClass.Name)}: {IP_class}";
        }
    }
}