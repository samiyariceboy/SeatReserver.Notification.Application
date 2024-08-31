using MassTransit;
using SeatReserver.Movie.Domain.Events.MovieEvents;

namespace SeatReserver.Notification.Application.Services.MovieApplicationServices.Consumers
{
    public class MovieInfoUpdatedEventHandler : IConsumer<MovieInfoUpdatedEvent>
    {
        public Task Consume(ConsumeContext<MovieInfoUpdatedEvent> context)
        {
            // send sms or email or real-time with Sterategy pattenr Handleing and help from (DI in solid)

            return Task.CompletedTask;
        }
    }
}
