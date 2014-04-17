﻿//$Header: https://svn.code.sf.net/p/capturedpackets/code/trunk/PacketCaptureAnalyser/Analysis/Time%20Analysis/Constants.cs 212 2014-04-17 18:01:00Z michaelmayes $

//This file is part of the C# Packet Capture application. It is free and
//unencumbered software released into the public domain as detailed in
//the UNLICENSE file in the top level directory of this distribution

//SVN revision information:
//File:    : $URL$
//Revision : $Revision$
//Date     : $Date$
//Author   : $Author$

namespace Analysis.TimeAnalysis
{
    class Constants
    {
        //Timestamps

        public const double MinTimestampDifference = 0.03; //Milliseconds

        //Timestamp and Time differences

        public const double ExpectedTimeDifference = 1000.0; //Milliseconds

        public const double MaxNegativeTimeDifference = -2.0; //Milliseconds
        public const double MaxPositiveTimeDifference = 2.0; //Milliseconds

        //Value bins

        public const uint TimestampBinsPerMillisecond = 40; //Forty value bins for every millisecond of latency
        public const uint TimestampNumberOfBins = ((uint)(MaxPositiveTimeDifference - MaxNegativeTimeDifference) * TimestampBinsPerMillisecond);

        public const uint TimeBinsPerMillisecond = 40; //Forty value bins for every millisecond of latency
        public const uint TimeNumberOfBins = ((uint)(MaxPositiveTimeDifference - MaxNegativeTimeDifference) * TimeBinsPerMillisecond);
    }
}