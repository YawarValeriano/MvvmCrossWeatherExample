using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Messages;
using Core.Models;
using Core.Repositories;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
	public class ListViewModel : MvxViewModel
	{
		private readonly IWeatherRepository _repository;
        private readonly IMvxNavigationService _navigationService;
        private readonly IMvxMessenger _messenger;

        public ListViewModel(IWeatherRepository repository, IMvxNavigationService navigationService, IMvxMessenger messenger)
		{
            _repository = repository;
            _navigationService = navigationService;
            _messenger = messenger;

            WeatherResults = new MvxObservableCollection<ListResult>();

            FetchResultsCommand = new MvxCommand(() =>
            {
                WeatherResults.Clear();
                LoadWeatherResultTask = MvxNotifyTask.Create(FetchLocationWeather());
                RaisePropertyChanged(() => LoadWeatherResultTask);
            });

            ResultSelectedCommand = new MvxAsyncCommand<ListResult>(ShowWeatherResultAsync);

        }

        // Properties
        private MvxObservableCollection<ListResult> _weatherResults;
        public MvxObservableCollection<ListResult> WeatherResults
        {
            get => _weatherResults;
            set
            {
                _weatherResults = value;
                RaisePropertyChanged(() => WeatherResults);
            }
        }

        private string _searchTerm;
        public string SearchTerm
        {
            get => _searchTerm;
            set {
                _searchTerm = value;
                RaisePropertyChanged(() => SearchTerm);
                EnabledSearchButton = _searchTerm.Length > 2;
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
        public IMvxCommand<ListResult> ResultSelectedCommand { get; private set; }


        // Methods
        private async Task FetchLocationWeather()
        {
            var result = await _repository.FindWeatherResultsByName(SearchTerm);
            WeatherResults.AddRange(result.ListResults);
        }

        private async Task ShowWeatherResultAsync(ListResult selectedResult)
        {
            await _navigationService.Navigate<DetailViewModel>();
            var result = await _repository.FindWeatherById(selectedResult.Id);
            var message = new SearchMessage(this, result);
            _messenger.Publish(message);
        }
    }
}

