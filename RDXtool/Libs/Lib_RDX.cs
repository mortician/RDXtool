using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RDXtool.Libs
{
    public class Lib_RDX
    {
		//RDX files are compressed with the Sega PRS compression! Needs decompression before handling is possible!
        public struct RDX_Header
        {
            public UInt32 Tag;              //Always (0x00002041 = 1092616192) or (0xB81E0540 = 1074077368)???
            public UInt32 Dummy_0;
            public UInt32 Dummy_1;
            public UInt32 Dummy_2;
            public UInt32 O_SUB;            //Points to subheader...
            public UInt32 O_MDL;            //Points to model table...
            public UInt32 O_MTN;            //Points to MTN (motion?) table...
            public UInt32 O_UNK;            //Points to unknown offset table, maybe SCD?
            public UInt32 O_TEX;            //Points to texture offset table...
            public string Author;           //Name of file author, whole section is always 32 bytes in size
            public UInt32 O_CAM;
            public UInt32 O_LIT;
            public UInt32 O_Unknown_0;
            public UInt32 O_OBJ;
            public UInt32 O_Unknown_1;
            public UInt32 O_Unknown_2;
            public UInt32 O_SCA;
            public UInt32 O_AOT;
            public UInt32 O_Unknown_3;
            public UInt32 O_START;
            public UInt32 O_Unknown_4;
            public UInt32 O_Unknown_5;
            public UInt32 O_Unknown_6;
            public UInt32 O_Unknown_7;
            public UInt32 O_Unknown_8;
            public UInt32 O_TEXT;
            //64 byte gap, probably dummy data due to some data alignment...
            public UInt32 C_CAM;
            public UInt32 C_LIT;
            public UInt32 C_Unknown_0;
            public UInt32 C_OBJ;
            public UInt32 C_Unknown_1;
            public UInt32 C_Unknown_2;
            public UInt32 C_SCA;
            public UInt32 C_AOT;
            public UInt32 C_Unknown_3;
            public UInt32 C_START;
            public UInt32 C_Unknown_4;
            public UInt32 C_Unknown_5;
            public UInt32 C_Unknown_6;
            public UInt32 C_Unknown_7;
            public UInt32 C_TEXT;
            public UInt32 C_Unknown_8;
            //64 byte gap, probably dummy data due to some data alignment...
        }

        public struct RDX_Room_Spawn_Point
        {
            public float X;
            public float Y;
            public float Z;
            public Int32 Rotation;
        }

        public static RDX_Header Read_Header(FileStream Fs)
        {
            RDX_Header Header = new RDX_Header();
            BinaryReader Br = new BinaryReader(Fs);

            if(Fs.Length > 384)
            {
                Header.Tag = Br.ReadUInt32();

                if(Header.Tag == 1092616192 || Header.Tag == 1074077368)
                {
                    Fs.Seek(16, SeekOrigin.Begin);

                    Header.O_SUB = Br.ReadUInt32();
                    Header.O_MDL = Br.ReadUInt32();
                    Header.O_MTN = Br.ReadUInt32();
                    Header.O_UNK = Br.ReadUInt32();
                    Header.O_TEX = Br.ReadUInt32();

                    Fs.Seek(96, SeekOrigin.Begin);
                    Header.Author = Encoding.ASCII.GetString(Br.ReadBytes(32), 0, 32).Trim();
                    Fs.Seek(Header.O_SUB, SeekOrigin.Begin);

                    Header.O_CAM = Br.ReadUInt32();
                    Header.O_LIT = Br.ReadUInt32();
                    Header.O_Unknown_0 = Br.ReadUInt32();
                    Header.O_OBJ = Br.ReadUInt32();
                    Header.O_Unknown_1 = Br.ReadUInt32();
                    Header.O_Unknown_2 = Br.ReadUInt32();
                    Header.O_SCA = Br.ReadUInt32();
                    Header.O_AOT = Br.ReadUInt32();
                    Header.O_Unknown_3 = Br.ReadUInt32();
                    Header.O_START = Br.ReadUInt32();
                    Header.O_Unknown_4 = Br.ReadUInt32();
                    Header.O_Unknown_5 = Br.ReadUInt32();
                    Header.O_Unknown_6 = Br.ReadUInt32();
                    Header.O_Unknown_7 = Br.ReadUInt32();
                    Header.O_TEXT = Br.ReadUInt32();
                    Header.O_Unknown_8 = Br.ReadUInt32();

                    Fs.Seek(256, SeekOrigin.Begin);

                    Header.C_CAM = Br.ReadUInt32();
                    Header.C_LIT = Br.ReadUInt32();
                    Header.C_Unknown_0 = Br.ReadUInt32();
                    Header.C_OBJ = Br.ReadUInt32();
                    Header.C_Unknown_1 = Br.ReadUInt32();
                    Header.C_Unknown_2 = Br.ReadUInt32();
                    Header.C_SCA = Br.ReadUInt32();
                    Header.C_AOT = Br.ReadUInt32();
                    Header.C_Unknown_3 = Br.ReadUInt32();
                    Header.C_START = Br.ReadUInt32();
                    Header.C_Unknown_4 = Br.ReadUInt32();
                    Header.C_Unknown_5 = Br.ReadUInt32();
                    Header.C_Unknown_6 = Br.ReadUInt32();
                    Header.C_Unknown_7 = Br.ReadUInt32();
                    Header.C_TEXT = Br.ReadUInt32();
                    Header.C_Unknown_8 = Br.ReadUInt32();
                }
                else
                {
                    if (Header.Tag == 536871135)    //0xDF000020
                    {
                        //File still compressed!
                    }
                    //not a valid file?
                }
            }

            return Header;
        }

















        public struct TEX_Header
        {
            public int Tag;		//Can be TPVR(DC)
            public int Size;	//Value - 16 (Len of GBIX 16 Byte struct)
            public int Dummy_0;
            public int Dummy_1;
            public int Dummy_2;
            public int Dummy_3;
            public int Dummy_4;
            public int Dummy_5;
        }
        public struct TEX_Subheader
        {
            public int Tag;		//GBIX(DC)
            public int U0;		//Bitdepth? Most of the time 8
            public int U1;		//??? Maybe a global texture ID?
            public int Dummy;	//Always 0x20202020 ?	
        }
    }

}
