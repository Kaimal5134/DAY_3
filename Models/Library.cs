using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Library
{
    public int IdLibrary { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Secname { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<RelisedBook> RelisedBooks { get; set; } = new List<RelisedBook>();
}
