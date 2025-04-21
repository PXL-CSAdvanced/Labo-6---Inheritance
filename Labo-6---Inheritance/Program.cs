using Labo_6___Inheritance;
using static System.Runtime.InteropServices.JavaScript.JSType;

//4
////1
////Log log = new Log();
////2
//Log log = new Log("info.log");
//log.Write("Test log");

//1
//ActivityLog actLog = new ActivityLog();
//2
ActivityLog actLog = new ActivityLog("activity.log");
actLog.Write("Test activity log");

//1
//ErrorLog errLog = new ErrorLog();
//2
//ErrorLog errLog = new ErrorLog("error.log");
//3
ErrorLog errLog = new ErrorLog(new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Demo;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));
errLog.Write("Test error log");

//4
//log.DisplayLog();