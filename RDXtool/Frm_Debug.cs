using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RDXtool.Libs;

namespace RDXtool
{
    public partial class Frm_Debug : Form
    {
        public Frm_Debug()
        {
            InitializeComponent();
        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            //
            string src_path = @"C:\Users\mort7x64\Desktop\PS2_RDX\DC (EUR)";
            string[] files = Directory.GetFiles(src_path, "*.rdx");

            for (int i = 0; i < files.Length; i++)
            {
                //Txt_Result.Text += "prsdec " + files[i].Substring(38, files[i].Length - 38) + " " + files[i].Substring(38, files[i].Length - 38).Replace(".rdx", ".bin") + Environment.NewLine;

                FileStream Fs = new FileStream(files[i], FileMode.Open);

                Lib_RDX.RDX_Header Header = Lib_RDX.Read_Header(Fs);

                Fs.Close();

                if (Header.Tag != 1092616192)
                {
                    Lst_Result.Items.Add(files[i] + " ::: " + Header.Tag.ToString());
                }

            }
        }
    }
}
