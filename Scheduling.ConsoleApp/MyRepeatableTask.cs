using Coravel.Invocable;
using Microsoft.Extensions.Logging;

namespace Scheduling.ConsoleApp;

public class MyRepeatableTask : IInvocable
{
    private readonly ILogger<MyRepeatableTask> _logger;
    private readonly string _connectionString;

    public MyRepeatableTask(ILogger<MyRepeatableTask> loger, string connectionString)
    {
        _logger = loger;
        _connectionString = connectionString;
    }

    public async Task Invoke()
    {
        _logger.LogInformation("Hello from invocable, with {string}", _connectionString);
    }
}