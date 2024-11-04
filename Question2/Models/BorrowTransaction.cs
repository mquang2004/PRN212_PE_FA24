using System;
using System.Collections.Generic;

namespace Question2.Models;

public partial class BorrowTransaction
{
    public int TransactionId { get; set; }

    public int UserId { get; set; }

    public int CopyId { get; set; }

    public DateOnly BorrowDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual BookCopy Copy { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
