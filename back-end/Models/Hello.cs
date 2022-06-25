namespace SkinServerNext.Models;
public struct Hello {
	public Hello(HttpContext context) => IP = new(context.Connection.RemoteIpAddress, context.Request.Protocol);
	public Hello(IHttpConnectionInfo info) => IP = new(info);

	public DateTime Time { get; } = DateTime.Now;
	public Version Version { get; } = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!;
	public string Slogan { get; init; } = "";
	public IP IP { get; init; }
}