﻿using System;
using System.Drawing;

namespace TestApp.Configs
{
    class DatabaseConfig
    {
        public static String CONNECTION_STRING = @"Data Source=LAMNGUYEN5464\SQLEXPRESS;Initial Catalog=MusicPlayer_v2;Integrated Security=True";
    }
    class ColorPrimary
    {
        public static Color primary = System.Drawing.ColorTranslator.FromHtml("#4dd0e1");
        public static Color primaryLight = System.Drawing.ColorTranslator.FromHtml("#88ffff");
        public static Color primaryDark = System.Drawing.ColorTranslator.FromHtml("#009faf");
        public static Color secondary = System.Drawing.ColorTranslator.FromHtml("#f8bbd0");
        public static Color secondaryLight = System.Drawing.ColorTranslator.FromHtml("#ffeeff");
        public static Color secondaryDark = System.Drawing.ColorTranslator.FromHtml("#c48b9f");

    }
}
