using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icxplorer
{
    public partial class Icxplorer : Form
    {
        private string _currentPath = string.Empty;

        public Icxplorer()
        {
            InitializeComponent();
            PathTree.ImageList = new ImageList
            {
                Images =
                {
                    { "DriveIcon", Image.FromFile("Resources/Icons/ic_fluent_hard_drive_20_filled.png") },
                    { "FolderIcon", Image.FromFile("Resources/Icons/ic_fluent_folder_24_filled.png") },
                    { "FolderOpenIcon", Image.FromFile("Resources/Icons/ic_fluent_folder_open_24_filled.png") },
                }
            };
            DirView.LargeImageList = new ImageList
            {
                Images =
                {
                    { "FolderIcon", Image.FromFile("Resources/Icons/ic_fluent_folder_24_filled.png") },
                    { "FolderOpenIcon", Image.FromFile("Resources/Icons/ic_fluent_folder_open_24_filled.png") },
                    { "DocIcon", Image.FromFile("Resources/Icons/ic_fluent_document_24_filled.png") }
                }
            };
            IconsLoader(new Dictionary<Button, Bitmap>
            {
                {
                    GoPrevBtn,
                    new Bitmap(Image.FromFile("Resources/Icons/ic_fluent_arrow_left_24_filled.png"), new Size(30, 30))
                },
                {
                    GoNextBtn,
                    new Bitmap(Image.FromFile("Resources/Icons/ic_fluent_arrow_right_24_filled.png"), new Size(30, 30))
                },
                {
                    InfoBtn,
                    new Bitmap(Image.FromFile("Resources/Icons/ic_fluent_info_24_filled.png"), new Size(15, 15))
                },
                {
                    GoBtn,
                    new Bitmap(Image.FromFile("Resources/Icons/ic_fluent_chevron_right_24_filled.png"),
                        new Size(30, 30))
                }
            });


            DriveInfo.GetDrives().Where(d => d.IsReady).Select(x => x.Name).ToList().ForEach(d =>
            {
                var dNode = new TreeNode(d, 0, 0);
                if (Directory.GetDirectories(d).Length > 0) dNode.Nodes.Add("");
                PathTree.Nodes.Add(dNode);
            });
        }

        private static void IconsLoader(Dictionary<Button, Bitmap> loadPair) =>
            loadPair.Keys.ToList().ForEach(k => k.Image = loadPair[k]);

        private void PathTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();
            DirView.Clear();
            var dir = new DirectoryInfo(e.Node.FullPath);
            dir.GetDirectories().ToList().ForEach(d =>
            {
                if (d.Attributes.HasFlag(FileAttributes.Hidden)) return;
                var fNode = new TreeNode(d.Name, 1, 2);
                if (Directory.EnumerateDirectories(d.FullName).ToList().Count > 0) fNode.Nodes.Add("");
                e.Node.Nodes.Add(fNode);
            });
            dir.GetDirectories().Select(d => d.Name).ToList().ForEach(d => DirView.Items.Add(d, "FolderIcon"));
            dir.GetFiles().ToList().ForEach(f => DirView.Items.Add(f.Name, "DocIcon"));
            _currentPath = PathBox.Text = e.Node.FullPath.Replace(@":\\", @":\");
        }

        private void PathTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var dir = new DirectoryInfo(e.Node.FullPath);
            dir.GetDirectories().Where(d => d.Parent == dir).ToList().ForEach(d =>
            {
                if (d.Attributes.HasFlag(FileAttributes.Hidden)) return;
                if (Directory.EnumerateDirectories(d.FullName).ToList().Count > 0) PathTree.SelectedNode.Expand();
                else DirView.Clear();
                _currentPath = PathBox.Text = e.Node.FullPath.Replace(@":\\", @":\");
            });
        }
        
        //TODO: 修复在点击侧面板后，点击右侧信息图标后左侧失去焦点会无法获得真实路径的问题
        private void DirView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = DirView.SelectedItems[0];
            if (item.ImageKey == @"FolderIcon")
            {
                var path = PathTree.SelectedNode.FullPath;
                _currentPath = PathBox.Text = Path.Combine(path, item.Text);
                //expand level by level from root to current node
                var currentNode = PathTree.Nodes;
                var pathList = _currentPath.Split('\\').ToList();
                pathList.ForEach(p =>
                {
                    var subNode = currentNode.Find(p, false);
                    if (subNode.Length == 1) subNode[0].Expand();
                    currentNode = currentNode[0].Nodes;
                });
            }
            else
            {
                Process.Start(Path.Combine(PathTree.SelectedNode.FullPath, item.Text));
            }
        }
    }
}