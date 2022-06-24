namespace SkinServerNext.Models {
	public struct Hello {
		public Hello() { }
		public DateTime Time { get; } = DateTime.Now;
		public Version Version { get; } = new(0, 1, 0, 0);

		/// <summary>
		/// 标语
		/// </summary>
		public string Slogan { get; init; } = "Next - RedstoneSkin";
	}
}