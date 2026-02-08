namespace Kosci {
	public partial class MainPage : ContentPage {
		private int allRolls = 0;

		public MainPage() {
			InitializeComponent();
		}

		private void RollDice_ButtonClicked(object? sender, EventArgs e) {
			List<Image> images = [Img1, Img2, Img3, Img4, Img5];

			var roll = images.Select(image => {
				var random = new Random().Next(1, 7);
				image.Source = $"k{random}.jpg";
				return random;
			}).GroupBy(x => x).Where(x => x.Count() >= 2).SelectMany(x => x).Sum();
			allRolls += roll;

			CurrentRoll.Text = $"Wynik tego losowania: {roll}";
			AllRolls.Text = $"Wynik gry: {allRolls}";
		}

		private void Reset_ButtonClicked(object? sender, EventArgs e) {
			List<Image> images = [Img1, Img2, Img3, Img4, Img5];

			foreach (var image in images) {
				image.Source = "question.jpg";
			}

			allRolls = 0;
			CurrentRoll.Text = $"Wynik tego losowania: 0";
			AllRolls.Text = $"Wynik gry: 0";
		}
	}
}