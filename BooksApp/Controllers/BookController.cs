﻿using BooksApp.Contracts;
using BooksApp.Models;
using BooksApp.Resolvers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BooksApp.Controllers;

[Authorize(Roles = "admin")]
public class BookController : Controller
{
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;

    public BookController(IBookService bookService, IAuthorService authorService)
    {
        _bookService = bookService;
        _authorService = authorService;
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View(_bookService.FindAll(new BookResolver { IncludeAuthor = true }));
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult PagedIndex([FromQuery] int page = 1, [FromQuery] int size = 2)
    {
        return View(_bookService.FindPage(page, size, new BookResolver { IncludeAuthor = true }));
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(ApplyBookAuthorsSelectListItems(new Book()));
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
        if (!ModelState.IsValid) return View(ApplyBookAuthorsSelectListItems(book));
        _bookService.Add(book);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult CreateApi()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult CreateApi(Book book)
    {
        if (!ModelState.IsValid) return View();
        _bookService.Add(book);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Details(int id)
    {
        var book = _bookService.FindById(id, new BookResolver { IncludeAuthor = true, IncludePublisher = true });
        if (book == null) return RedirectToAction("Index");
        return View(book);
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        var book = _bookService.FindById(id);
        if (book == null) return RedirectToAction("Index");
        return View(ApplyBookAuthorsSelectListItems(book));
    }

    [HttpPost]
    public IActionResult Update(Book book)
    {
        if (!book.Id.HasValue) return RedirectToAction("Index");
        _bookService.Update(book);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _bookService.Delete(id);
        return RedirectToAction("Index");
    }

    private Book ApplyBookAuthorsSelectListItems(Book book)
    {
        book.Authors = _authorService.FindAll().Select(author => new SelectListItem
        {
            Value = author.Id.ToString(),
            Text = author.FullName,
            Selected = book.AuthorId == author.Id
        }).ToList();

        return book;
    }
}