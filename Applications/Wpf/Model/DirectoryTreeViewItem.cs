using System;
using System.IO;
using System.Linq;

namespace Wpf.Model
{
    public class DirectoryTreeViewItem : TreeViewDataItem
    {
        public string FilePath { get; private set; }

        public DirectoryTreeViewItem(string path, TreeViewDataItem parent, bool lazyLoadChildren)
        : base(parent, lazyLoadChildren)
        {
            FilePath = path;
            Text = Path.GetFileNameWithoutExtension(FilePath);
            if (string.IsNullOrWhiteSpace(Text))
                Text = FilePath;
        }

        public override void LoadChildren()
        {
            try
            {
                var directory = new DirectoryInfo(FilePath);
                var directories = directory.GetDirectories();
                var folders = directories.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden) && !f.Attributes.HasFlag(FileAttributes.System) && !f.Attributes.HasFlag(FileAttributes.ReadOnly));

                Children.Clear();
                foreach (var folder in folders)
                    Children.Add(new DirectoryTreeViewItem(folder.FullName, this, true));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
