using MediatR;
using LaboratorioDeTestes.Entities;
using System.Collections.Generic;
using LaboratorioDeTestes.Dtos;

namespace LaboratorioDeTestes.Handlers.Livro.Commands
{
    public record UpdateLivroCommand(LivroEditarDto LivroEditarDto) : IRequest<Entities.Livro>;
}
