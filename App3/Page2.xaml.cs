using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace App3
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class Page2 : Page
	{
		public Page2()
		{
			this.InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			Debug.WriteLine("Page2:OnNavigatedTo call");
		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			Debug.WriteLine("Page2:OnNavigatingFrom call");
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			Debug.WriteLine("Page2:OnNavigatedFrom call");
		}
	}
}
