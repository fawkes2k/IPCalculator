﻿using System.Resources;

namespace IPCalculator
{
    partial class IPCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ResourceManager rm = new ResourceManager(typeof(IPCalculator));

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Group_IPAddress = new GroupBox();
            Masked_IPAddress = new MaskedTextBox();
            Group_SubnetMask = new GroupBox();
            Combo_SubnetMask = new ComboBox();
            Group_Result = new GroupBox();
            Label_HostsInSubnet = new Label();
            Label_MaximumHost = new Label();
            Label_MinimumHost = new Label();
            Label_BroadcastAddress = new Label();
            Label_NetworkAddress = new Label();
            Label_SubnetMask = new Label();
            Label_IPAddress = new Label();
            Label_IPClass = new Label();
            Group_IPAddress.SuspendLayout();
            Group_SubnetMask.SuspendLayout();
            Group_Result.SuspendLayout();
            SuspendLayout();
            // 
            // Group_IPAddress
            // 
            Group_IPAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Group_IPAddress.Controls.Add(Masked_IPAddress);
            Group_IPAddress.Location = new Point(12, 18);
            Group_IPAddress.Name = "Group_IPAddress";
            Group_IPAddress.Size = new Size(451, 67);
            Group_IPAddress.TabIndex = 0;
            Group_IPAddress.TabStop = false;
            Group_IPAddress.Text = rm.GetString(Group_IPAddress.Name);
            // 
            // Masked_IPAddress
            // 
            Masked_IPAddress.AsciiOnly = true;
            Masked_IPAddress.BeepOnError = true;
            Masked_IPAddress.Culture = new System.Globalization.CultureInfo("en-US");
            Masked_IPAddress.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Masked_IPAddress.Location = new Point(6, 22);
            Masked_IPAddress.Name = "Masked_IPAddress";
            Masked_IPAddress.RejectInputOnFirstFailure = true;
            Masked_IPAddress.Size = new Size(438, 23);
            Masked_IPAddress.TabIndex = 0;
            Masked_IPAddress.Text = "192.168.1.1";
            Masked_IPAddress.TextChanged += Updated;
            // 
            // Group_SubnetMask
            // 
            Group_SubnetMask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Group_SubnetMask.Controls.Add(Combo_SubnetMask);
            Group_SubnetMask.Location = new Point(12, 91);
            Group_SubnetMask.Name = "Group_SubnetMask";
            Group_SubnetMask.Size = new Size(451, 67);
            Group_SubnetMask.TabIndex = 1;
            Group_SubnetMask.TabStop = false;
            Group_SubnetMask.Text = rm.GetString(Group_SubnetMask.Name);
            // 
            // Combo_SubnetMask
            // 
            Combo_SubnetMask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Combo_SubnetMask.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo_SubnetMask.FormattingEnabled = true;
            Combo_SubnetMask.Items.AddRange(new object[] { "255.255.255.255/32", "255.255.255.254/31", "255.255.255.252/30", "255.255.255.248/29", "255.255.255.240/28", "255.255.255.224/27", "255.255.255.192/26", "255.255.255.128/25", "255.255.255.0/24", "255.255.254.0/23", "255.255.252.0/22", "255.255.248.0/21", "255.255.240.0/20", "255.255.224.0/19", "255.255.192.0/18", "255.255.128.0/17", "255.255.0.0/16", "255.254.0.0/15", "255.252.0.0/14", "255.248.0.0/13", "255.240.0.0/12", "255.224.0.0/11", "255.192.0.0/10", "255.128.0.0/9", "255.0.0.0/8", "254.0.0.0/7", "252.0.0.0/6", "248.0.0.0/5", "240.0.0.0/4", "224.0.0.0/3", "192.0.0.0/2", "128.0.0.0/1", "0.0.0.0/0" });
            Combo_SubnetMask.Location = new Point(6, 22);
            Combo_SubnetMask.Name = "Combo_SubnetMask";
            Combo_SubnetMask.Size = new Size(435, 23);
            Combo_SubnetMask.TabIndex = 0;
            Combo_SubnetMask.Text = "255.255.255.0/24";
            Combo_SubnetMask.SelectionChangeCommitted += Updated;
            // 
            // Group_Result
            // 
            Group_Result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Group_Result.Controls.Add(Label_IPClass);
            Group_Result.Controls.Add(Label_HostsInSubnet);
            Group_Result.Controls.Add(Label_MaximumHost);
            Group_Result.Controls.Add(Label_MinimumHost);
            Group_Result.Controls.Add(Label_BroadcastAddress);
            Group_Result.Controls.Add(Label_NetworkAddress);
            Group_Result.Controls.Add(Label_SubnetMask);
            Group_Result.Controls.Add(Label_IPAddress);
            Group_Result.Location = new Point(12, 164);
            Group_Result.Name = "Group_Result";
            Group_Result.Size = new Size(451, 193);
            Group_Result.TabIndex = 1;
            Group_Result.TabStop = false;
            Group_Result.Text = rm.GetString(Group_Result.Name);
            // 
            // Label_HostsInSubnet
            // 
            Label_HostsInSubnet.AutoSize = true;
            Label_HostsInSubnet.Location = new Point(6, 175);
            Label_HostsInSubnet.Name = "Label_HostsInSubnet";
            Label_HostsInSubnet.Size = new Size(0, 15);
            Label_HostsInSubnet.TabIndex = 6;
            // 
            // Label_MaximumHost
            // 
            Label_MaximumHost.AutoSize = true;
            Label_MaximumHost.Location = new Point(6, 149);
            Label_MaximumHost.Name = "Label_MaximumHost";
            Label_MaximumHost.Size = new Size(0, 15);
            Label_MaximumHost.TabIndex = 5;
            // 
            // Label_MinimumHost
            // 
            Label_MinimumHost.AutoSize = true;
            Label_MinimumHost.Location = new Point(6, 122);
            Label_MinimumHost.Name = "Label_MinimumHost";
            Label_MinimumHost.Size = new Size(0, 15);
            Label_MinimumHost.TabIndex = 4;
            // 
            // Label_BroadcastAddress
            // 
            Label_BroadcastAddress.AutoSize = true;
            Label_BroadcastAddress.Location = new Point(6, 96);
            Label_BroadcastAddress.Name = "Label_BroadcastAddress";
            Label_BroadcastAddress.Size = new Size(0, 15);
            Label_BroadcastAddress.TabIndex = 3;
            // 
            // Label_NetworkAddress
            // 
            Label_NetworkAddress.AutoSize = true;
            Label_NetworkAddress.Location = new Point(6, 70);
            Label_NetworkAddress.Name = "Label_NetworkAddress";
            Label_NetworkAddress.Size = new Size(0, 15);
            Label_NetworkAddress.TabIndex = 2;
            // 
            // Label_SubnetMask
            // 
            Label_SubnetMask.AutoSize = true;
            Label_SubnetMask.Location = new Point(6, 44);
            Label_SubnetMask.Name = "Label_SubnetMask";
            Label_SubnetMask.Size = new Size(0, 15);
            Label_SubnetMask.TabIndex = 1;
            // 
            // Label_IPAddress
            // 
            Label_IPAddress.AutoSize = true;
            Label_IPAddress.Location = new Point(6, 19);
            Label_IPAddress.Name = "Label_IPAddress";
            Label_IPAddress.Size = new Size(0, 15);
            Label_IPAddress.TabIndex = 0;
            // 
            // Label_IPClass
            // 
            Label_IPClass.AutoSize = true;
            Label_IPClass.Location = new Point(222, 175);
            Label_IPClass.Name = "Label_IPClass";
            Label_IPClass.Size = new Size(0, 15);
            Label_IPClass.TabIndex = 7;
            // 
            // IPCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 377);
            Controls.Add(Group_Result);
            Controls.Add(Group_SubnetMask);
            Controls.Add(Group_IPAddress);
            Name = "IPCalculator";
            Text = rm.GetString("Window_Name");
            Group_IPAddress.ResumeLayout(false);
            Group_IPAddress.PerformLayout();
            Group_SubnetMask.ResumeLayout(false);
            Group_Result.ResumeLayout(false);
            Group_Result.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Group_IPAddress;
        private GroupBox Group_SubnetMask;
        private ComboBox Combo_SubnetMask;
        private GroupBox Group_Result;
        private Label Label_BroadcastAddress;
        private Label Label_NetworkAddress;
        private Label Label_SubnetMask;
        private Label Label_IPAddress;
        private Label Label_HostsInSubnet;
        private Label Label_MaximumHost;
        private Label Label_MinimumHost;
        private MaskedTextBox Masked_IPAddress;
        private Label Label_IPClass;
    }
}
