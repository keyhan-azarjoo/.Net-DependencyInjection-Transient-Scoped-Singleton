# .Net-DependencyInjection-Transient-Scoped-Singleton


In this repository, I examine the differences between Singleton, Scoped, and Transient lifetimes.

### Transient

A new instance of the service is created every time it is injected or accessed via a property. This means that even if you inject it twice into a service, each injection will receive a new instance. However, the downside is that it can lead to increased memory usage since multiple instances of the service are created.

### Scoped

A single instance of the service is created per request. From the beginning of the request to the response, the same instance is used. This is beneficial when you need stateful behavior or when you need to share data within a single request, such as with a UnitOfWork pattern or other similar services. Each request gets its own isolated instance, ensuring no shared state across requests.

### Singleton

A single instance of the service is used for the entire application's lifetime. Every request uses the same instance, which is useful for services that do not need to change throughout the application's lifecycle. A common example is a logging service.

### Tips

- Avoid using services with shorter lifetimes in those with longer lifetimes. For instance, do not use Transient services in Scoped services, or Scoped services in Singleton services, as this can lead to unintended behavior.

