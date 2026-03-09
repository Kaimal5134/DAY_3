using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class RelisedBook
{
    public int IdrelisedBooks { get; set; }

    public int CodeBook { get; set; }

    public int CodeLibrary { get; set; }

    public int CodeStudent { get; set; }

    public DateOnly? Date { get; set; }

    public virtual Book CodeBookNavigation { get; set; } = null!;

    public virtual Library CodeLibraryNavigation { get; set; } = null!;

    public virtual Student CodeStudentNavigation { get; set; } = null!;
}
