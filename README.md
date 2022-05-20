# Attempt to get a property of a reference nullable


server-dotnet
1. `mkdir server-dotnet`  
   `cd server-dotnet`
1. `dotnet new webapi`  
   `dotnet new gitignore`
2. remove Controllers/WeatherForecastController.cs  
   remove WeatherForecast.cs
3. create Controllers/PersonsController.cs  
   create Model/Person.cs  
   create Model/Address.cs
4. change Program.cs:
    ```
    builder.Services.AddSwaggerGen(c =>
    {
        // add these two configuration method calls
        c.SupportNonNullableReferenceTypes();
        c.UseAllOfToExtendReferenceSchemas();
    });
    ```

client-angular
1. `ng new client-angular --routing --style=css`
2. `cd client-angular`
3. `ng build`

2. Download swagger.json from https://localhost:7114/swagger/v1/swagger.json into client-angular/.
3. `openapi-generator-cli generate -g typescript-angular -i swagger.json -o ./src/app/person-api --skip-validate-spec --additional-properties=apiModulePrefix=Person,stringEnums=true`