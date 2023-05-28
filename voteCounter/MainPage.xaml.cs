using System.Diagnostics.Metrics;

namespace voteCounter;

public partial class MainPage : ContentPage
{
	int counter1,counter2 = 0;
    

	public MainPage()
	{
		InitializeComponent();
	}

    private void AddButton1_Clicked(object sender, EventArgs e)
    {
        counter1++;
        countLabel1.Text = counter1.ToString();
    }

    private void MinusButton1_Clicked(object sender, EventArgs e)
    {
        if (counter1 > 0)
        {
            counter1--;
            countLabel1.Text = counter1.ToString();
        }
    }
    private void AddButton2_Clicked(object sender, EventArgs e)
    {
        counter2++;
        countLabel2.Text = counter2.ToString();
    }

    private void MinusButton2_Clicked(object sender, EventArgs e)
    {
        if (counter2 > 0)
        {
            counter2--;
            countLabel2.Text = counter2.ToString();
        }
    }
    private async void ClearButton_Clicked(object sender, EventArgs e)
    {
        bool result= await DisplayAlert("UYARI", "Sayacı sıfırlamak istediğinize emin misiniz?", "Evet", "Hayır");

        if (result)
        {
            counter1 = 0;
            counter2 = 0;
            countLabel1.Text = counter1.ToString();
            countLabel2.Text = counter2.ToString();
        }
        return;
    }
}


