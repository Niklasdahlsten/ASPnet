using System.ComponentModel.DataAnnotations;

namespace WebAppASP.Models;

public class SubscribeViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;

    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
