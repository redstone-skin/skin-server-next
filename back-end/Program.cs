var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer()
	.AddHttpContextAccessor()
	.AddScoped<IHttpConnectionInfo, SkinServerNext.Services.HttpConnectionInfo>()
	.AddScoped<IHttp304, SkinServerNext.Services.Http304>()
	.AddSwaggerGen()
	.AddResponseCaching()
	.AddControllers(options => {
		options.CacheProfiles.Add("Private30d", new() { Duration = 2592000, Location = ResponseCacheLocation.Client });
		options.CacheProfiles.Add("Public30d", new() { Duration = 2592000, Location = ResponseCacheLocation.Any });
		options.CacheProfiles.Add("Private1d", new() { Duration = 86400, Location = ResponseCacheLocation.Client });
		options.CacheProfiles.Add("Public1d", new() { Duration = 86400, Location = ResponseCacheLocation.Any });
		options.CacheProfiles.Add("Private1h", new() { Duration = 3600, Location = ResponseCacheLocation.Client });
		options.CacheProfiles.Add("Public1h", new() { Duration = 3600, Location = ResponseCacheLocation.Any });
		options.CacheProfiles.Add("Private10m", new() { Duration = 600, Location = ResponseCacheLocation.Client });
		options.CacheProfiles.Add("Private5m", new() { Duration = 300, Location = ResponseCacheLocation.Client });
		options.CacheProfiles.Add("Private1m", new() { Duration = 60, Location = ResponseCacheLocation.Client });
		options.CacheProfiles.Add("NoCache", new() { Duration = 0, Location = ResponseCacheLocation.None });
	});

builder.Services.AddHttpClient("Timeout5s", client => {
	client.Timeout = new(0, 0, 5);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions {
	OnPrepareResponse = context => context.Context.Response.Headers.Add("Cache-Control", "public,max-age=864000") // 十天
});

app.UseAuthorization();

app.MapControllers();

app.UseResponseCaching();

app.Run();