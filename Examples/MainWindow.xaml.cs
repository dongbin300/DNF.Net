using DNF.Net.Applications;
using DNF.Net.Enums;

using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Examples
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		DnfApplication? app = null;

		public MainWindow()
		{
			InitializeComponent();

			ApiComboBox.SelectedIndex = 0;
		}

		private void RequestButton_Click(object sender, RoutedEventArgs e)
		{
			app ??= new DnfApplication(ApikeyTextBox.Text);

			switch (ApiComboBox.SelectedIndex)
			{
				case 0:
					switch (ApiDetailComboBox.SelectedIndex)
					{
						case 0:
							var result1 = app.ServersApi.GetServerInfoAsync();
							result1.Wait();
							ResultTextBox.Text = string.Join(Environment.NewLine, result1.Result.rows.Select(x => x.serverId + "," + x.serverName));
							break;
						case 1:
							var parameters2 = ParametersTextBox.Text.Split(',');
							var result2 = app.ServersApi.GetCharacterInfoAsync((DnfServer)Enum.Parse(typeof(DnfServer), parameters2[0]), parameters2[1]);
							result2.Wait();
							ResultTextBox.Text = string.Join(Environment.NewLine, result2.Result.rows.Select(x => string.Join(',', x.serverId, x.characterName, x.characterId, x.jobName, x.jobGrowName, x.level)));
							break;
						case 2:
							var parameters3 = ParametersTextBox.Text.Split(',');
							var result3 = app.ServersApi.GetCharacterBasicInfoAsync((DnfServer)Enum.Parse(typeof(DnfServer), parameters3[0]), parameters3[1]);
							result3.Wait();
							var x3 = result3.Result;
							ResultTextBox.Text = string.Join(Environment.NewLine, x3.characterName, x3.characterId, x3.jobName, x3.jobGrowName, x3.adventureName, x3.guildName, x3.level);
							break;
					}
					break;
				case 1:
					switch (ApiDetailComboBox.SelectedIndex)
					{
						case 0:
							var parameters1 = ParametersTextBox.Text.Split(',');
							var result1 = app.ImageApi.GetCharacterImageAsync((DnfServer)Enum.Parse(typeof(DnfServer), parameters1[0]), parameters1[1]);
							result1.Wait();
							ImageView.Source = LoadImage(result1.Result);
							break;
						case 1:
							var result2 = app.ImageApi.GetItemImageAsync(ParametersTextBox.Text);
							result2.Wait();
							ImageView.Source = LoadImage(result2.Result);
							break;
					}
					break;
			}
		}

		private void ApiComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ApiDetailComboBox.Items.Clear();
			switch (ApiComboBox.SelectedIndex)
			{
				case 0:
					ApiDetailComboBox.Items.Add("서버 목록");
					ApiDetailComboBox.Items.Add("캐릭터 검색");
					ApiDetailComboBox.Items.Add("캐릭터 기본 정보 조회");
					ApiDetailComboBox.SelectedIndex = 0;
					break;
				case 1:
					ApiDetailComboBox.Items.Add("캐릭터 이미지");
					ApiDetailComboBox.Items.Add("아이템 이미지");
					ApiDetailComboBox.SelectedIndex = 0;
					break;
			}
		}

		private BitmapImage LoadImage(byte[] imageData)
		{
			if (imageData == null || imageData.Length == 0)
			{
				throw new NullReferenceException(nameof(imageData));
			}

			var image = new BitmapImage();
			using (var mem = new MemoryStream(imageData))
			{
				mem.Position = 0;
				image.BeginInit();
				image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
				image.CacheOption = BitmapCacheOption.OnLoad;
				image.UriSource = null;
				image.StreamSource = mem;
				image.EndInit();
			}
			image.Freeze();
			return image;
		}
	}
}
