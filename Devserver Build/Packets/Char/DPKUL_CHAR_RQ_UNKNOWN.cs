﻿using System;
using System.Runtime.InteropServices;

namespace DevServer.Packets
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class DPKUL_CHAR_RQ_UNKNOWN : Packet
    {
        public DPKUL_CHAR_RQ_UNKNOWN()
        {
             Length = Convert.ToUInt16(Marshal.SizeOf(this));

            Type = PacketType.DPKUL_CHAR_RQ_UNKNOWN;
        }

        public short UnkShort1;
        public byte UnkByte;
        public byte UnkByte1;

        public int UnknownInt;
        public int UnknownInt2;
        public int UnknownInt3;
        public int UnknownInt4;
        public int UnknownInt5;
        public short UnknownShort;
        public byte UnknownByte;


     
    }
}