using LoadDataExample.ViewModels;

namespace LoadDataExample.Views;

public partial class QuestionPage : ContentPage
{
	public QuestionPage(QuestionPageViewModel vm)
	{
		this.BindingContext= vm;	
		InitializeComponent();
	}

    ////כשחשוב לרפרש את הנתונים בכל כניסה למסך
    //protected override async void OnAppearing()
    //{
    //    base.OnAppearing();
    //    try
    //    {
    //        QuestionPageViewModel vm = (QuestionPageViewModel)BindingContext;
    //        await vm.LoadQuestion();
    //    }
    //    catch (Exception ex) { }
    //}
}