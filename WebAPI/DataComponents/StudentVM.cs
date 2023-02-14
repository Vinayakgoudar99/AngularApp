using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.DataComponents
{
    public class StudentVM
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public long MobileNo { get; set; }
    }
}