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
    
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; }
}