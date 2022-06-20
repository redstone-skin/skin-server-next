namespace SkinServerNext.Models {
	public class Hello {
		public DateTime Time { get; } = DateTime.Now;
		public Version Version { get; } = new(0, 1, 0, 0);
		public string Text { get; init; } = "Next - RedstoneSkin";
	}
}