using System;
using System.Windows;
using System.Windows.Controls;

namespace ScheduleControlTemplate.Views
{
    public class RowNumberColumn : Telerik.Windows.Controls.GridViewColumn
    {
        public override FrameworkElement CreateCellElement(Telerik.Windows.Controls.GridView.GridViewCell cell, object dataItem)
        {
            TextBlock textBlock = cell.Content as TextBlock;

            if (textBlock == null)
            {
                textBlock = new TextBlock();
            }

            textBlock.Text = $"{DataControl.Items.IndexOf(dataItem) + 1:000}";

            return textBlock;
        }

        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);

            if (args.PropertyName == nameof(DataControl))
            {
                if (DataControl != null && DataControl.Items != null)
                {
                    DataControl.Items.CollectionChanged += (s, e) =>
                    {
                        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                        {
                            Refresh();
                        }
                    };
                }
            }
        }
    }
}
