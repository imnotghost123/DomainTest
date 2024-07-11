using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TestDomainSingle.V3;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Configuration and initialisation of MediatR
        var serviceProvider = ConfigureServices();
        var mediator = serviceProvider.GetRequiredService<IMediator>();

        // Creation of the command to create a new order
        var createOrderCommand = new CreateOrderCommand
        {
            OrderId = 034059020106036052,
            CustomerName = "Walter Hartwell White",
            OrderDate = DateTime.Now,
            Products = new List<string> { "BlueProduct #1", "BlueProduct #2" }
        };

        // Call the handler for the command to create a new order
        await mediator.Send(createOrderCommand);// [call CreateOrderCommandHandler]

        // Creation of the query for orders from a specific customer
        var getOrdersQuery = new GetOrdersQuery
        {
            CustomerName = "Walter Hartwell White"
        };

        // Call up handler for querying orders from a specific customer
        var orders = await mediator.Send(getOrdersQuery); // [call GetOrdersQueryHandler]

        Console.WriteLine($"Number of orders for {getOrdersQuery.CustomerName}: {orders.Count}");
    }

    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        //Register repositories and handlers
        services.AddTransient<OrderRepository>();
        services.AddTransient<CreateOrderCommandHandler>();
        services.AddTransient<OrderCreatedEventHandler>();
        services.AddTransient<GetOrdersQueryHandler>();

        // Add MediatR
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services.BuildServiceProvider();
    }
}