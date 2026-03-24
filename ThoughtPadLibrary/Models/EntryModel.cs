using System;
using System.ComponentModel.DataAnnotations;

namespace ThoughtPadLibrary.Models;

public class EntryModel
{
    [Required]
    public int Id { get; init; }
    [Required]
    public string Text { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
}
