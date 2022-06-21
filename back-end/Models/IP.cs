using System.Net;
using System.Net.Sockets;

namespace API.Models {
	public struct IP {
		/// <summary>
		/// 设置 IP 地址
		/// </summary>
		public IPAddress? IPAddress {
			set {
				_address = value;
			}
		}
		/// <summary>
		/// 储存 IP 地址的中间变量
		/// </summary>
		private IPAddress? _address = default;

		/// <summary>
		/// 空构造函数
		/// </summary>
		public IP() {}

		/// <summary>
		/// 初始化中间变量的构造函数
		/// </summary>
		/// <param name="address">用于初始化的 IP 地址</param>
		public IP(IPAddress? address) => _address = address;

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
	}
}