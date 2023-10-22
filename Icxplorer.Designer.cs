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
            this.GoNextBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PathTree = new System.Windows.Forms.TreeView();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.DirView = new System.Windows.Forms.ListView();
            this.GoBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoPrevBtn
            // 
            this.GoPrevBtn.Location = new System.Drawing.Point(15, 15);
            this.GoPrevBtn.Name = "GoPrevBtn";
            this.GoPrevBtn.Size = new System.Drawing.Size(80, 40);
            this.GoPrevBtn.TabIndex = 0;
            this.GoPrevBtn.UseVisualStyleBackColor = true;
            // 
            // GoNextBtn
            // 
            this.GoNextBtn.Location = new System.Drawing.Point(101, 15);
            this.GoNextBtn.Name = "GoNextBtn";
            this.GoNextBtn.Size = new System.Drawing.Size(80, 40);
            this.GoNextBtn.TabIndex = 1;
            this.GoNextBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PathTree);
            this.panel1.Location = new System.Drawing.Point(15, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 370);
            this.panel1.TabIndex = 2;
            // 
            // PathTree
            // 
            this.PathTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathTree.FullRowSelect = true;
            this.PathTree.Location = new System.Drawing.Point(0, 0);
            this.PathTree.Name = "PathTree";
            this.PathTree.Size = new System.Drawing.Size(200, 370);
            this.PathTree.TabIndex = 0;
            this.PathTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.PathTree_AfterExpand);
            this.PathTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PathTree_NodeMouseDoubleClick);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(241, 15);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(466, 21);
            this.PathBox.TabIndex = 3;
            // 
            // DirView
            // 
            this.DirView.HideSelection = false;
            this.DirView.Location = new System.Drawing.Point(241, 61);
            this.DirView.MultiSelect = false;
            this.DirView.Name = "DirView";
            this.DirView.Size = new System.Drawing.Size(547, 370);
            this.DirView.TabIndex = 4;
            this.DirView.UseCompatibleStateImageBehavior = false;
            this.DirView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirView_MouseDoubleClick);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(713, 15);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 40);
            this.GoBtn.TabIndex = 5;
            this.GoBtn.UseVisualStyleBackColor = true;
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(187, 15);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(28, 40);
            this.InfoBtn.TabIndex = 6;
            this.InfoBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(241, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "地址栏";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Icxplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.DirView);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoNextBtn);
            this.Controls.Add(this.GoPrevBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
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
        private System.Windows.Forms.Button GoBtn;

        private System.Windows.Forms.TreeView PathTree;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button GoPrevBtn;
        private System.Windows.Forms.Button GoNextBtn;

        #endregion
    }
}