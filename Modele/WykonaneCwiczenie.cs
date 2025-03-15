using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class WykonaneCwiczenie
{
    public int Id { get; set; }

    [Required]
    [ForeignKey("TypCwiczenia")]
    [Display(Name = "Typ ćwiczenia")]
    public int TypCwiczeniaId { get; set; }
    public TypCwiczenia TypCwiczenia { get; set; }

    [Required]
    [ForeignKey("SesjaTreningowa")]
    public int SesjaTreningowaId { get; set; }
    public SesjaTreningowa SesjaTreningowa { get; set; }

    [Range(0, 500)]
    [Display(Name = "Obciążenie (kg)")]
    public decimal Obciazenie { get; set; }

    [Range(1, 20)]
    [Display(Name = "Liczba serii")]
    public int LiczbaSerii { get; set; }

    [Range(1, 100)]
    [Display(Name = "Powtórzeń w serii")]
    public int LiczbaPowtorzen { get; set; }

    // Automatyczne przypisanie użytkownika
    public string UserId { get; set; }
}
