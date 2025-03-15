using System.ComponentModel.DataAnnotations;

public class SesjaTreningowa
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Data i czas rozpoczęcia")]
    public DateTime DataRozpoczecia { get; set; }

    [Required]
    [Display(Name = "Data i czas zakończenia")]
    public DateTime DataZakonczenia { get; set; }

    // Automatyczne przypisanie użytkownika
    public string UserId { get; set; }
}
