using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Student
{
    public int IdStudents { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Secname { get; set; } = null!;

    public string Class { get; set; } = null!;

    public long Number { get; set; }

    public virtual ICollection<RelisedBook> RelisedBooks { get; set; } = new List<RelisedBook>();
}
