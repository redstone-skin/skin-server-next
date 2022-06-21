using System.Net;
using System.Net.Sockets;

namespace API.Models {
	public struct IP {
		/// <summary>
		/// ���� IP ��ַ
		/// </summary>
		public IPAddress? IPAddress {
			set {
				_address = value;
			}
		}
		/// <summary>
		/// ���� IP ��ַ���м����
		/// </summary>
		private IPAddress? _address = default;

		/// <summary>
		/// �չ��캯��
		/// </summary>
		public IP() {}

		/// <summary>
		/// ��ʼ���м�����Ĺ��캯��
		/// </summary>
		/// <param name="address">���ڳ�ʼ���� IP ��ַ</param>
		public IP(IPAddress? address) => _address = address;

		/// <summary>
		/// ��ȡ IP ��ַ
		/// </summary>
		public string? Address => _address?.ToString();

		/// <summary>
		/// ��ȡ��ַ��
		/// </summary>
		public string? Family => _address?.AddressFamily switch {
			AddressFamily.InterNetwork => "IPv4",
			AddressFamily.InterNetworkV6 => "IPv6",
			_ => _address?.AddressFamily.ToString()
		};
	}
}