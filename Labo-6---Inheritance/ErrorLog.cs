using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_6___Inheritance
{
    class ErrorLog : Log
    {
        public override void Write(string message)
        {
            base.Write(message);
            Console.WriteLine($"ERROR {message}");
        }

        //2
        public ErrorLog(string fileName) : base(fileName) { }
        
        //3
        public ErrorLog(SqlConnection connection) : base(connection) { }

        //public int ErrorCode { get; set; }
        //public override void Write(string message) => Write(null, message);
    }
}
