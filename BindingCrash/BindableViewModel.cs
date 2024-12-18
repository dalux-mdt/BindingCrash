using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace BindingCrash
{
	public abstract class BaseViewModel
	{
		public virtual bool IsVisible => true;
	}
}
