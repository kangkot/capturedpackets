﻿//This file is part of the C# Packet Capture application. It is free and
//unencumbered software released into the public domain as detailed in
//the UNLICENSE file in the top level directory of this distribution

namespace EthernetFrame.LLDPPacket
{
    class Processing
    {
        private System.IO.BinaryReader TheBinaryReader;

        private Structures.LLDPPacketStructure ThePacket;

        public Processing(System.IO.BinaryReader TheBinaryReader)
        {
            this.TheBinaryReader = TheBinaryReader;

            //Create an instance of the LLDP packet
            ThePacket = new Structures.LLDPPacketStructure();
        }

        public bool Process(long ThePayloadLength)
        {
            bool TheResult = true;

            if (ThePayloadLength < Constants.LLDPPacketLength)
            {
                System.Diagnostics.Trace.WriteLine
                    (
                    "The payload length of the Ethernet frame is lower than the length of the LLDP packet!!!"
                    );

                return false;
            }

            //There is no separate header for the LLDP packet

            //Just read off the bytes for the LLDP packet from the packet capture so we can move on
            ThePacket.UnusedField1 = TheBinaryReader.ReadUInt64();
            ThePacket.UnusedField2 = TheBinaryReader.ReadUInt64();
            ThePacket.UnusedField3 = TheBinaryReader.ReadUInt64();
            ThePacket.UnusedField4 = TheBinaryReader.ReadUInt64();
            ThePacket.UnusedField5 = TheBinaryReader.ReadUInt64();
            ThePacket.UnusedField6 = TheBinaryReader.ReadUInt32();
            ThePacket.UnusedField7 = TheBinaryReader.ReadUInt16();

            return TheResult;
        }
    }
}