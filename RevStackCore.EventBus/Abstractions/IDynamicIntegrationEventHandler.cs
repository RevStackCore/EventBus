using System.Threading.Tasks;

namespace RevStackCore.EventBus
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
