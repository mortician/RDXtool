using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RDXtool.Libs
{
    public class Lib_TEX
    {
        public class TEX_File
        {
            public string Magic { get; set; }       //4 byte string, can be "TIM2" or different...
            public UInt32 Size { get; set; }        //byte size of texture defined...
            public UInt32 Dummy_0 { get; set; }     //dummy?, always 0x43444344 (1145259075)?
            public UInt32 Dummy_1 { get; set; }     //dummy?, always 0x43444344 (1145259075)?
            public UInt32 Dummy_2 { get; set; }     //dummy?, always 0x43444344 (1145259075)?
            public UInt32 Dummy_3 { get; set; }     //dummy?, always 0x43444344 (1145259075)?
            public UInt32 Dummy_4 { get; set; }     //dummy?, always 0x43444344 (1145259075)?
            public UInt32 Dummy_5 { get; set; }     //dummy?, always 0x43444344 (1145259075)?

            public TEX_File()                               //Default constructor
            {
                Magic = "    ";
                Size = 0;
                Dummy_0 = 0;
                Dummy_1 = 0;
                Dummy_2 = 0;
                Dummy_3 = 0;
                Dummy_4 = 0;
                Dummy_5 = 0;
            }
            public TEX_File(FileStream Fs, UInt32 Offset)   //Filestream reading constructor
            {
                BinaryReader Br = new BinaryReader(Fs);
                Fs.Seek(Offset, SeekOrigin.Begin);

                Magic = Encoding.ASCII.GetString(Br.ReadBytes(4), 0, 4);
                Size = Br.ReadUInt32();
                Dummy_0 = Br.ReadUInt32();
                Dummy_1 = Br.ReadUInt32();
                Dummy_2 = Br.ReadUInt32();
                Dummy_3 = Br.ReadUInt32();
                Dummy_4 = Br.ReadUInt32();
                Dummy_5 = Br.ReadUInt32();
            }
        }
    }
}
