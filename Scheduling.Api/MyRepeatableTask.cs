using Coravel.Invocable;
using Microsoft.Extensions.Logging;

namespace Scheduling.Api;

public class MyRepeatableTask : IInvocable
{
    private readonly ILogger<MyRepeatableTask> _logger;

    public MyRepeatableTask(ILogger<MyRepeatableTask> loger)
    {
        _logger = loger;
    }

    public async Task Invoke()
    {
        _logger.LogInformation("Hello from invocable");
    }
}