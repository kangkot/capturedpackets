//This file is part of the C# Packet Capture application. It is free and
//unencumbered software released into the public domain as detailed in
//the UNLICENSE file in the top level directory of this distribution

//$Id$
//$URL      : https://svn.code.sf.net/p/capturedpackets/code/trunk/PacketCaptureAnalyser/Ethernet%20Frame/IP%20Packet/IPv4%20Packet/IGMPv2%20Packet/Processing.cs $
//$Revision : 214 $
//$Date     : 2014-04-17 19:11:24 +0100 (Thu, 17 Apr 2014) $
//$Author   : michaelmayes $

namespace EthernetFrame.IPPacket.IPv4Packet.IGMPv2Packet
{
    class Processing
    {
        private System.IO.BinaryReader TheBinaryReader;

        private Structures.PacketStructure ThePacket;

        public Processing(System.IO.BinaryReader TheBinaryReader)
        {
            this.TheBinaryReader = TheBinaryReader;

            //Create an instance of the IGMPv2 packet
            ThePacket = new Structures.PacketStructure();
        }

        public bool Process(ushort TheIGMPv2PacketLength)
        {
            bool TheResult = true;

            //There is no separate header for the IGMPv2 packet

            //Just read off the bytes for the IGMPv2 packet from the packet capture so we can move on
            ThePacket.Type = TheBinaryReader.ReadByte();
            ThePacket.MaxResponseTime = TheBinaryReader.ReadByte();
            ThePacket.Checksum = TheBinaryReader.ReadUInt16();
            ThePacket.GroupAddress = TheBinaryReader.ReadUInt32();

            return TheResult;
        }
    }
}