using System.Net;

namespace sem7_prijvis
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
            Label_IPAddress.Text = string.Empty;
            Label_SubnetMask.Text = string.Empty;
            Label_SubnetAddress.Text = string.Empty;
            Label_BroadcastAddress.Text = string.Empty;
            Label_MinimumHost.Text = string.Empty;
            Label_MaximumHost.Text = string.Empty;
            Label_HostsInSubnet.Text = string.Empty;
        }

        private void IPAddressToText(IPAddress ip, Control target)
        {
            var binary = ip.GetAddressBytes().Select(i => Convert.ToString(i, 2).PadLeft(8, '0'));
            string? value_name = rm.GetString(target.Name);
            string?[] elements = [string.Join('.', binary), ip.ToString(), value_name];
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

            IPAddressToText(ip_address, Label_IPAddress);
            IPAddressToText(mask_address, Label_SubnetMask);

            IPAddressToText(IPAddress.Broadcast, Label_SubnetAddress);
            IPAddressToText(IPAddress.Broadcast, Label_BroadcastAddress);
            IPAddressToText(IPAddress.Broadcast, Label_MinimumHost);
            IPAddressToText(IPAddress.Broadcast, Label_MaximumHost);

            uint hosts = (uint)Math.Max(0, Math.Pow(2, 32 - int_mask) - 2);
            Label_HostsInSubnet.Text = $"{rm.GetString(Label_HostsInSubnet.Name)}: {hosts:N0}";
        }
    }
}