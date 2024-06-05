using DependencyInjection_Transient_Scoped_Singleton.Interfaces;

namespace DependencyInjection_Transient_Scoped_Singleton.Services
{
    public class AmazingService : ITransient, IScoped, ISingleton
    {
        private Guid _guid = Guid.NewGuid();

        public Guid Value() => _guid;
    }
}
