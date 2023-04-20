using System;
using Core.Repositories;
using Core.Services;
using Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Core.DI
{
	public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculatorService>();
            Mvx.IoCProvider.RegisterType<INetworkService, NetworkService>();
            Mvx.IoCProvider.RegisterType<IWeatherRepository, WeatherRepository>();
            RegisterAppStart<MainViewModel>();
        }
    }
}

