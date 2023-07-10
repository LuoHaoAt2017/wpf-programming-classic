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
		public MainWindow()
		{
			InitializeComponent();

			Binding binding1 = new Binding();
			binding1.Source = new List<MobilePhone>()
			{
				new MobilePhone() { Name = "小米", Brand = "xiaomi", Price = 1240.0m },
				new MobilePhone() { Name = "三星", Brand = "samsung", Price = 2800.0m },
				new MobilePhone() { Name = "苹果", Brand = "apple", Price = 6500 }
			};
			binding1.Path = new PropertyPath(".");
			binding1.Mode = BindingMode.OneWay;
			this.phoneList1.SetBinding(ListBox.ItemsSourceProperty, binding1);

			Binding binding2 = new Binding();
			binding2.Source = new List<MobilePhone>()
			{
				new MobilePhone() { Name = "小米", Brand = "xiaomi", Price = 1240.0m },
				new MobilePhone() { Name = "三星", Brand = "samsung", Price = 2800.0m },
				new MobilePhone() { Name = "苹果", Brand = "apple", Price = 6500 }
			};
			binding2.Path = new PropertyPath(".");
			binding2.Mode = BindingMode.OneWay;
			this.phoneList2.SetBinding(ListBox.ItemsSourceProperty, binding2);

			Binding binding3 = new Binding();
			binding3.Source = new List<MobilePhone>()
			{
				new MobilePhone() { Name = "小米", Brand = "xiaomi", Price = 1240.0m },
				new MobilePhone() { Name = "三星", Brand = "samsung", Price = 2800.0m },
				new MobilePhone() { Name = "苹果", Brand = "apple", Price = 6500 }
			};
			binding3.Path = new PropertyPath(".");
			binding3.Mode = BindingMode.OneWay;
			this.phoneList3.SetBinding(ListBox.ItemsSourceProperty, binding3);

			Binding binding4 = new Binding();
			binding4.Source = new List<MobilePhone>()
			{
				new MobilePhone() { Name = "小米", Brand = "xiaomi", Price = 1240.0m },
				new MobilePhone() { Name = "三星", Brand = "samsung", Price = 2800.0m },
				new MobilePhone() { Name = "苹果", Brand = "apple", Price = 6500 }
			};
			binding4.Path = new PropertyPath(".");
			binding4.Mode = BindingMode.OneWay;
			this.phoneList4.SetBinding(ListBox.ItemsSourceProperty, binding4);
		}
	}
}
