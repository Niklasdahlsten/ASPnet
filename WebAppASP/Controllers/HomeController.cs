using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppASP.Models;

namespace WebAppASP.Controllers;

[Authorize]
public class HomeController(DataContext context) : Controller
{

    private readonly DataContext _context = context;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscribeViewModel model)
    {
        if (ModelState.IsValid)
        {
            var subscriberEntity = new SubscriberEntity
            {
                Email = model.Email,
                DailyNewsLetter = model.DailyNewsletter,
                AdvertisingUpdates = model.AdvertisingUpdates,
                WeekinReview = model.WeekinReview,
                EventUpdates = model.EventUpdates,
                StartupsWeekly = model.StartupsWeekly,
                Podcasts = model.Podcasts
            };
            
            _context.Subscribers.Add(subscriberEntity);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction("Home");
    }
}
