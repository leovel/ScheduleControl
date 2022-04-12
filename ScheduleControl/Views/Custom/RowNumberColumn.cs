using System;
using System.Windows;
using System.Windows.Controls;

namespace ScheduleControl.Views
{
    public class RowNumberColumn : Telerik.Windows.Controls.GridViewColumn
    {
        public override FrameworkElement CreateCellElement(Telerik.Windows.Controls.GridView.GridViewCell cell, object dataItem)
        {
            if (!(cell.Content is TextBlock textBlock))
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
