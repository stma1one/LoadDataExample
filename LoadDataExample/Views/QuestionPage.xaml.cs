using LoadDataExample.ViewModels;

namespace LoadDataExample.Views;

public partial class QuestionPage : ContentPage
{
	public QuestionPage(QuestionPageViewModel vm)
	{
		this.BindingContext= vm;	
		InitializeComponent();
	}
}