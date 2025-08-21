//GraphQL.Server.All

using GraphQL;
using GraphQL.Types;


//Kubernetes

builder.Services.AddSingleton<IKubernetesService, KubernetesService>();
builder.Services.AddSingleton<KubernetesMetricType>();
builder.Services.AddSingleton<KubernetesQuery>();
builder.Services.AddSingleton<ISchema, KubernetesSchema>();

builder.Services.AddGraphQL(b => b
    .AddAutoSchema<EmployeeQuery>()
    .AddSystemTextJson());



app.UseGraphQL<ISchema>("/graphql");
app.UseGraphQLPlayground(
    "/",
    new GraphQL.Server.Ui.Playground.PlaygroundOptions
    {
        GraphQLEndPoint = "/graphql",
        SubscriptionsEndPoint = "/graphql",
    });
