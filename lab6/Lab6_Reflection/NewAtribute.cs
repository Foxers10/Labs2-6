using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
		[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
		public class NewAttribute : Attribute //класс атрибута, унаследованный от System.Attribute
		{
			public NewAttribute() { }
			public NewAttribute(string DescriptionParam)
			{
				Description = DescriptionParam;
			}

			public string Description { get; set; }
		}
}
