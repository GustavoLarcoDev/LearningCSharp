using System.ComponentModel.DataAnnotations;

namespace GameStore.Models;

public class Genre
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }
}
