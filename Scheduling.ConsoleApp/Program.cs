using Coravel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scheduling.ConsoleApp;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddScheduler();
// builder.Services.AddTransient<MyRepeatableTask>();

var app = builder.Build();

app.Services.UseScheduler(scheduler =>
{
    // scheduler.ScheduleAsync(async () =>
    // {
    //     await Task.Delay(20);
    //     Console.WriteLine("This was scheduled");
    // }).EverySeconds(2);

    // scheduler.Schedule<MyRepeatableTask>()
    //     .EveryFiveSeconds();

    scheduler.ScheduleWithParams<MyRepeatableTask>("localhost:5001")
        .EveryFiveSeconds();
});

app.Run();