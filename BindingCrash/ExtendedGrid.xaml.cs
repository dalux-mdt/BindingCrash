using System.Reflection;
using Microsoft.Maui.Controls;

namespace BindingCrash;

public partial class ExtendedGrid : Grid
{
	public ExtendedGrid(string text, bool isVisible)
	{
		InitializeComponent();

		myEntry.Text = text;
		myEntry.IsVisible = isVisible;
	}
}