using Newtonsoft.Json;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public string APIKey = "17a5aa903ce94521806130915240910";

    public NewPage1()
	{
		InitializeComponent();
	}

	private Response MakeCall(string city = "London")
	{
		string url = $"https://api.weatherapi.com/v1/current.json?key={this.APIKey}&q={city}&aqi=no";
		HttpClient client = new HttpClient();
		var response = client.GetAsync(url).Result;
		if (response.StatusCode != System.Net.HttpStatusCode.OK)
		{
			DisplayAlert("Error", "ApiError", "123");
			return null;
		}
		Response result = JsonConvert.DeserializeObject<Response>(response.Content.ReadAsStringAsync().Result);
		return result;


	}

	


    private void btn2_Clicked(object sender, EventArgs e)
    {
		try
		{
            var response = MakeCall($"{ebox.Text}");
            tempC.Text =  $"����������� �������: {response.Current.TempC}";
            tempF.Text = $"����������� �� ����������: {response.Current.TempF}";
			wightDirection.Text = $"����������� �����: {response.Current.WindDir}";
			pressure.Text = $"�������� ��. ��. ��.: {response.Current.PressureMb}";
			speedWind.Text = $"�������� �����: {response.Current.WindKph} �/�";
			Humid.Text = $"���������: {response.Current.Humidity} ������";
			
        }
		catch(Exception ex)
		{
			DisplayAlert("Error", $"{ex}", "OK");
		}
		


		//DisplayAlert("Success", $"{response.Current.TempC}", "OK");

    }
}