using System.Drawing;
using Icxplorer.Properties;

namespace Icxplorer
{
    partial class Icxplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GoPrevBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PathTree = new System.Windows.Forms.TreeView();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.DirView = new System.Windows.Forms.ListView();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoPrevBtn
            // 
            this.GoPrevBtn.Location = new System.Drawing.Point(30, 30);
            this.GoPrevBtn.Margin = new System.Windows.Forms.Padding(6);
            this.GoPrevBtn.Name = "GoPrevBtn";
            this.GoPrevBtn.Size = new System.Drawing.Size(60, 80);
            this.GoPrevBtn.TabIndex = 0;
            this.GoPrevBtn.UseVisualStyleBackColor = true;
            this.GoPrevBtn.Click += new System.EventHandler(this.GoPrevBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PathTree);
            this.panel1.Location = new System.Drawing.Point(30, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 699);
            this.panel1.TabIndex = 2;
            // 
            // PathTree
            // 
            this.PathTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathTree.FullRowSelect = true;
            this.PathTree.Location = new System.Drawing.Point(0, 0);
            this.PathTree.Margin = new System.Windows.Forms.Padding(6);
            this.PathTree.Name = "PathTree";
            this.PathTree.Size = new System.Drawing.Size(400, 699);
            this.PathTree.TabIndex = 0;
            this.PathTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.PathTree_AfterExpand);
            this.PathTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PathTree_NodeMouseDoubleClick);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(482, 30);
            this.PathBox.Margin = new System.Windows.Forms.Padding(6);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(928, 35);
            this.PathBox.TabIndex = 3;
            // 
            // DirView
            // 
            this.DirView.HideSelection = false;
            this.DirView.Location = new System.Drawing.Point(482, 122);
            this.DirView.Margin = new System.Windows.Forms.Padding(6);
            this.DirView.MultiSelect = false;
            this.DirView.Name = "DirView";
            this.DirView.Size = new System.Drawing.Size(928, 699);
            this.DirView.TabIndex = 4;
            this.DirView.UseCompatibleStateImageBehavior = false;
            this.DirView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirView_MouseDoubleClick);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(102, 30);
            this.InfoBtn.Margin = new System.Windows.Forms.Padding(6);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(328, 80);
            this.InfoBtn.TabIndex = 6;
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(482, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "地址栏";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Icxplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 836);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.DirView);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoPrevBtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1606, 907);
            this.MinimumSize = new System.Drawing.Size(1470, 907);
            this.Name = "Icxplorer";
            this.Text = "Icxplorer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button InfoBtn;

        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.ListView DirView;

        private System.Windows.Forms.TreeView PathTree;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button GoPrevBtn;

        #endregion
    }
}