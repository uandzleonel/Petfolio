using System.ComponentModel.DataAnnotations;
using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;

public class RequestPetJson
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public DateTime Birthday { get; set; }
    [Required]
    public PetType Type { get; set; } = PetType.Unknown;
}
