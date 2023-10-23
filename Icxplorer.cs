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
                    new Bitmap(Image.FromFile("Resources/Icons/ic_fluent_arrow_left_24_filled.png"), new Size(25, 25))
                },
                {
                    InfoBtn,
                    new Bitmap(Image.FromFile("Resources/Icons/ic_fluent_info_24_filled.png"), new Size(30, 30))
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
            dir.GetFiles().ToList().ForEach(f => DirView.Items.Add(f.Name, "DocIcon"));
            _currentPath = PathBox.Text = e.Node.FullPath.Replace(@":\\", @":\");
        }

        private void PathTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var dir = new DirectoryInfo(e.Node.FullPath);
            DirView.Clear();
            dir.GetFiles().ToList().ForEach(f =>
                DirView.Items.Add(f.Name, "DocIcon"));
            dir.GetDirectories().Where(d => d.Parent == dir).ToList().ForEach(d =>
            {
                if (d.Attributes.HasFlag(FileAttributes.Hidden)) return;
                if (Directory.EnumerateDirectories(d.FullName).ToList().Count > 0) PathTree.SelectedNode.Expand();
                _currentPath = PathBox.Text = e.Node.FullPath.Replace(@":\\", @":\");
            });
        }

        private void DirView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = DirView.SelectedItems[0];
            try
            {
                Process.Start(Path.Combine(_currentPath, item.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"尝试打开文件时出错: {ex.Message}", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void GoPrevBtn_Click(object sender, EventArgs e)
        {
            if (PathTree.SelectedNode.Parent == null) return;
            PathTree.SelectedNode = PathTree.SelectedNode.Parent;
            var dir = new DirectoryInfo(PathTree.SelectedNode.FullPath);
            DirView.Clear();
            dir.GetFiles().ToList().ForEach(f => DirView.Items.Add(f.Name, "DocIcon"));
            _currentPath = PathBox.Text = PathTree.SelectedNode.FullPath.Replace(@":\\", @":\");
        }
        
        private void GoBtn_Click(object sender, EventArgs e)
        {
            if (PathBox.Text == string.Empty) return;
            if (PathBox.Text == _currentPath) return;
            if (!Directory.Exists(PathBox.Text))
            {
                MessageBox.Show(@"路径不存在", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PathTree.SelectedNode = PathTree.Nodes.Find(PathBox.Text, true)[0];
            var dir = new DirectoryInfo(PathTree.SelectedNode.FullPath);
            DirView.Clear();
            dir.GetFiles().ToList().ForEach(f => DirView.Items.Add(f.Name, "DocIcon"));
            _currentPath = PathBox.Text = PathTree.SelectedNode.FullPath.Replace(@":\\", @":\");
        }
        
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Icxplorer 根据 GNU GPL v3 协议开源, BiDuang 2023", @"关于");
        }
    }
}