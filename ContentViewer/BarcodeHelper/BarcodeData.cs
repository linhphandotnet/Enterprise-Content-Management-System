﻿using Ecm.ContentViewer.Model;
using System;

namespace Ecm.ContentViewer.BarcodeHelper
{
    public class BarcodeData
    {
        public int Position { get; set; }

        public BarcodeTypeModel Type { get; set; }

        public string Value { get; set; }
    }

    //public enum BarcodeType
    //{
    //    CODABAR = 0,
    //    CODE128 = 1,
    //    CODE25 = 2,
    //    CODE25NI = 3,
    //    CODE39 = 4,
    //    CODE93 = 5,
    //    DATABAR = 6,
    //    DATAMATRIX = 8,
    //    EAN13 = 9,
    //    EAN8 = 7,
    //    MICROPDF417 = 10,
    //    PATCH = 11,
    //    PDF417 = 12,
    //    QRCODE = 13,
    //    SHORTCODE128 = 14,
    //    UPCA = 15,
    //    UPCE = 0x10
    //}

}

