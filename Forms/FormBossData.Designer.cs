﻿namespace PlenBotLogUploader
{
    partial class FormBossData
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
            this.components = new System.ComponentModel.Container();
            this.listViewBosses = new System.Windows.Forms.ListView();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonResetSettings = new System.Windows.Forms.Button();
            this.buttonAddAhdashimBosses = new System.Windows.Forms.Button();
            this.contextMenuStripInteract = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteBoss = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInformation = new System.Windows.Forms.Label();
            this.contextMenuStripInteract.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBosses
            // 
            this.listViewBosses.ContextMenuStrip = this.contextMenuStripInteract;
            this.listViewBosses.HideSelection = false;
            this.listViewBosses.Location = new System.Drawing.Point(12, 12);
            this.listViewBosses.MultiSelect = false;
            this.listViewBosses.Name = "listViewBosses";
            this.listViewBosses.ShowGroups = false;
            this.listViewBosses.Size = new System.Drawing.Size(758, 316);
            this.listViewBosses.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewBosses.TabIndex = 0;
            this.listViewBosses.UseCompatibleStateImageBehavior = false;
            this.listViewBosses.View = System.Windows.Forms.View.Tile;
            this.listViewBosses.DoubleClick += new System.EventHandler(this.listViewBosses_DoubleClick);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(673, 340);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(96, 23);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Add a new boss";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // buttonResetSettings
            // 
            this.buttonResetSettings.Location = new System.Drawing.Point(569, 340);
            this.buttonResetSettings.Name = "buttonResetSettings";
            this.buttonResetSettings.Size = new System.Drawing.Size(98, 23);
            this.buttonResetSettings.TabIndex = 2;
            this.buttonResetSettings.Text = "Reset all bosses";
            this.buttonResetSettings.UseVisualStyleBackColor = true;
            this.buttonResetSettings.Click += new System.EventHandler(this.ButtonResetSettings_Click);
            // 
            // buttonAddAhdashimBosses
            // 
            this.buttonAddAhdashimBosses.Enabled = false;
            this.buttonAddAhdashimBosses.Location = new System.Drawing.Point(432, 340);
            this.buttonAddAhdashimBosses.Name = "buttonAddAhdashimBosses";
            this.buttonAddAhdashimBosses.Size = new System.Drawing.Size(131, 23);
            this.buttonAddAhdashimBosses.TabIndex = 3;
            this.buttonAddAhdashimBosses.Text = "Add Ahdashim bosses";
            this.buttonAddAhdashimBosses.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripInteract
            // 
            this.contextMenuStripInteract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteBoss,
            this.toolStripSeparatorOne,
            this.toolStripMenuItemAddNew});
            this.contextMenuStripInteract.Name = "contextMenuStripInteract";
            this.contextMenuStripInteract.Size = new System.Drawing.Size(181, 54);
            this.contextMenuStripInteract.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripInteract_Opening);
            // 
            // toolStripMenuItemDeleteBoss
            // 
            this.toolStripMenuItemDeleteBoss.Name = "toolStripMenuItemDeleteBoss";
            this.toolStripMenuItemDeleteBoss.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDeleteBoss.Text = "Delete selected boss";
            this.toolStripMenuItemDeleteBoss.Click += new System.EventHandler(this.ToolStripMenuItemDeleteBoss_Click);
            // 
            // toolStripSeparatorOne
            // 
            this.toolStripSeparatorOne.Name = "toolStripSeparatorOne";
            this.toolStripSeparatorOne.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemAddNew
            // 
            this.toolStripMenuItemAddNew.Name = "toolStripMenuItemAddNew";
            this.toolStripMenuItemAddNew.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAddNew.Text = "Add a new boss";
            this.toolStripMenuItemAddNew.Click += new System.EventHandler(this.ToolStripMenuItemAddNew_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(12, 345);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(295, 13);
            this.labelInformation.TabIndex = 5;
            this.labelInformation.Text = "You can right click the box window to bring up context menu.";
            // 
            // FormBossData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 375);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonAddAhdashimBosses);
            this.Controls.Add(this.buttonResetSettings);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.listViewBosses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBossData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit boss data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTwitchLogMessages_FormClosing);
            this.contextMenuStripInteract.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonResetSettings;
        public System.Windows.Forms.ListView listViewBosses;
        private System.Windows.Forms.Button buttonAddAhdashimBosses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInteract;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteBoss;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOne;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddNew;
        private System.Windows.Forms.Label labelInformation;
    }
}