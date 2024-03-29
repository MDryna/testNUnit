﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNUnit
{
    public class TestSettings : BaseTest

    {
        public static string HostUrl = "https://mate.academy/";
        public const string login = "mm_dryna@ukr.net";
        public const string password = "0105Maria!";
        public static string mail = "@gmail.com";
        

        public static string courseFE { get; } = "Front-end developer";
        public static string courseQA { get; } = "QA engineer";
        public static string courseFULL { get; } = "Full-stack developer";
        public static string courseJava { get; } = "Java developer";
        public static string courseUIUX { get; } = "UI/UX Design";
        public static string coursePython { get; } = "Python developer";

        public const int Wait_for_element_timeout = 40;
        

    }
}
