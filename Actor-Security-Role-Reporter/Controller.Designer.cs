﻿using System.Windows.Forms;
using Daggen.SecurityRole.Properties;

namespace Daggen.SecurityRole
{
    partial class Controller
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClosePlugin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRetriveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGenerateReport = new System.Windows.Forms.ToolStripButton();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.Actorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusinessUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnActorType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDisabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCombine = new System.Windows.Forms.Button();
            this.buttonIntersect = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.radioButtonToSecurityRole = new System.Windows.Forms.RadioButton();
            this.radioButtonToUser = new System.Windows.Forms.RadioButton();
            this.checkBoxIncludeDisabled = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeTeams = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeUsers = new System.Windows.Forms.CheckBox();
            this.textBoxNumberOfActors = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfSecurityRoles = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewSecurityRoles = new System.Windows.Forms.ListView();
            this.SecurityRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClosePlugin,
            this.toolStripButtonRetriveData,
            this.toolStripSeparator1,
            this.toolStripButtonGenerateReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClosePlugin
            // 
            this.toolStripButtonClosePlugin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClosePlugin.Image")));
            this.toolStripButtonClosePlugin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClosePlugin.Name = "toolStripButtonClosePlugin";
            this.toolStripButtonClosePlugin.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonClosePlugin.Text = "Close";
            this.toolStripButtonClosePlugin.Click += new System.EventHandler(this.toolStripButtonClosePlugin_Click);
            // 
            // toolStripButtonRetriveData
            // 
            this.toolStripButtonRetriveData.Image = global::Daggen.SecurityRole.Properties.Resources.refresh_button;
            this.toolStripButtonRetriveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRetriveData.Name = "toolStripButtonRetriveData";
            this.toolStripButtonRetriveData.Size = new System.Drawing.Size(80, 22);
            this.toolStripButtonRetriveData.Text = "Load Data";
            this.toolStripButtonRetriveData.Click += new System.EventHandler(this.toolStripButtonRetriveData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonGenerateReport
            // 
            this.toolStripButtonGenerateReport.Enabled = false;
            this.toolStripButtonGenerateReport.Image = global::Daggen.SecurityRole.Properties.Resources.analytic_report;
            this.toolStripButtonGenerateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerateReport.Name = "toolStripButtonGenerateReport";
            this.toolStripButtonGenerateReport.Size = new System.Drawing.Size(112, 22);
            this.toolStripButtonGenerateReport.Text = "Generate Report";
            this.toolStripButtonGenerateReport.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.CheckBoxes = true;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Actorname,
            this.BusinessUnit,
            this.ColumnActorType,
            this.ColumnDisabled});
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsers.Location = new System.Drawing.Point(3, 3);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(300, 410);
            this.listViewUsers.TabIndex = 9;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewUsers_ColumnClick);
            this.listViewUsers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewUsers_ItemChecked);
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // Actorname
            // 
            this.Actorname.Text = "Name";
            this.Actorname.Width = 150;
            // 
            // BusinessUnit
            // 
            this.BusinessUnit.Text = "Business Unit";
            this.BusinessUnit.Width = 140;
            // 
            // ColumnActorType
            // 
            this.ColumnActorType.Text = "Type";
            this.ColumnActorType.Width = 50;
            // 
            // ColumnDisabled
            // 
            this.ColumnDisabled.Text = "Disabled";
            this.ColumnDisabled.Width = 50;
            // 
            // buttonCombine
            // 
            this.buttonCombine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonCombine, 2);
            this.buttonCombine.Location = new System.Drawing.Point(9, 37);
            this.buttonCombine.Name = "buttonCombine";
            this.buttonCombine.Size = new System.Drawing.Size(96, 22);
            this.buttonCombine.TabIndex = 1;
            this.buttonCombine.Text = "Combine";
            this.buttonCombine.UseVisualStyleBackColor = true;
            this.buttonCombine.Click += new System.EventHandler(this.buttonCombine_Click);
            // 
            // buttonIntersect
            // 
            this.buttonIntersect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonIntersect, 2);
            this.buttonIntersect.Location = new System.Drawing.Point(9, 69);
            this.buttonIntersect.Name = "buttonIntersect";
            this.buttonIntersect.Size = new System.Drawing.Size(96, 22);
            this.buttonIntersect.TabIndex = 1;
            this.buttonIntersect.Text = "Intersect";
            this.buttonIntersect.UseVisualStyleBackColor = true;
            this.buttonIntersect.Click += new System.EventHandler(this.buttonIntersect_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonReset, 2);
            this.buttonReset.Location = new System.Drawing.Point(9, 101);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 22);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // radioButtonToSecurityRole
            // 
            this.radioButtonToSecurityRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonToSecurityRole.AutoSize = true;
            this.radioButtonToSecurityRole.Checked = true;
            this.radioButtonToSecurityRole.Location = new System.Drawing.Point(67, 7);
            this.radioButtonToSecurityRole.Name = "radioButtonToSecurityRole";
            this.radioButtonToSecurityRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonToSecurityRole.Size = new System.Drawing.Size(37, 17);
            this.radioButtonToSecurityRole.TabIndex = 10;
            this.radioButtonToSecurityRole.TabStop = true;
            this.radioButtonToSecurityRole.Text = "<--";
            this.radioButtonToSecurityRole.UseVisualStyleBackColor = true;
            // 
            // radioButtonToUser
            // 
            this.radioButtonToUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonToUser.AutoSize = true;
            this.radioButtonToUser.Location = new System.Drawing.Point(10, 7);
            this.radioButtonToUser.Name = "radioButtonToUser";
            this.radioButtonToUser.Size = new System.Drawing.Size(37, 17);
            this.radioButtonToUser.TabIndex = 10;
            this.radioButtonToUser.Text = "<--";
            this.radioButtonToUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeDisabled
            // 
            this.checkBoxIncludeDisabled.AutoSize = true;
            this.checkBoxIncludeDisabled.Location = new System.Drawing.Point(3, 26);
            this.checkBoxIncludeDisabled.Name = "checkBoxIncludeDisabled";
            this.checkBoxIncludeDisabled.Size = new System.Drawing.Size(103, 17);
            this.checkBoxIncludeDisabled.TabIndex = 11;
            this.checkBoxIncludeDisabled.Text = "Include disabled";
            this.checkBoxIncludeDisabled.UseVisualStyleBackColor = true;
            this.checkBoxIncludeDisabled.CheckedChanged += new System.EventHandler(this.checkBoxIncludeFilters_CheckedChanged);
            // 
            // checkBoxIncludeTeams
            // 
            this.checkBoxIncludeTeams.AutoSize = true;
            this.checkBoxIncludeTeams.Checked = true;
            this.checkBoxIncludeTeams.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeTeams.Location = new System.Drawing.Point(100, 3);
            this.checkBoxIncludeTeams.Name = "checkBoxIncludeTeams";
            this.checkBoxIncludeTeams.Size = new System.Drawing.Size(96, 17);
            this.checkBoxIncludeTeams.TabIndex = 12;
            this.checkBoxIncludeTeams.Text = "Include Teams";
            this.checkBoxIncludeTeams.UseVisualStyleBackColor = true;
            this.checkBoxIncludeTeams.CheckedChanged += new System.EventHandler(this.checkBoxIncludeFilters_CheckedChanged);
            // 
            // checkBoxIncludeUsers
            // 
            this.checkBoxIncludeUsers.AutoSize = true;
            this.checkBoxIncludeUsers.Checked = true;
            this.checkBoxIncludeUsers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeUsers.Location = new System.Drawing.Point(3, 3);
            this.checkBoxIncludeUsers.Name = "checkBoxIncludeUsers";
            this.checkBoxIncludeUsers.Size = new System.Drawing.Size(91, 17);
            this.checkBoxIncludeUsers.TabIndex = 12;
            this.checkBoxIncludeUsers.Text = "Include Users";
            this.checkBoxIncludeUsers.UseVisualStyleBackColor = true;
            this.checkBoxIncludeUsers.CheckedChanged += new System.EventHandler(this.checkBoxIncludeFilters_CheckedChanged);
            // 
            // textBoxNumberOfActors
            // 
            this.textBoxNumberOfActors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumberOfActors.BackColor = System.Drawing.Color.White;
            this.textBoxNumberOfActors.Location = new System.Drawing.Point(10, 134);
            this.textBoxNumberOfActors.Name = "textBoxNumberOfActors";
            this.textBoxNumberOfActors.ReadOnly = true;
            this.textBoxNumberOfActors.Size = new System.Drawing.Size(37, 20);
            this.textBoxNumberOfActors.TabIndex = 13;
            this.textBoxNumberOfActors.Text = "0";
            this.textBoxNumberOfActors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumberOfSecurityRoles
            // 
            this.textBoxNumberOfSecurityRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumberOfSecurityRoles.BackColor = System.Drawing.Color.White;
            this.textBoxNumberOfSecurityRoles.Location = new System.Drawing.Point(67, 134);
            this.textBoxNumberOfSecurityRoles.Name = "textBoxNumberOfSecurityRoles";
            this.textBoxNumberOfSecurityRoles.ReadOnly = true;
            this.textBoxNumberOfSecurityRoles.Size = new System.Drawing.Size(37, 20);
            this.textBoxNumberOfSecurityRoles.TabIndex = 13;
            this.textBoxNumberOfSecurityRoles.Text = "0";
            this.textBoxNumberOfSecurityRoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewUsers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewSecurityRoles, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 466);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listViewSecurityRoles
            // 
            this.listViewSecurityRoles.CheckBoxes = true;
            this.listViewSecurityRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SecurityRole});
            this.listViewSecurityRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSecurityRoles.Location = new System.Drawing.Point(429, 3);
            this.listViewSecurityRoles.Name = "listViewSecurityRoles";
            this.listViewSecurityRoles.Size = new System.Drawing.Size(301, 410);
            this.listViewSecurityRoles.TabIndex = 9;
            this.listViewSecurityRoles.UseCompatibleStateImageBehavior = false;
            this.listViewSecurityRoles.View = System.Windows.Forms.View.Details;
            this.listViewSecurityRoles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewSecurityRoles_ColumnClick);
            this.listViewSecurityRoles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewSecurityRoles_ItemChecked);
            this.listViewSecurityRoles.SelectedIndexChanged += new System.EventHandler(this.listViewSecurityRoles_SelectedIndexChanged);
            // 
            // SecurityRole
            // 
            this.SecurityRole.Text = "Security Role";
            this.SecurityRole.Width = 268;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkBoxIncludeUsers);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxIncludeTeams);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxIncludeDisabled);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 419);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 44);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(309, 419);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 44);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonToSecurityRole, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonToUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonReset, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonIntersect, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonCombine, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNumberOfActors, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNumberOfSecurityRoles, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(309, 127);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 161);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Controller";
            this.Size = new System.Drawing.Size(733, 491);
            this.Load += new System.EventHandler(this.Controller_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClosePlugin;
        private System.Windows.Forms.ToolStripButton toolStripButtonRetriveData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerateReport;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader Actorname;
        private System.Windows.Forms.ColumnHeader BusinessUnit;
        private System.Windows.Forms.ColumnHeader ColumnActorType;
        private System.Windows.Forms.ColumnHeader ColumnDisabled;
        private System.Windows.Forms.Button buttonIntersect;
        private System.Windows.Forms.Button buttonCombine;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioButtonToSecurityRole;
        private System.Windows.Forms.RadioButton radioButtonToUser;
        private System.Windows.Forms.CheckBox checkBoxIncludeDisabled;
        private System.Windows.Forms.CheckBox checkBoxIncludeTeams;
        private System.Windows.Forms.CheckBox checkBoxIncludeUsers;
        private TextBox textBoxNumberOfActors;
        private TextBox textBoxNumberOfSecurityRoles;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ColumnHeader SecurityRole;
        private ListView listViewSecurityRoles;
        private TableLayoutPanel tableLayoutPanel2;
    }
}