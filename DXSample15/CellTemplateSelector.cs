using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace DXSample15
{
    public class CellTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LinkTemplate { get; set; }

        public override DataTemplate SelectTemplate(Object item, DependencyObject container)
        {
            if (item is GridCellData cell)
            {
                if (cell.Column.FieldName == nameof(Dummy.Link))
                {
                    return LinkTemplate;
                }
            }
            return base.SelectTemplate(item, container);
        }
    }
}