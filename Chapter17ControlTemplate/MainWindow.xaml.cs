using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter17ControlTemplate
{
	public partial class MainWindow : Window
	{
		private List<MobilePhone> mobilePhones = new List<MobilePhone>()
		{
			new MobilePhone() { Name = "小米", Brand = "xiaomi", Price = 1240.0m },
			new MobilePhone() { Name = "三星", Brand = "samsung", Price = 2800.0m },
			new MobilePhone() { Name = "苹果", Brand = "apple", Price = 6500 }
		};

		public MainWindow()
		{
			InitializeComponent();
			Binding binding = new Binding();
			binding.Source = this.mobilePhones;
			binding.Path = new PropertyPath(".");
			binding.Mode = BindingMode.OneWay;
			this.phoneList.SetBinding(ListBox.ItemsSourceProperty, binding);

			Binding binding2 = new Binding();
			binding2.Source = new List<MobilePhone>()
		{
			new MobilePhone() { Name = "小米", Brand = "xiaomi", Price = 1240.0m },
			new MobilePhone() { Name = "三星", Brand = "samsung", Price = 2800.0m },
			new MobilePhone() { Name = "苹果", Brand = "apple", Price = 6500 }
		};
			binding2.Path = new PropertyPath(".");
			binding2.Mode = BindingMode.OneWay;
			this.mobileList.SetBinding(ListBox.ItemsSourceProperty, binding2);
		}
	}
}
