### AutoMapping

https://doc.mapeditor.org/en/stable/manual/automapping/

API Nuget Package (IMapper mapper)

```Bash
> dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```

```csharp
//builder.Services.AddAutoMapper(typeof(Program).Assembly);

 public static void RegisterAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
    }
```

Project
```Bash
> dotnet add package AutoMapper
```
