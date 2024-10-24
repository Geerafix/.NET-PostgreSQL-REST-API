using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Puzzle {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int puzzle_id { get; set; }

    [Required]
    public int size { get; set; }

    [Required]
    public string clues_x { get; set; }

    [Required]
    public string clues_y { get; set; }

    public string? excluded_tiles { get; set; }
}
