using Acme.BookStore.Authors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Authors;

[RemoteService(Name = "BookStore")]
[Area("app")]
[ControllerName("Author")]
[Route("api/app/author")]
public class AuthorController:AbpController,IAuthorAppService
{
    private readonly IAuthorAppService _authorAppService;

    public AuthorController(IAuthorAppService authorAppService)
    {
        _authorAppService = authorAppService;
    }

    [HttpGet]
    [Route("{id}")]
    public Task<AuthorDto> GetAsync(Guid id)
    {
        return _authorAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input)
    {
        return _authorAppService.GetListAsync(input);
    }

    [HttpPost]
    public Task<AuthorDto> CreateAsync(CreateAuthorDto input)
    {
        return _authorAppService.CreateAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    public Task UpdateAsync(Guid id, UpdateAuthorDto input)
    {
        return _authorAppService.UpdateAsync(id, input);
    }

    [HttpDelete]
    [Route("{id}")]
    public Task DeleteAsync(Guid id)
    {
        return _authorAppService.DeleteAsync(id);
    }


}
