using MediatR;
using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Entities;
using System.Collections.Generic;

namespace LaboratorioDeTestesAPI.Handlers.Livro.Commands
{
    public record UpdateLivroCommand(LivroEditarDto LivroEditarDto) : IRequest<Entities.Livro>;
}
