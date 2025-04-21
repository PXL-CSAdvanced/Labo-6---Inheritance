using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_6___Inheritance
{
    class ActivityLog : Log
    {
        public char ActivityType { get; set; }

        public override void Write(string message)
        {
            base.Write(message);
            Console.WriteLine($"ACTIVITY {message}");
        }

        //2
        public ActivityLog(string fileName) : base(fileName) { }

        //public override void Write(string message) => Write('-', message);

        //public void Write(char activityType, string message)
        //{
        //    ActivityType = activityType;
        //    DateTime currentTime = DateTime.Now;
        //    _log.Add(currentTime, message);
        //    StreamWriter sw = new StreamWriter(_fileName, true);
        //    sw.WriteLine($"{currentTime}{message}");
        //    sw.Close();
        //    Console.WriteLine($"ACTIVITY [{currentTime}] {activityType}: {message}");
        //}
    }
}
