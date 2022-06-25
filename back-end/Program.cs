var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer()
	.AddHttpContextAccessor()
	.AddScoped<IHttpConnectionInfo, SkinServerNext.Services.HttpConnectionInfo>()
	.AddScoped<IHttp304, SkinServerNext.Services.Http304>()
	.AddSwaggerGen()
	.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();