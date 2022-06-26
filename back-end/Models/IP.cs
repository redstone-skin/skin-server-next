using System.Net;
using System.Net.Sockets;

namespace SkinServerNext.Models;
public struct IP {
	/// <summary>
	/// 设置 IP 地址
	/// </summary>
	public IPAddress? IPAddress { set => _address = value; }
    
	/// <summary>
	/// 储存 IP 地址的中间变量
	/// </summary>
	private IPAddress? _address = default;

	/// <summary>
	/// 构造函数
	/// </summary>
	/// <param name="address">用于初始化的 IP 地址</param>
	/// <param name="protocol">当前连接使用的协议</param>
	public IP(IPAddress? address, string protocol) {
		_address = address;
		Protocol = protocol;
	}

	/// <summary>
	/// 构造函数
	/// </summary>
	/// <param name="info">当前的 <see cref="IHttpConnectionInfo"/></param>
	public IP(IHttpConnectionInfo info) {
		_address = info.RemoteAddress;
		Protocol = info.Protocol;
	}

	/// <summary>
	/// 读取 IP 地址
	/// </summary>
	public string? Address => _address?.ToString();

	/// <summary>
	/// 读取地址族
	/// </summary>
	public string? Family => _address?.AddressFamily switch {
		AddressFamily.InterNetwork => "IPv4",
		AddressFamily.InterNetworkV6 => "IPv6",
		_ => _address?.AddressFamily.ToString()
	};

	/// <summary>
	/// 当前连接所使用的 HTTP 协议
	/// </summary>
	public string Protocol { get; init; }
}