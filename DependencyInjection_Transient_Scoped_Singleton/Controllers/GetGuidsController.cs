using DependencyInjection_Transient_Scoped_Singleton.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection_Transient_Scoped_Singleton.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetGuidsController : ControllerBase
    {
        //private readonly ISingleton _singletonService;
        //private readonly IScoped _scopedService1;
        //private readonly IScoped _scopedService2;
        //private readonly ITransient _transientService1;
        //private readonly ITransient _transientService2;


        // you can inject your classes here or in controller
        //public GetGuidsController(ISingleton singletonService, IScoped scopedService1, IScoped scopedService2, ITransient TransientService1,
        //    ITransient TransientService2)
        //{
        //    _singletonService = singletonService;
        //    _scopedService1 = scopedService1;
        //    _scopedService2 = scopedService2;
        //    _transientService1 = TransientService1;
        //    _transientService2 = TransientService2;
        //}

        [HttpGet(Name = "GetAllGuids")]
        public object Get(ISingleton singletonService, IScoped scopedService1, IScoped scopedService2, ITransient TransientService1,
            ITransient TransientService2)
        {
            var myData = new
            {
                mySingletonServise = singletonService.Value(),
                myScopedService1 = scopedService1.Value(),
                myScopedService2 = scopedService2.Value(),
                myTransientService1 = TransientService1.Value(),
                myTransientService2 = TransientService2.Value()

            };
            //var myData2 = new
            //{
            //    mySingletonServise = _singletonService.Value(),
            //    myScopedService1 = _scopedService1.Value(),
            //    myScopedService2 = _scopedService2.Value(),
            //    myTransientService1 = _transientService1.Value(),
            //    myTransientService2 = _transientService2.Value()

            //};

            return myData;

        }
    }
}
