using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDXtool.Libs;

namespace RDXtool
{
    public partial class Frm_Main : Form
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        // DECLARATIONS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Lib_RDX.RDX_Header RDX_HEADER;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        // INTERFACE
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Frm_Main()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        // FILE I/O
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void DUMP_FILE(byte[] buffer, string tFile)
        {
            if (File.Exists(tFile)) {File.Delete(tFile);}

            FileStream fs = new FileStream(tFile, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(buffer);

            fs.Close();
        }

        private void Btn_Open_File_Click(object sender, EventArgs e)
        {
            Open_File();
        }

        private void Open_File()
        {
            Dlg_Open_Files.ShowDialog();

            if (File.Exists(Dlg_Open_Files.FileName))
            {
                FileStream Fs = new FileStream(Dlg_Open_Files.FileName, FileMode.Open);
                RDX_HEADER = Lib_RDX.Read_Header(Fs);

                Lst_Header.Items.Clear();

                Lst_Header.Items.Add("0");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("Tag");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.Tag.ToString("X4"));
                Lst_Header.Items.Add("16");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Sub");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_SUB.ToString());
                Lst_Header.Items.Add("20");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_MDL");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_MDL.ToString());
                Lst_Header.Items.Add("24");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_MTN");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_MTN.ToString());
                Lst_Header.Items.Add("28");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_???");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_UNK.ToString());
                Lst_Header.Items.Add("32");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_TEX");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_TEX.ToString());
                
                Lst_Header.Items.Add("96");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("Author");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.Author);

                Lst_Header.Items.Add("128");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_CAM?");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_CAM.ToString());
                Lst_Header.Items.Add("132");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_LIT?");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_LIT.ToString());
                Lst_Header.Items.Add("136");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_0");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_0.ToString());
                Lst_Header.Items.Add("140");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_OBJ");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_OBJ.ToString());
                Lst_Header.Items.Add("144");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_1");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_1.ToString());
                Lst_Header.Items.Add("148");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_2");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_2.ToString());
                Lst_Header.Items.Add("152");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_SCA");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_SCA.ToString());
                Lst_Header.Items.Add("156");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_AOT");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_AOT.ToString());
                Lst_Header.Items.Add("160");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_3");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_3.ToString());
                Lst_Header.Items.Add("164");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_START");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_START.ToString());
                Lst_Header.Items.Add("168");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_4");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_4.ToString());
                Lst_Header.Items.Add("172");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_5");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_5.ToString());
                Lst_Header.Items.Add("176");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_6");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_6.ToString());
                Lst_Header.Items.Add("180");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_7");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_7.ToString());
                Lst_Header.Items.Add("184");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_TXT");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_TEXT.ToString());
                Lst_Header.Items.Add("196");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add("O_Unknown_8");
                Lst_Header.Items[Lst_Header.Items.Count - 1].SubItems.Add(RDX_HEADER.O_Unknown_8.ToString());
            }
        }
    }
}
