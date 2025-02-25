using System;

namespace EFCodeFirstMSSQL
{
    public class Student
    {
        public int StudentId { get; set; }  // Primary Key
        public string Name { get; set; }
        public int Age { get; set; }
    }
}