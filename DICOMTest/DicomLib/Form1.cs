using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace exp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///<summary>Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>  
        ///<param name="s">The string containing the hex digits (with or without spaces).</param>  
        ///<returns>Returns an array of bytes.</returns>  
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");  
        
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            byte[] data = HexStringToByteArray(txtInput.Text);
            MemoryStream ms = new MemoryStream();
            ms.Write(data, 0, data.Length);
            ms.Position = 0;
            BinaryReader sr = new BinaryReader(ms);

            ushort gid = sr.ReadUInt16();
            ushort eid = sr.ReadUInt16();
            int len = sr.ReadInt32();

            string val = Encoding.UTF8.GetString(sr.ReadBytes(len));

            txtOutput.Text += "组号：" + gid.ToString("X4")+ "\n";
            txtOutput.Text += "元素号：" + eid.ToString("X4") +"\n";
            txtOutput.Text += "值长度：" + len.ToString() + "\n";
            txtOutput.Text += "值：" + val + "\n";
        }
    }
}
