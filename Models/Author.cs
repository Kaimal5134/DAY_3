using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Author
{
    public int Idauthors { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
