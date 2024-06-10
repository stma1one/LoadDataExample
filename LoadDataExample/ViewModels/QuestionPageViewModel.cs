using LoadDataExample.Models;
using LoadDataExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoadDataExample.ViewModels
{
    public class QuestionPageViewModel:ViewModel
    {
        private readonly TriviaService service;
        private Question randomQuestion;
        private bool isRefreshing;
        string errorMessage;

        public string ErrorMessage { get => errorMessage; set { errorMessage = value; OnPropertyChange(); } }
        public bool IsRefreshing { get => isRefreshing; set { isRefreshing = value; OnPropertyChange(); } }
        public Question RandomQuestion { get => randomQuestion; set { randomQuestion = value; OnPropertyChange(); } }
        public ICommand RefreshCommand {  get; protected set; }
        public   QuestionPageViewModel( TriviaService service) 
        {
            IsRefreshing = true ;
            this.service=service;
          LoadQuestion().Awaiter(HandleSuccess,HandleError);
           RefreshCommand = new Command(async () => await Refresh());
            IsRefreshing = false;

        }

        private void HandleError(Exception exception)
        {
            ErrorMessage= exception.Message;
        }

        private void HandleSuccess()
        {
            Shell.Current.DisplayAlert("הכל עודכן", "הכל בסדר", "אישור");
        }

        public async Task LoadQuestion()
        {
            
                RandomQuestion = await service.GetQuestion();
        }
        public async Task Refresh()
        {
            IsRefreshing = true;
            try
            {
                await LoadQuestion();
            }
            catch (Exception ex) 
            {
                HandleError(ex);
            }
            IsRefreshing = false;
        }

        
    }
}
