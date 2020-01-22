using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteMVC
{
	[ToolboxData("<{0}:CSSMenu runat=server></{0}:CSSMenu>")]
	public class CSSMenu : Menu
	{
		
		protected override void Render(HtmlTextWriter writer)
		{
			this.PerformDataBinding();

			writer.Write(string.Format("<div id=\"{0}\" class=\"{1}\">", base.ClientID, base.CssClass));
			writer.WriteLine();
			writer.WriteLine("<ul class=\"level1\">");

			foreach (MenuItem item in Items)
			{
				WriteItem(writer, item, 1);
			}

			writer.WriteLine("</ul>");
			writer.WriteLine("</div>");
		}

		private void WriteItem(HtmlTextWriter writer, MenuItem item, int level)
		{
			writer.WriteLine("<li>");

			string title = "";
			var userClass = "";
			if (!string.IsNullOrEmpty(item.ToolTip))
			{
				var data = item.ToolTip.Split(';');
				title = string.Format(" title=\"{0}\"", data[0].Trim());
				if (data.Length > 1)
				{
					userClass = " " + data[1].Trim();
				}
			}
			var cssClass = string.Format("class = \"popout level{0}{1}\"", level, userClass);

			writer.WriteLine(string.Format("<a {0} href=\"{1}\"{2}>{3}</a>", cssClass, item.NavigateUrl, title, item.Text));

			if (item.ChildItems.Count > 0)
			{
				writer.WriteLine(string.Format("<ul class=\"level{0}\">", level + 1));
				foreach (MenuItem child in item.ChildItems)
				{
					WriteItem(writer, child, level + 1);
				}
				writer.WriteLine("</ul>");
			}

			writer.WriteLine("</li>");
		}
	}

}
