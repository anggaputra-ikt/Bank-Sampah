using Application.Nasabahs.Dtos;
using MediatR;

namespace Application.Nasabahs.Commands
{
    public class CreateNasabahCommand : IRequest<string>
    {
        public NasabahDto? nasabahDto { get; set; }
    }

    public class CreateNasabahCommandHandler : IRequestHandler<CreateNasabahCommand, string>
    {
        private readonly INasabahService service;

        public CreateNasabahCommandHandler(INasabahService service)
        {
            this.service = service;
        }

        public Task<string> Handle(CreateNasabahCommand request, CancellationToken cancellationToken)
        {
            var create = service.Create(request.nasabahDto);
            return Task.FromResult(create);
        }
    }
}
