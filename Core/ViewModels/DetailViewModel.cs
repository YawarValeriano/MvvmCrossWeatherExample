using System;
using System.Globalization;
using Core.Models;
using MvvmCross.Converters;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
	public class DetailViewModel : MvxViewModel<ListResult>
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


		public DetailViewModel()
		{
		}

        public override void Prepare(ListResult parameter)
        {
            _selectedWeatherResult = parameter;
            _imageUrl = ConvertToURL(parameter.Weather[0].Icon);

        }

        private string ConvertToURL(string value)
        {
            return $"https://openweathermap.org/img/wn/{value}@4x.png";
        }
    }
}

