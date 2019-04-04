using System.Collections.ObjectModel;
using Wpf.Helpers;

namespace Wpf.Model
{
    public class TreeViewDataItem : ObservableBase
    {
        private readonly TreeViewDataItem _parent;

        private static TreeViewDataItem _dummyChild;
        private static TreeViewDataItem DummyChild => _dummyChild = new TreeViewDataItem(null, false);

        public TreeViewDataItem(TreeViewDataItem parent, bool lazyLoadChildren)
        {
            _parent = parent;

            if (lazyLoadChildren)
                Children.Add(DummyChild);
        }

        public string Text { get; set; }



        private ObservableCollection<TreeViewDataItem> _children;
        public ObservableCollection<TreeViewDataItem> Children => _children ?? (_children = new ObservableCollection<TreeViewDataItem>());

        public virtual void LoadChildren()
        {
        }

        private bool? _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded.GetValueOrDefault();
            set
            {
                if (value && _parent != null)
                    _parent.IsExpanded = true;

                if (!_isExpanded.HasValue)
                {
                    Children.Remove(DummyChild);
                    LoadChildren();
                }

                _isExpanded = value;
                OnPropertyChanged(nameof(IsExpanded));
            }
        }
    }
}