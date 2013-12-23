using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RenameAll
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, System.EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                string s = System.String.Format("{0} ({1})", drive.Name, drive.VolumeLabel);
                TreeNode driveNode = new TreeNode(s);
                driveNode.Tag = new DirectoryInfo(drive.Name);
                filesTreeView.Nodes.Add(driveNode);
                fillFileTreeFromDir(drive.Name, driveNode, 1);
            }
        }

        private void fillFileTreeFromDir(string dirName, TreeNode node, int depth) {
            if (depth == 0) return;

            DirectoryInfo directoryInfo = new DirectoryInfo(dirName);
            try
            {
                DirectoryInfo[] allDirectories = directoryInfo.GetDirectories();
                foreach(DirectoryInfo directory in allDirectories) {
                    TreeNode newNode = new TreeNode(directory.Name);
                    newNode.Tag = directory;
                    node.Nodes.Add(newNode);
                    fillFileTreeFromDir(directory.FullName, newNode, depth-1);
                }
            }
            catch(Exception e) {
                Console.WriteLine("fillFileTreeFromDir(): " + e.Message);
            }
        }

        private void filesTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            fillFileTreeFromDir(((DirectoryInfo)node.Tag).FullName, node, 2);
        }

        private void filesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            filesListView.Items.Clear();
            TreeNode node = e.Node;
            DirectoryInfo directoryInfo = (DirectoryInfo)(node.Tag);
            
            try
            {
                FileInfo[] allFiles = directoryInfo.GetFiles();
                foreach (FileInfo file in allFiles)
                {
                    ListViewItem listViewItem = new ListViewItem(Path.GetFileNameWithoutExtension(file.Name)); // File name
                    listViewItem.SubItems.Add(Path.GetFileNameWithoutExtension(file.Name)); // New file name
                    listViewItem.SubItems.Add(file.Extension); // Extension
                    listViewItem.SubItems.Add(file.LastWriteTime.ToShortDateString() +
                                " " + file.LastWriteTime.ToShortTimeString()); // Date and hour of last modif
                    filesListView.Items.Add(listViewItem);
                }
            }
            catch (Exception err) {
                Console.WriteLine("filesTreeView_NodeMouseClick(): " + err.Message);    
            }
        }

        private void refreshNewName(object sender, EventArgs e) 
        {
            foreach (ListViewItem item in filesListView.CheckedItems)
            {
                string text = item.SubItems[0].Text;
                int supprFrom = (int)suppressFromNumericUpDown.Value-1, 
                    supprTo = (int)suppressToNumericUpDown.Value;
                string replaceText = replaceTextBox.Text,
                    replaceWithText = replaceWithTextBox.Text;

                try
                {
                    if(supprFrom <= supprTo && supprFrom >= 0)
                        text = text.Substring(0, supprFrom) + 
                                        text.Substring(supprTo);
                    text = text.Substring((int)suppressFirstNumericUpDown.Value);
                    text = text.Substring(0, text.Length - (int)suppressLastNumericUpDown.Value);
                    text = text.Insert((int)insertPosNumericUpDown.Value, insertTextBox.Text);

                    if (replaceTextBox.Text != "" && replaceWithText != "")
                    {
                        Regex rgx = new Regex(replaceText);
                        text = rgx.Replace(text, replaceWithText);
                    }
                }
                catch (ArgumentNullException err) { }
                catch (ArgumentOutOfRangeException err)
                {
                    MessageBox.Show("File: " + text + item.SubItems[2].Text + "\n" +
                                "Insert query: specified offset is greater than file's name length.",
                                "Bad Query",
                                MessageBoxButtons.OK);
                }
                finally
                {
                    item.SubItems[1].Text = prefixTextBox.Text + text + suffixTextBox.Text;
                }
            }
        }

        private void filesListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked)
            {
                filesListView.Items[e.Index].SubItems[1].Text = filesListView.Items[e.Index].SubItems[0].Text;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {

        }

        private void reinitializationButton_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in filesListView.Items)
              //  item.SubItems[1].Text = item.SubItems[0].Text;
            suppressFirstNumericUpDown.Value = 0;
            suppressLastNumericUpDown.Value = 0;
            suppressFromNumericUpDown.Value = 0;
            suppressToNumericUpDown.Value = 0;
            prefixTextBox.Text = "";
            suffixTextBox.Text = "";
            insertTextBox.Text = "";
            insertPosNumericUpDown.Value = 0;
            replaceTextBox.Text = "";
            replaceWithTextBox.Text = "";
        }

    }
}
