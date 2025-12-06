using Canalog.Application.Dtos;
using Canalog.Application.Interfaces;
using Canalog.Domain.Models;

namespace Canalog.Application.Services;

public class OptionsService(IOptionsRepository optRepo) : IOptionsService
{
    private readonly IOptionsRepository _optRepo = optRepo;

    public Task<OptionsDto> GetUserOptionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync()
    {
        throw new NotImplementedException();
    }

}
