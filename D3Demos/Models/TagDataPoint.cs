using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D3Demos.Models
{
    public class TagDataPoint
    {
        public string Place { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }

        //public DateTime DateAsked
        //{
        //    get
        //    {
        //        return new DateTime(YearAsked, MonthAsked, 1);
        //    }
        //    set { }
        //}
    }
}