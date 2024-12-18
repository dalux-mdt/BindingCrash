using System.Reflection;

namespace BindingCrash;

public partial class CrashingPage
{
	public CrashingPage()
	{
		InitializeComponent();

		InitializeUi();
	}

	private void InitializeUi()
	{
		var viewModel = new CrashingPageViewModel();
		BindingContext = viewModel;

		var visibleBindingPropertyInfo = BindingContext.GetType().GetTypeInfo().GetRuntimeProperty(nameof(viewModel.IsVisible));

		bool isVisible = false;

		if (visibleBindingPropertyInfo != null)
			isVisible = (bool)visibleBindingPropertyInfo.GetValue(BindingContext);

		var grid = new ExtendedGrid(viewModel.Text, isVisible);
		Content = grid;
	}
}

public class CrashingPageViewModel : BaseViewModel
{
	public string Text { get; set; }
	public override bool IsVisible => true;

	public CrashingPageViewModel()
	{
		Text = "Hello, World!";
	}
}