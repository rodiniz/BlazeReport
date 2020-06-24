﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazeReport.Tests.Factories
{
    public static class ReportFactory
    {
        public static readonly string ReportPath = $"{AppDomain.CurrentDomain.BaseDirectory}ExtentBlazeReport.html";

        public static IExtentReporter Default()
        {
            return new ExtentHtmlReporter(ReportPath);
        }
    }
}
