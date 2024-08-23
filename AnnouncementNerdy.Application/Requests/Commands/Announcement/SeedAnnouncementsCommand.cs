using Bogus;
using Microsoft.Extensions.Logging;

namespace AnnouncementNerdy.Application.Requests.Commands.Announcement;

using Repositories;
using Domain.Results;
using AnnouncementNerdy.Domain.Entities.Announcement;


public record SeedAnnouncementsCommand() : IRequest<CommonResult>;

public class SeedAnnouncementsCommandHandler : IRequestHandler<SeedAnnouncementsCommand, CommonResult>
{
    private readonly IAnnouncementRepository _announcementRepository;
    private readonly ILogger<SeedAnnouncementsCommandHandler> _logger;

    public SeedAnnouncementsCommandHandler(IAnnouncementRepository announcementRepository, ILogger<SeedAnnouncementsCommandHandler> logger)
    {
        _announcementRepository = announcementRepository;
        _logger = logger;
    }
    
    public async Task<CommonResult> Handle(SeedAnnouncementsCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var faker = new Faker<Announcement>()
                .CustomInstantiator(f => new Announcement(
                    new string(f.Rant.Review().Take(50).ToArray()),    
                    new string(f.Rant.Review().Take(300).ToArray()) 
                ));
            
           var data = faker.Generate(50);
           foreach (var announcement in data)
           {
               await _announcementRepository.AddAsync(announcement);
           } 

            return Success();
        }
        catch (Exception e)
        {
            _logger.LogError("Something went wrong in {@Handler}, Error:{@Error}", nameof(SeedAnnouncementsCommandHandler), e.Message);
            throw;
        }
        
    }
}
