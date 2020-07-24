﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class Meeting
    {
        public string EventName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Color Color { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
