﻿using Kotches.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kotches
{
    static class Program
    {
        public static DateTime last_log_in;
        public static string user_name;
        public static int user_id;
        public static string user_type;
        public static string user_password;
       
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}
