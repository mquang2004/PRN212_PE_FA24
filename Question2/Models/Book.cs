using System;
using System.Collections.Generic;

namespace Question2.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Publisher { get; set; }

    public int? PublicationYear { get; set; }

    public virtual ICollection<BookCopy> BookCopies { get; set; } = new List<BookCopy>();

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
