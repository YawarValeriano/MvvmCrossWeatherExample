using System;
using System.Globalization;
using Core.Messages;
using Core.Models;
using MvvmCross.Converters;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
	public class DetailViewModel : MvxViewModel
	{
        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChanged(() => ImageUrl);
            }
        }

        private ListResult _selectedWeatherResult;
        public ListResult SelectedWeatherResult
        {
            get => _selectedWeatherResult;
            set
            {
                _selectedWeatherResult = value;
                RaisePropertyChanged(() => SelectedWeatherResult);
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                RaisePropertyChanged(() => IsLoading);
            }
        }


        private MvxSubscriptionToken _token;

		public DetailViewModel(IMvxMessenger messenger)
		{
            _token = messenger.Subscribe<SearchMessage>(OnSearchMessage);
            IsLoading = true;
            RaisePropertyChanged(() => IsLoading);
        }

        private void OnSearchMessage(SearchMessage obj)
        {
            SelectedWeatherResult = obj.Result;

            ImageUrl = ConvertToURL(SelectedWeatherResult.Weather[0].Icon);

            IsLoading = false;
        }

        private string ConvertToURL(string value)
        {
            return $"http://openweathermap.org/img/wn/{value}@4x.png";
        }
    }
}

