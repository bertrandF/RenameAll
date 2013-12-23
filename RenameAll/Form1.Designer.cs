namespace RenameAll
{
    partial class mainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filesTreeView = new System.Windows.Forms.TreeView();
            this.filesListView = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileLastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insertGroupBox = new System.Windows.Forms.GroupBox();
            this.insertPosLabel = new System.Windows.Forms.Label();
            this.insertPosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.insertTextBox = new System.Windows.Forms.TextBox();
            this.insertLabel = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.suppressGroupBox = new System.Windows.Forms.GroupBox();
            this.suppressToLabel = new System.Windows.Forms.Label();
            this.suppressFromLabel = new System.Windows.Forms.Label();
            this.suppressFromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.suppressToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.suppressLastNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.suppressFirstNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.suppressLastLabel = new System.Windows.Forms.Label();
            this.suppressFirstLabel = new System.Windows.Forms.Label();
            this.replaceGroupBox = new System.Windows.Forms.GroupBox();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.replaceWithLabel = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.goButton = new System.Windows.Forms.Button();
            this.reinitializationButton = new System.Windows.Forms.Button();
            this.mainTableLayout.SuspendLayout();
            this.insertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertPosNumericUpDown)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.suppressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppressFromNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppressToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppressLastNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppressFirstNumericUpDown)).BeginInit();
            this.replaceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 4;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.Controls.Add(this.filesTreeView, 0, 0);
            this.mainTableLayout.Controls.Add(this.filesListView, 1, 0);
            this.mainTableLayout.Controls.Add(this.insertGroupBox, 2, 1);
            this.mainTableLayout.Controls.Add(this.addGroupBox, 1, 1);
            this.mainTableLayout.Controls.Add(this.suppressGroupBox, 0, 1);
            this.mainTableLayout.Controls.Add(this.replaceGroupBox, 3, 1);
            this.mainTableLayout.Controls.Add(this.splitContainer1, 0, 2);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainTableLayout.Size = new System.Drawing.Size(939, 541);
            this.mainTableLayout.TabIndex = 0;
            // 
            // filesTreeView
            // 
            this.filesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTreeView.Location = new System.Drawing.Point(3, 3);
            this.filesTreeView.Name = "filesTreeView";
            this.filesTreeView.Size = new System.Drawing.Size(194, 401);
            this.filesTreeView.TabIndex = 0;
            this.filesTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.filesTreeView_BeforeExpand);
            this.filesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.filesTreeView_NodeMouseClick);
            // 
            // filesListView
            // 
            this.filesListView.CheckBoxes = true;
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.newName,
            this.fileType,
            this.fileLastModified});
            this.mainTableLayout.SetColumnSpan(this.filesListView, 3);
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListView.Location = new System.Drawing.Point(203, 3);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(733, 401);
            this.filesListView.TabIndex = 1;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filesListView_ItemCheck);
            this.filesListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.refreshNewName);
            // 
            // fileName
            // 
            this.fileName.Text = "Name";
            this.fileName.Width = 150;
            // 
            // newName
            // 
            this.newName.Text = "New Name";
            this.newName.Width = 200;
            // 
            // fileType
            // 
            this.fileType.Text = "Type";
            this.fileType.Width = 86;
            // 
            // fileLastModified
            // 
            this.fileLastModified.Text = "Last Modified";
            this.fileLastModified.Width = 120;
            // 
            // insertGroupBox
            // 
            this.insertGroupBox.Controls.Add(this.insertPosLabel);
            this.insertGroupBox.Controls.Add(this.insertPosNumericUpDown);
            this.insertGroupBox.Controls.Add(this.insertTextBox);
            this.insertGroupBox.Controls.Add(this.insertLabel);
            this.insertGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertGroupBox.Location = new System.Drawing.Point(403, 410);
            this.insertGroupBox.Name = "insertGroupBox";
            this.insertGroupBox.Size = new System.Drawing.Size(194, 79);
            this.insertGroupBox.TabIndex = 4;
            this.insertGroupBox.TabStop = false;
            this.insertGroupBox.Text = "Insert";
            // 
            // insertPosLabel
            // 
            this.insertPosLabel.AutoSize = true;
            this.insertPosLabel.Location = new System.Drawing.Point(22, 54);
            this.insertPosLabel.Name = "insertPosLabel";
            this.insertPosLabel.Size = new System.Drawing.Size(23, 13);
            this.insertPosLabel.TabIndex = 3;
            this.insertPosLabel.Text = "At :";
            // 
            // insertPosNumericUpDown
            // 
            this.insertPosNumericUpDown.Location = new System.Drawing.Point(51, 47);
            this.insertPosNumericUpDown.Name = "insertPosNumericUpDown";
            this.insertPosNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.insertPosNumericUpDown.TabIndex = 2;
            this.insertPosNumericUpDown.ValueChanged += new System.EventHandler(this.refreshNewName);
            // 
            // insertTextBox
            // 
            this.insertTextBox.Location = new System.Drawing.Point(51, 19);
            this.insertTextBox.Name = "insertTextBox";
            this.insertTextBox.Size = new System.Drawing.Size(137, 20);
            this.insertTextBox.TabIndex = 1;
            this.insertTextBox.TextChanged += new System.EventHandler(this.refreshNewName);
            // 
            // insertLabel
            // 
            this.insertLabel.AutoSize = true;
            this.insertLabel.Location = new System.Drawing.Point(6, 22);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(39, 13);
            this.insertLabel.TabIndex = 0;
            this.insertLabel.Text = "Insert :";
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.suffixTextBox);
            this.addGroupBox.Controls.Add(this.prefixLabel);
            this.addGroupBox.Controls.Add(this.suffixLabel);
            this.addGroupBox.Controls.Add(this.prefixTextBox);
            this.addGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGroupBox.Location = new System.Drawing.Point(203, 410);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(194, 79);
            this.addGroupBox.TabIndex = 5;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add";
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(50, 51);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(138, 20);
            this.suffixTextBox.TabIndex = 0;
            this.suffixTextBox.TextChanged += new System.EventHandler(this.refreshNewName);
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(6, 22);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(39, 13);
            this.prefixLabel.TabIndex = 0;
            this.prefixLabel.Text = "Prefix :";
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(6, 54);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(39, 13);
            this.suffixLabel.TabIndex = 0;
            this.suffixLabel.Text = "Suffix :";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(50, 19);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(138, 20);
            this.prefixTextBox.TabIndex = 0;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.refreshNewName);
            // 
            // suppressGroupBox
            // 
            this.suppressGroupBox.Controls.Add(this.suppressToLabel);
            this.suppressGroupBox.Controls.Add(this.suppressFromLabel);
            this.suppressGroupBox.Controls.Add(this.suppressFromNumericUpDown);
            this.suppressGroupBox.Controls.Add(this.suppressToNumericUpDown);
            this.suppressGroupBox.Controls.Add(this.suppressLastNumericUpDown);
            this.suppressGroupBox.Controls.Add(this.suppressFirstNumericUpDown);
            this.suppressGroupBox.Controls.Add(this.suppressLastLabel);
            this.suppressGroupBox.Controls.Add(this.suppressFirstLabel);
            this.suppressGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppressGroupBox.Location = new System.Drawing.Point(3, 410);
            this.suppressGroupBox.Name = "suppressGroupBox";
            this.suppressGroupBox.Size = new System.Drawing.Size(194, 79);
            this.suppressGroupBox.TabIndex = 6;
            this.suppressGroupBox.TabStop = false;
            this.suppressGroupBox.Text = "Suppress";
            // 
            // suppressToLabel
            // 
            this.suppressToLabel.AutoSize = true;
            this.suppressToLabel.Location = new System.Drawing.Point(101, 54);
            this.suppressToLabel.Name = "suppressToLabel";
            this.suppressToLabel.Size = new System.Drawing.Size(26, 13);
            this.suppressToLabel.TabIndex = 7;
            this.suppressToLabel.Text = "To :";
            // 
            // suppressFromLabel
            // 
            this.suppressFromLabel.AutoSize = true;
            this.suppressFromLabel.Location = new System.Drawing.Point(9, 54);
            this.suppressFromLabel.Name = "suppressFromLabel";
            this.suppressFromLabel.Size = new System.Drawing.Size(36, 13);
            this.suppressFromLabel.TabIndex = 6;
            this.suppressFromLabel.Text = "From :";
            // 
            // suppressFromNumericUpDown
            // 
            this.suppressFromNumericUpDown.Location = new System.Drawing.Point(46, 52);
            this.suppressFromNumericUpDown.Name = "suppressFromNumericUpDown";
            this.suppressFromNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.suppressFromNumericUpDown.TabIndex = 5;
            this.suppressFromNumericUpDown.ValueChanged += new System.EventHandler(this.refreshNewName);
            // 
            // suppressToNumericUpDown
            // 
            this.suppressToNumericUpDown.Location = new System.Drawing.Point(140, 51);
            this.suppressToNumericUpDown.Name = "suppressToNumericUpDown";
            this.suppressToNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.suppressToNumericUpDown.TabIndex = 4;
            this.suppressToNumericUpDown.ValueChanged += new System.EventHandler(this.refreshNewName);
            // 
            // suppressLastNumericUpDown
            // 
            this.suppressLastNumericUpDown.Location = new System.Drawing.Point(140, 19);
            this.suppressLastNumericUpDown.Name = "suppressLastNumericUpDown";
            this.suppressLastNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.suppressLastNumericUpDown.TabIndex = 3;
            this.suppressLastNumericUpDown.ValueChanged += new System.EventHandler(this.refreshNewName);
            // 
            // suppressFirstNumericUpDown
            // 
            this.suppressFirstNumericUpDown.Location = new System.Drawing.Point(46, 19);
            this.suppressFirstNumericUpDown.Name = "suppressFirstNumericUpDown";
            this.suppressFirstNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.suppressFirstNumericUpDown.TabIndex = 2;
            this.suppressFirstNumericUpDown.ValueChanged += new System.EventHandler(this.refreshNewName);
            // 
            // suppressLastLabel
            // 
            this.suppressLastLabel.AutoSize = true;
            this.suppressLastLabel.Location = new System.Drawing.Point(101, 22);
            this.suppressLastLabel.Name = "suppressLastLabel";
            this.suppressLastLabel.Size = new System.Drawing.Size(33, 13);
            this.suppressLastLabel.TabIndex = 1;
            this.suppressLastLabel.Text = "Last :";
            // 
            // suppressFirstLabel
            // 
            this.suppressFirstLabel.AutoSize = true;
            this.suppressFirstLabel.Location = new System.Drawing.Point(7, 21);
            this.suppressFirstLabel.Name = "suppressFirstLabel";
            this.suppressFirstLabel.Size = new System.Drawing.Size(32, 13);
            this.suppressFirstLabel.TabIndex = 0;
            this.suppressFirstLabel.Text = "First :";
            // 
            // replaceGroupBox
            // 
            this.replaceGroupBox.Controls.Add(this.replaceWithTextBox);
            this.replaceGroupBox.Controls.Add(this.replaceWithLabel);
            this.replaceGroupBox.Controls.Add(this.replaceTextBox);
            this.replaceGroupBox.Controls.Add(this.replaceLabel);
            this.replaceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceGroupBox.Location = new System.Drawing.Point(603, 410);
            this.replaceGroupBox.Name = "replaceGroupBox";
            this.replaceGroupBox.Size = new System.Drawing.Size(333, 79);
            this.replaceGroupBox.TabIndex = 7;
            this.replaceGroupBox.TabStop = false;
            this.replaceGroupBox.Text = "Replace";
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Location = new System.Drawing.Point(66, 46);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(258, 20);
            this.replaceWithTextBox.TabIndex = 3;
            this.replaceWithTextBox.TextChanged += new System.EventHandler(this.refreshNewName);
            // 
            // replaceWithLabel
            // 
            this.replaceWithLabel.AutoSize = true;
            this.replaceWithLabel.Location = new System.Drawing.Point(24, 52);
            this.replaceWithLabel.Name = "replaceWithLabel";
            this.replaceWithLabel.Size = new System.Drawing.Size(35, 13);
            this.replaceWithLabel.TabIndex = 2;
            this.replaceWithLabel.Text = "With :";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(66, 18);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(258, 20);
            this.replaceTextBox.TabIndex = 1;
            this.replaceTextBox.TextChanged += new System.EventHandler(this.refreshNewName);
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(6, 21);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(53, 13);
            this.replaceLabel.TabIndex = 0;
            this.replaceLabel.Text = "Replace :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 495);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.goButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reinitializationButton);
            this.splitContainer1.Size = new System.Drawing.Size(194, 43);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 8;
            // 
            // goButton
            // 
            this.goButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goButton.Location = new System.Drawing.Point(0, 0);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(64, 43);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go !";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // reinitializationButton
            // 
            this.reinitializationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reinitializationButton.Location = new System.Drawing.Point(0, 0);
            this.reinitializationButton.Name = "reinitializationButton";
            this.reinitializationButton.Size = new System.Drawing.Size(126, 43);
            this.reinitializationButton.TabIndex = 0;
            this.reinitializationButton.Text = "Reinitialize";
            this.reinitializationButton.UseVisualStyleBackColor = true;
            this.reinitializationButton.Click += new System.EventHandler(this.reinitializationButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 541);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.insertGroupBox.ResumeLayout(false);
            this.insertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertPosNumericUpDown)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.suppressGroupBox.ResumeLayout(false);
            this.suppressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppressFromNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppressToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppressLastNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppressFirstNumericUpDown)).EndInit();
            this.replaceGroupBox.ResumeLayout(false);
            this.replaceGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TreeView filesTreeView;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader fileType;
        private System.Windows.Forms.ColumnHeader fileLastModified;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.ColumnHeader newName;
        private System.Windows.Forms.GroupBox insertGroupBox;
        private System.Windows.Forms.TextBox insertTextBox;
        private System.Windows.Forms.Label insertLabel;
        private System.Windows.Forms.NumericUpDown insertPosNumericUpDown;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Label insertPosLabel;
        private System.Windows.Forms.GroupBox suppressGroupBox;
        private System.Windows.Forms.NumericUpDown suppressLastNumericUpDown;
        private System.Windows.Forms.NumericUpDown suppressFirstNumericUpDown;
        private System.Windows.Forms.Label suppressLastLabel;
        private System.Windows.Forms.Label suppressFirstLabel;
        private System.Windows.Forms.Label suppressToLabel;
        private System.Windows.Forms.Label suppressFromLabel;
        private System.Windows.Forms.NumericUpDown suppressFromNumericUpDown;
        private System.Windows.Forms.NumericUpDown suppressToNumericUpDown;
        private System.Windows.Forms.GroupBox replaceGroupBox;
        private System.Windows.Forms.TextBox replaceWithTextBox;
        private System.Windows.Forms.Label replaceWithLabel;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button reinitializationButton;

    }
}

