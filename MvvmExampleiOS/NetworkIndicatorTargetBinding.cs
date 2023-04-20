﻿using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using System.Collections.Generic;
using UIKit;
using System.Linq;

namespace MvvmExampleiOS
{
	public class NetworkIndicatorTargetBinding : MvxTargetBinding
    {
        private static List<NetworkIndicatorTargetBinding> CurrentBindings;

        public NetworkIndicatorTargetBinding(object target)
            : base(target)
        {
        }

        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        public override Type TargetType => typeof(UIViewController);

        public override void SetValue(object value)
        {
            var visible = (bool)value;

            if (CurrentBindings == null)
                CurrentBindings = new List<NetworkIndicatorTargetBinding>();

            if (visible)
            {
                CurrentBindings.Add(this);
                UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
            }
            else
            {
                if (CurrentBindings.Contains(this))
                    CurrentBindings.Remove(this);

                if (!CurrentBindings.Any())
                {
                    UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
                    CurrentBindings = null;
                }
            }
        }
    }
}

