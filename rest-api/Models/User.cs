using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int user_id { get; set; }

    [Required]
    [EmailAddress]
    public string email { get; set; }

    [Required]
    public string username { get; set; }

    [Required]
    public string password { get; set; }

    [Required]
    public string role { get; set; } = "user";
}