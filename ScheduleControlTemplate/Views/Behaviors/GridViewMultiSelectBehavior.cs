using Microsoft.Xaml.Behaviors;
using System.Collections;
using System.Collections.Specialized;
using System.Windows;
using Telerik.Windows.Controls;

namespace ScheduleControlTemplate.Views.Behaviors
{
    public class GridViewMultiSelectBehavior : Behavior<RadGridView>
    {
        private bool collectionChangedSuspended;

        /// <summary>
        /// Called after the behavior is attached to an AssociatedObject.
        /// </summary>
        /// <remarks>
        /// Override this to hook up functionality to the AssociatedObject.
        /// </remarks>
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.SelectedItems.CollectionChanged += GridSelectedItemsCollectionChanged;
        }

        /// <summary>
        /// Getter/Setter for DependencyProperty, bound to the DataContext's SelectedItems ObservableCollection
        /// </summary>
        public INotifyCollectionChanged SelectedItems
        {
            get => (INotifyCollectionChanged)GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }

        /// <summary>
        /// Dependency Property "SelectedItems" is target of binding to DataContext's SelectedItems
        /// </summary>
        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register("SelectedItems", typeof(INotifyCollectionChanged), typeof(GridViewMultiSelectBehavior), new PropertyMetadata(OnSelectedItemsPropertyChanged));

        /// <summary>
        /// PropertyChanged handler for DependencyProperty "SelectedItems"
        /// </summary>
        private static void OnSelectedItemsPropertyChanged(DependencyObject target, DependencyPropertyChangedEventArgs args)
        {
            if (args.NewValue is INotifyCollectionChanged collection)
            {
                collection.CollectionChanged += ((GridViewMultiSelectBehavior)target).ContextSelectedItemsCollectionChanged;
            }
        }

        /// <summary>
        /// Will be called, when the Network's SelectedItems collection changes
        /// </summary>
        private void ContextSelectedItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (collectionChangedSuspended)
            {
                return;
            }

            collectionChangedSuspended = true;

            if (e.NewItems != null)
            {
                foreach (object item in e.NewItems)
                {
                    AssociatedObject.SelectedItems?.Add(item);
                }
            }

            if (e.OldItems != null)
            {
                foreach (object item in e.OldItems)
                {
                    AssociatedObject.SelectedItems?.Remove(item);
                }
            }

            collectionChangedSuspended = false;
        }

        /// <summary>
        /// Will be called when the GridView's SelectedItems collection changes
        /// </summary>
        private void GridSelectedItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (collectionChangedSuspended)
            {
                return;
            }

            collectionChangedSuspended = true;

            if (e.NewItems != null)
            {
                foreach (object item in e.NewItems)
                {
                    ((IList)SelectedItems)?.Add(item);
                }
            }

            if (e.OldItems != null)
            {
                foreach (object item in e.OldItems)
                {
                    ((IList)SelectedItems)?.Remove(item);
                }
            }

            collectionChangedSuspended = false;
        }
    }
}
