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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace App2
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class Page_C : Page
	{
		public Page_C()
		{
			this.InitializeComponent();
		}
		private void OnBack(object sender, RoutedEventArgs e)
		{
			if (this.Frame.CanGoBack)
			{
				this.Frame.GoBack();
			}
		}

		private void OnForward(object sender, RoutedEventArgs e)
		{
			if (this.Frame.CanGoForward)
			{
				this.Frame.GoForward();
			}
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			//跳过b
			var r = Frame.BackStack.FirstOrDefault(p => p.SourcePageType == typeof(Page_B));
			if (r != null)
			{
				Frame.BackStack.Remove(r);
			}
			

			this.tbInfo.Text = "导航模式： " + e.NavigationMode.ToString();
		}
	}
}
