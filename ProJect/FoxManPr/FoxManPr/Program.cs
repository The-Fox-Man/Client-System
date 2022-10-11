using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace FoxManPr
{

    internal static class Program
    {
        public const string connect = "SslMode=none;Server=localhost;Database=sgosit;port=3306;Uid=root";

        public static MySqlConnection con;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            con = new MySqlConnection(connect);
            con.Open();
            Application.Run(new main());
            con.Close();
        }
    }
}
