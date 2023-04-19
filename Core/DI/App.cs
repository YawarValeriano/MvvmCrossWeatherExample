using System;
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

            RegisterAppStart<MainViewModel>();
        }
    }
}

