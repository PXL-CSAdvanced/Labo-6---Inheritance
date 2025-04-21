
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labo_6___Inheritance
{
    //4
    abstract class Log //class Log
    {
        //FIX 1 private Dictionary<DateTime, string> _log = new Dictionary<DateTime, string>();

        public virtual void Write(string message)
        {
            DateTime now = DateTime.Now;
            //FIX 1
            Logging._log.Add(now, message); //_log.Add(now, message);
            //3
            if (!string.IsNullOrEmpty(_fileName))
            {
                //2
                StreamWriter sw = new StreamWriter(_fileName, true);
                sw.WriteLine($"[{now}] {message}");
                sw.Close();
            }
            if (_connection is not null)
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand("insert into log(Datum, Bericht) values(getdate(), @message)", _connection);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void DisplayLog()
        {
            Console.WriteLine($"<begin of log>");
            //FIX 1
            foreach (var item in Logging._log) //foreach (var item in _log)
            {
                Console.WriteLine($"\t[{item.Key}] {item.Value}");
            }
            Console.WriteLine("<end of log>");
        }

        //2
        private string _fileName;
        public Log(string fileName)
        {
            _fileName = fileName;
        }

        //3
        public SqlConnection _connection;
        public Log(SqlConnection connection)
        {
            _connection = connection;
        }

        //CREATE TABLE log
        //(
        //    Datum datetime,
        //    Bericht varchar(500)
        //)

        //4
        //public int? ErrorLevel { get; set; }
        //public char ActivityType { get; set; }
        //public abstract void Write(string message);
    }
}
