using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace EMLib
{
	class CheckedListBoxEditor : UITypeEditor
	{
		// Editstyle des Dialoges festlegen
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if ((context != null) && (provider != null))
			{
				IWindowsFormsEditorService svc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				if (svc != null)
				{
					// eigenen Dialog erzeugen und anzeigen
					// im Beispiel wird im Konstruktor des Dialoges die Referenz der Liste mit übergeben
					FrmCheckedListBox dialog = new FrmCheckedListBox(value as CheckedListBox);

					// Dialog anzeigen und Result abfragen
					if (svc.ShowDialog(dialog) == System.Windows.Forms.DialogResult.OK)
					{
					}
				}
			}
			return value;
		}
	}
}
