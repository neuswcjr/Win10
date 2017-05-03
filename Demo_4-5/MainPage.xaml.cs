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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Demo_4_5
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

			//单选模式
			lvHor.SelectionMode = lvVert.SelectionMode = ListViewSelectionMode.Single;
			//列出水平对齐方式
			string[] horalgs = Enum.GetNames(typeof(HorizontalAlignment));
			lvHor.ItemsSource = horalgs;
			lvHor.SelectionChanged += LvHor_SelectionChanged;
			lvHor.SelectedIndex = 0;
			//列出垂直对齐方式
			string[] vertalgs = Enum.GetNames(typeof(VerticalAlignment));
			lvVert.ItemsSource = vertalgs;
			lvVert.SelectionChanged += LvVert_SelectionChanged;
			lvVert.SelectedIndex = 0;
        }

		private void LvHor_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string item = e.AddedItems[0] as string;
			if (!string.IsNullOrEmpty(item))
			{
				HorizontalAlignment horalig = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), item);
				rect.HorizontalAlignment = horalig;
			}
		}

		private void LvVert_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string item = e.AddedItems[0] as string;
			if (!string.IsNullOrEmpty(item))
			{
				VerticalAlignment vertalig = (VerticalAlignment)Enum.Parse(typeof(VerticalAlignment), item);
				rect.VerticalAlignment = vertalig;
			}
		}
	}
}
