﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SMSService
{
    public class SmsMessage
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
    }
}
