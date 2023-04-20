using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.Repositories;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
	public class ListViewModel : MvxViewModel
	{
		private readonly IWeatherRepository _repository;

		public ListViewModel(IWeatherRepository repository)
		{
            _repository = repository;

            WeatherResults = new MvxObservableCollection<ListResult>();

            FetchResultsCommand = new MvxCommand(() =>
            {
                WeatherResults.Clear();
                LoadWeatherResultTask = MvxNotifyTask.Create(FetchLocationWeather());
                RaisePropertyChanged(() => LoadWeatherResultTask);
            });
        }


        // Properties
        private MvxObservableCollection<ListResult> _weatherResults;
        public MvxObservableCollection<ListResult> WeatherResults
        {
            get
            {
                return _weatherResults;
            }
            set
            {
                _weatherResults = value;
                RaisePropertyChanged(() => WeatherResults);
            }
        }

        private string _searchTerm;
        public string SearchTerm
        {
            get { return _searchTerm; }
            set {
                _searchTerm = value;
                RaisePropertyChanged(() => SearchTerm);
                _enabledSearchButton = _searchTerm.Length > 2;
                RaisePropertyChanged(() => EnabledSearchButton);
            }
        }

        private bool _enabledSearchButton;
        public bool EnabledSearchButton
        {
            get { return _enabledSearchButton; }
            set
            {
                _enabledSearchButton = value;
                FetchResultsCommand.RaiseCanExecuteChanged();
            }
        }

        public MvxNotifyTask LoadWeatherResultTask { get; private set; }


        // Commands
        public IMvxCommand FetchResultsCommand { get; private set; }


        // Methods
        private async Task FetchLocationWeather()
        {
            var result = await _repository.FindWeatherResultsByName(_searchTerm);
            WeatherResults.AddRange(result.ListResults);
        }
    }
}

