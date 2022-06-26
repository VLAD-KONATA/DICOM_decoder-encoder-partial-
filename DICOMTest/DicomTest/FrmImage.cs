using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DICOMLib;

namespace DicomTest
{
    public partial class FrmImage : Form
    {
        short[] sspixels;    //OW像素缓冲区,ss
        ushort[] uspixels;    //OW像素缓冲区,us          
        byte[] obpixels;    //OB像素缓冲区,ob
        DCMDataSet items;
        double level;          //窗位
        double window;          //窗宽
        
        public FrmImage(DCMDataSet items) 
        { 
            InitializeComponent(); 
            this.items = items; 
        }
        private async Task TransformAsync(int start, int length, double window, double level, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, length, e.Graphics);
            for (int idx = start*Width; idx < Width * (length+start); idx++)//Parallel.For(0, Height * Width, idx =>
            {
                int pixel;
                if (sspixels != null) //ow ss
                {
                    pixel = sspixels[idx];
                }
                else if (uspixels != null) //ow us
                {
                    pixel = (Int16)uspixels[idx];
                }
                else//ob
                {
                    pixel = obpixels[idx];
                }
                if(pixel<=level-window/2)
                {
                    pixel = 0;
                }
                else if(pixel>level+window/2)
                {
                    pixel = 255;
                }
                else
                {
                    pixel = (int)(((pixel - level) / window + 0.5) * 255);
                }
                    //窗宽窗位变换
                    //todo:小于窗口下沿置0,大于窗口上沿置255.窗口内线性变换........
                    //显示为灰度值
                Color p = Color.FromArgb(pixel, pixel, pixel);  //灰度值
                int row = (idx-start*Width) / Width;   //行号，y
                int col = idx % Width;  //列号，x
                bmp.SetPixel(col, row, p);
            }
            //);
            e.Graphics.DrawImage(bmp, 0, start);
        }
        private void FrmImage_Load(object sender, EventArgs e)
        {
            this.Width = items[DicomTags.Columns].GetValue<ushort>(); 
            this.Height = items[DicomTags.Rows].GetValue<ushort>();
            //this.window = items[DicomTags.WindowWidth].GetValue<double>();
            //this.level = items[DicomTags.WindowCenter].GetValue<double>();
            //tsLevel.Text = level.ToString();
            //tsWindow.Text = window.ToString();
            ushort ba = items[DicomTags.BitsAllocated].GetValue<ushort>(); 
            ushort bs = items[DicomTags.BitsStored].GetValue<ushort>(); 
            ushort hb = items[DicomTags.HighBit].GetValue<ushort>(); 
            ushort pr = items[DicomTags.PixelRepresentation].GetValue<ushort>(); 
            //double k = items[DicomTags.RescaleSlope].GetValue<double>();
            //double b = items[DicomTags.RescaleIntercept].GetValue<double>();
            if (ba == 16)  //OW
            {
                uspixels = items[DicomTags.PixelData].GetValue<UInt16[]>();
                //Parallel.For(0, uspixels.Length, idx =>
                for(int idx = 0; idx < Width * Height; idx++)
                {
                    ushort val = uspixels[idx];//逐像素单元转换处理得到像素矩阵:
                    val = (ushort)(val << (15 - hb));
                    val = (ushort)(val >> (16 - bs));
                    //todo:将val先左移15-hb位，然后右移16-bs位。。。。。。
                }
            }else
            {
                obpixels = items[DicomTags.PixelData].GetValue<byte[]>();//逐像素单元转换处理得到像素矩阵......
            }
        }

        private async void FrmImage_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                window = double.Parse(tsWindow.Text);  //窗宽
                level = double.Parse(tsLevel.Text);   //窗位
                System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
                st.Start();
                int offset = 0;
                int tasks = System.Environment.ProcessorCount;
                int length = this.Height / tasks;
                for (int i = 0; i < tasks - 1; i++, offset += length)
                {
                    await TransformAsync(offset, this.Height / tasks, window, level, e);
                }
                await TransformAsync(offset, this.Height - offset, window, level, e);
                long x = st.ElapsedMilliseconds;
                Font myFont = new Font("Aeial", 16);
                PointF origin = new PointF(0, 50);
                SolidBrush myBrush = new SolidBrush(Color.Green);
                e.Graphics.DrawString(x.ToString() + "ms", myFont, myBrush, origin);
            }
            catch(Exception err)
            {

            }
            
        }

        private void tsCombobox_TextChanged(object sender, EventArgs e)
        {
            if(tsCombobox.Text=="脑窗")
            {
                tsWindow.Text = "60";
                tsLevel.Text = "35";
            }
            else if (tsCombobox.Text == "骨窗")
            {
                tsWindow.Text = "1400";
                tsLevel.Text = "600";
            }
            else if (tsCombobox.Text == "纵隔窗")
            {
                tsWindow.Text = "350";
                tsLevel.Text = "0";
            }
            else if (tsCombobox.Text == "肺窗")
            {
                tsWindow.Text = "700";
                tsLevel.Text = "-600";
            }
            else if (tsCombobox.Text == "肝窗")
            {
                tsWindow.Text = "150";
                tsLevel.Text = "30";
            }
            else if (tsCombobox.Text == "腹窗")
            {
                tsWindow.Text = "250";
                tsLevel.Text = "40";
            }
            else if (tsCombobox.Text == "脊柱窗")
            {
                tsWindow.Text = "300";
                tsLevel.Text = "60";
            }
            else if (tsCombobox.Text == "宽肺窗")
            {
                tsWindow.Text = "1500";
                tsLevel.Text = "-400";
            }
            this.Invalidate();
        }
    }
}
