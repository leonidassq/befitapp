using System.ComponentModel.DataAnnotations;

public class TypCwiczenia
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nazwa ćwiczenia jest wymagana")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Nazwa musi mieć od 3 do 50 znaków")]
    [Display(Name = "Nazwa ćwiczenia")]
    public string Nazwa { get; set; }
}
