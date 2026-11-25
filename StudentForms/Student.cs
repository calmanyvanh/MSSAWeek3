using System;
using System.Collections.Generic;
using System.Text;

namespace StudentForms
{
    enum moa
    {
        January = 1,
        February = 2,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12

    }
    enum grade
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        F = 5

    }

    internal class Student
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public moa smoa { get; set; }
        public grade sgrade { get; set; }

    }
}
