using AnnouncementNerdy.Domain.Entities.Base;

namespace AnnouncementNerdy.Domain.Entities.Announcement;

public class Announcement : Entity
{
    private Announcement() => CreatedDate = DateTime.UtcNow;

    public Announcement(string title, string description): this()
    {
        Title = title;
        Description = description;
    }
    
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime CreatedDate { get; }
}