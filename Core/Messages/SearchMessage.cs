using System;
using Core.Models;
using MvvmCross.Plugin.Messenger;

namespace Core.Messages
{
	public class SearchMessage : MvxMessage
    {
		public ListResult Result
		{
            get;
            private set;
        }
		public SearchMessage(object sender, ListResult result) : base(sender)
		{
			Result = result;
		}
	}
}

