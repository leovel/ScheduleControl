﻿using System.Collections.ObjectModel;

namespace ScheduleControl.ViewModels
{
    public class ToolBarModel
    {
        public ToolBarModel()
        {
            ToolBarItemModels = new ObservableCollection<ToolBarItemModelBase>();
        }

        public ObservableCollection<ToolBarItemModelBase> ToolBarItemModels { get; set; }

        public int Band { get; set; }

        public int BandIndex { get; set; }
    }
}
