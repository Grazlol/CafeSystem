using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    public static class global_variables
    {
        public static String employee_position = "";
        public static String current_user_id = "";
        public static Form homepage = new prepage();
        public static String str_checkedIn = "";

        public static Form[] Previous = new Form[0];
        static Form currentform = null;

        public static Form[] windows = {
        new CashierForm(),
        new InventoryForm(),
        new signIn(),
        new signup(),
        new home(),
        new prepage(),
        new Admin()

        };





        public static void nextWindow(Form windowtype)
        {
            Form tempform = windowtype;
                    foreach (Form window in windows)
                    {
                        window.Hide();
                    }
                    foreach (Form window in windows)
                    {
                        if (tempform != null)
                        {
                            if (window.GetType().ToString() == tempform.GetType().ToString())
                            {
                                if (currentform != null)
                                {
                                    Array.Resize(ref Previous, Previous.Length + 1);
                                    Previous[Previous.Length - 1] = currentform;
                                }
                                currentform = window;
                                window.Show();

                                break;
                            }

                        }
                    }
        }

    }

    public static class queryDB
    {
        //PUT THE CONNECTOR PORT HERE AS A BY RIGHT CLICKING THE DATABASE AND TAKE THE DATAPORT FORM THE PROPERITES
        static string database_properties = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Archille\\source\\repos\\Grazlol\\CafeSystem\\CafeSystem\\cafe_persistent.mdf;Integrated Security=True";
        //PLS DO THIS OR ELSE PROGRAM WILL FAIL TO RUN DUMB SKIBIDI GYATT



        public static SqlCommand cmd;//DONT TOUCH THIS BTW
        public static string Last_Created_ID = "";
        static SqlConnection con = new SqlConnection(database_properties);
        public static void query(string SQLCOMMAND)//Performs a commmand through a string
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand(SQLCOMMAND, con);
        }

        public static void update(string New_Value, string Column, string RowIdentifier, string Row, string Table)//changes a specified field in a specified row 
        {

            try
            {
                query("UPDATE " + Table + " SET " + Column + " = '" + New_Value + "' where " + RowIdentifier + " = '" + Row + "'");
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { return; }   //DOES NOTHING IF THE SPECIFIED  FIELDS DO NOT EXIST AT ALL.
        }

        public static String select(string Column, string RowIdentifier, string Row, string Table)//returns a string value of  a specified row and column
        {
            try
            {
                query("SELECT " + Column + " from " + Table + " where " + RowIdentifier + " = '" + Row + "'");
                SqlDataReader table_scanner = cmd.ExecuteReader();
                table_scanner.Read();
                return table_scanner.GetValue(0).ToString();
            }
            catch (Exception e) { return "null"; }   //DOES NOTHING IF THE SPECIFIED  FIELDS DO NOT EXIST AT ALL.

        }

        public static Array selectMultiple(string Column, string Table)
        {
            String[] templar = new String[0];
            int index = 0;
            query("SELECT " + Column + " From " + Table);
            SqlDataReader table_scanner = cmd.ExecuteReader();
            string storedString = "";
            while (true)
            {
                try
                {
                    table_scanner.Read();
                    storedString = table_scanner.GetValue(0).ToString();
                    Array.Resize(ref templar, templar.Length + 1);
                    templar[index] = storedString;
                    index++;
                    continue;
                }
                catch (Exception e)
                {
                    break;
                }
            }
            return templar;
        }
        public static void insert(string PrimaryKeyName, string Table)//creates a new row with a random key
        {
            while (true)
            {
                Random rnd = new Random();
                string IDNumber = DateTime.Now.Year.ToString() + rnd.Next(100000, 999999);
                try
                {
                    query("SELECT " + PrimaryKeyName + " From " + Table + " where " + PrimaryKeyName + " = " + IDNumber);
                    SqlDataReader table_scanner = cmd.ExecuteReader();
                    table_scanner.Read();
                    Console.WriteLine(table_scanner.GetValue(0).ToString());

                    continue;
                }
                catch (Exception e)
                {
                    Last_Created_ID = IDNumber;
                    query("INSERT INTO " + Table + "(" + PrimaryKeyName + ") VALUES (" + IDNumber + ")");
                    Console.WriteLine("INSERT INTO " + Table + "(" + PrimaryKeyName + ") VALUES ('" + IDNumber + "')");
                    cmd.ExecuteNonQuery();
                    break;
                }
            }
        }

        public static DataTable selectTable(string Query)
        {
            query(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
