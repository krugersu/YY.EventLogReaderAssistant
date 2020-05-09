﻿using System;

namespace YY.EventLogReaderAssistant.Models
{
    [Serializable]
    public class Computers
    {
        public long Code { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
