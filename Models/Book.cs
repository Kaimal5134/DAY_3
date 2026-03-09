using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Book
{
    public int Idbooks { get; set; }

    public string NameBook { get; set; } = null!;

    public int AuthorId { get; set; }

    public decimal PriceBook { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<RelisedBook> RelisedBooks { get; set; } = new List<RelisedBook>();
}
