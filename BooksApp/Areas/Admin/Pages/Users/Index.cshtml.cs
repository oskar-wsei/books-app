﻿#nullable disable

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksApp.Areas.Admin.Pages.Users;

[Authorize(Roles = "admin")]
public class IndexPage : PageModel
{
    public List<IdentityUser> Users { get; set; }
    
    private readonly UserManager<IdentityUser> _userManager;

    public IndexPage(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }
    
    public void OnGet()
    {
        Users = _userManager.Users.ToList();
    }
}
