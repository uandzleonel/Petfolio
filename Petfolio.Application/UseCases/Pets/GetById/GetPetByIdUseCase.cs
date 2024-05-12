using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson {
            Id = 1,
            Name = "Mirna",
            Birthday = new DateTime(year: 2024, month: 01, day: 91),
            Type = Communication.Enums.PetType.Dog
        };
    }
}
