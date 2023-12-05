using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entities.Dtos;
public sealed record ProductAddDto(
    string Name,
    decimal Price);
