﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace YY.EventLogAssistant.Services.Tests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void ToDateTimeFormat_Test()
        {
            long sourceLong = 637149888000000;
            DateTime checkDate = new DateTime(2020, 1, 19);
            DateTime? resultDate = sourceLong.ToDateTimeFormat();

            Assert.Equal(checkDate, resultDate);
        }

        [Fact]
        public void ToNullableDateTimeELFormat_Test()
        {
            long sourceLong = 637149888000000;
            DateTime checkDate = new DateTime(2020, 1, 19);
            DateTime? resultDate = sourceLong.ToNullableDateTimeELFormat();

            Assert.Equal(checkDate, resultDate);
        }
    }
}
