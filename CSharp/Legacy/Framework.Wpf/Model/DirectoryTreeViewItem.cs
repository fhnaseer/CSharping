using System;
using System.IO;
using System.Linq;

namespace Framework.Wpf.Model
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
                DirectoryInfo directory = new DirectoryInfo(FilePath);
                DirectoryInfo[] directories = directory.GetDirectories();
                System.Collections.Generic.IEnumerable<DirectoryInfo> folders = directories.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden) && !f.Attributes.HasFlag(FileAttributes.System) && !f.Attributes.HasFlag(FileAttributes.ReadOnly));

                Children.Clear();
                foreach (DirectoryInfo folder in folders)
                    Children.Add(new DirectoryTreeViewItem(folder.FullName, this, true));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
