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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace App2
{
	public sealed partial class PopupControl : UserControl
	{
		Frame m_frame = null;
		public PopupControl( Frame frame)
		{
			this.InitializeComponent();
			m_frame = frame;
			this.Loaded += (s1, a1) =>
			{
				m_frame.Navigated += M_frame_Navigated;
			};
			this.Unloaded += (s1, a2) =>
			{
				m_frame.Navigated += M_frame_Navigated;
			};
		}

		void M_frame_Navigated(object sender, NavigationEventArgs e)
		{
			lvBack.Items.Clear();
			foreach (PageStackEntry item in m_frame.BackStack)
			{
				lvBack.Items.Add(item.SourcePageType.Name);
			}
			lvForward.Items.Clear();
			foreach (PageStackEntry item in m_frame.ForwardStack)
			{
				lvForward.Items.Add(item.SourcePageType.Name);
			}
		}
	}
}
