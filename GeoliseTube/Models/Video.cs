using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeoliseTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
    public string Description { get; set; }

    [Display(Name = "Data de Postagem")]
    [Required(ErrorMessage = "A Data de Postagem é obrigatória")]
    public DateTime UploadDate { get; set; }

    [Display(Name = "Duração")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }

    [StringLength(200)]
    [Display(Name = "Foto")]
    public string Thumbnail { get; set; }

    [StringLength(200)]
    [Display(Name = "Arquivo de Vídeo")]
    public string VideoFile { get; set; }

        public ICollection<VideoTag> Tags { get; set; }


}