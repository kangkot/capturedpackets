﻿//$Header: https://svn.code.sf.net/p/capturedpackets/code/trunk/PacketCaptureAnalyser/Ethernet%20Frame/IP%20Packet/UDP%20Datagram/Constants.cs 212 2014-04-17 18:01:00Z michaelmayes $

//This file is part of the C# Packet Capture application. It is free and
//unencumbered software released into the public domain as detailed in
//the UNLICENSE file in the top level directory of this distribution

//SVN revision information:
//File:    : $URL$
//Revision : $Revision$
//Date     : $Date$
//Author   : $Author$

namespace EthernetFrame.IPPacket.UDPDatagram
{
    class Constants
    {
        //
        //UDP datagram header - 8 bytes
        //

        //Length

        public const ushort HeaderLength = 8;

        //Port number

        public enum PortNumber : ushort
        {
            DummyValueMin = 0,
            DummyValueMax = 65535
        }
    }
}