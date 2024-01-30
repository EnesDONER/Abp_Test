using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Books;

[RemoteService(Name = "BookStore")]
[Area("app")]
[ControllerName("Book")]
[Route("api/app/book")]
public class BookController : AbpController, IBookAppService
{
    private readonly IBookAppService _bookAppService;

    public BookController(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }

    [HttpGet]
    [Route("{id}")]
    public Task<BookDto> GetAsync(Guid id)
    {
        return _bookAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return _bookAppService.GetListAsync(input);
    }

    [HttpPost]
    public Task<BookDto> CreateAsync(CreateUpdateBookDto input)
    {
        return _bookAppService.CreateAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    public Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
    {
        return _bookAppService.UpdateAsync(id, input);
    }

    [HttpDelete]
    [Route("{id}")]
    public Task DeleteAsync(Guid id)
    {
        return _bookAppService.DeleteAsync(id);
    }
}