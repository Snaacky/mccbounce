using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Process.NET;
using Process.NET.Memory;


namespace MCCBounce
{
    public partial class UIForm : Form
    {

        public UIForm()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            setTickrate(60);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setTickrate(30);
        }

        private static ProcessSharp getProcess()
        {
            var MCCProcess = System.Diagnostics.Process.GetProcessesByName("MCC-Win64-Shipping").FirstOrDefault();
            if (MCCProcess == null)
            {
                MessageBox.Show("Could not locate process. Is MCC running?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            var process = new ProcessSharp(MCCProcess, Process.NET.Memory.MemoryType.Remote);
            return process;
        }

        public void setTickrate(int desired)
        {
            var process = getProcess();
            process.Memory = new ExternalProcessMemory(process.Handle);

            var moduleBase = process["halo2.dll"].BaseAddress;
            int tickrateAddress = 0x015FE008;
            IntPtr tickrate = process.Memory.Read<IntPtr>(moduleBase + tickrateAddress);

            if (tickrate.ToInt64() == 0)
            {
                MessageBox.Show("Could not find tick rate in memory. Make sure you're in a game before running MCCBounce!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            
            if (desired == 30)
            {
                byte[] tickrate30 = StringToByteArray("1E008988083D");
                process.Memory.Write(tickrate + 2, tickrate30);
            } 
            
            if (desired == 60)
            {
                byte[] tickrate60 = StringToByteArray("3C008988883C");
                process.Memory.Write(tickrate + 2, tickrate60);
            }
        }

        // https://stackoverflow.com/a/311179/2274960
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        // https://stackoverflow.com/a/11660205/2274960
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void UIForm_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                MessageBox.Show("MCCBounce must be ran as administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
