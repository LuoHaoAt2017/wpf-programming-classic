using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Chapter17ControlTemplate
{
    public class MyDataTemplateSelector: DataTemplateSelector
    {
        public DataTemplate? DefaultTemplate { get; set; }

        public DataTemplate? HighlightTemplate { get; set; }

        public string? PropertyToEvaluate { get; set; }

        public string? PropertyValueToHighlight { get; set; }

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
            MobilePhone phone = (MobilePhone)item;
            Type type = phone.GetType();
            PropertyInfo? property = type.GetProperty(PropertyToEvaluate);
            if (property != null && property.GetValue(phone, null)?.ToString() == PropertyValueToHighlight)
            {
				return HighlightTemplate;
			}
            else
            {
                return DefaultTemplate;
            }
		}
	}
}
