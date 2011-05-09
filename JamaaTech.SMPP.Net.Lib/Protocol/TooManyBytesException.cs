/************************************************************************
 * Copyright (C) 2007 Jamaa Technologies
 *
 * This file is part of Jamaa SMPP Library.
 *
 * Jamaa SMPP Library is free software. You can redistribute it and/or modify
 * it under the terms of the Microsoft Reciprocal License (Ms-RL)
 *
 * You should have received a copy of the Microsoft Reciprocal License
 * along with Jamaa SMPP Library; See License.txt for more details.
 *
 * Author: Benedict J. Tesha
 * benedict.tesha@jamaatech.com, www.jamaatech.com
 *
 ************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using JamaaTech.Smpp.Net.Lib;

namespace JamaaTech.Smpp.Net.Lib.Protocol
{
    public class TooManyBytesException : PDUException
    {
        #region Constructors
        public TooManyBytesException()
            : base(SmppErrorCode.ESME_RINVCMDLEN, "PDU encountered many bytes than expected") { }

        public TooManyBytesException(string message)
            : base(SmppErrorCode.ESME_RINVCMDLEN, message) { }
        #endregion
    }
}
