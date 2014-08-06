﻿namespace SEServerGUI
{
	partial class SEServerGUIForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.TRV_Entities = new System.Windows.Forms.TreeView();
			this.BTN_Entities_Export = new System.Windows.Forms.Button();
			this.BTN_Entities_New = new System.Windows.Forms.Button();
			this.BTN_Entities_Delete = new System.Windows.Forms.Button();
			this.PG_Entities_Details = new System.Windows.Forms.PropertyGrid();
			this.BTN_StopServer = new System.Windows.Forms.Button();
			this.BTN_StartServer = new System.Windows.Forms.Button();
			this.BTN_Connect = new System.Windows.Forms.Button();
			this.TAB_MainTabs = new System.Windows.Forms.TabControl();
			this.TAB_Control_Page = new System.Windows.Forms.TabPage();
			this.TAB_Chat_Page = new System.Windows.Forms.TabPage();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.splitContainer8 = new System.Windows.Forms.SplitContainer();
			this.LST_Chat_Messages = new System.Windows.Forms.ListBox();
			this.LST_Chat_ConnectedPlayers = new System.Windows.Forms.ListBox();
			this.splitContainer7 = new System.Windows.Forms.SplitContainer();
			this.TXT_Chat_Message = new System.Windows.Forms.TextBox();
			this.BTN_Chat_Send = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.TAB_MainTabs.SuspendLayout();
			this.TAB_Control_Page.SuspendLayout();
			this.TAB_Chat_Page.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
			this.splitContainer8.Panel1.SuspendLayout();
			this.splitContainer8.Panel2.SuspendLayout();
			this.splitContainer8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
			this.splitContainer7.Panel1.SuspendLayout();
			this.splitContainer7.Panel2.SuspendLayout();
			this.splitContainer7.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.BTN_StopServer);
			this.splitContainer1.Panel2.Controls.Add(this.BTN_StartServer);
			this.splitContainer1.Panel2.Controls.Add(this.BTN_Connect);
			this.splitContainer1.Size = new System.Drawing.Size(892, 727);
			this.splitContainer1.SplitterDistance = 692;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer5);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.PG_Entities_Details);
			this.splitContainer2.Size = new System.Drawing.Size(892, 692);
			this.splitContainer2.SplitterDistance = 257;
			this.splitContainer2.TabIndex = 1;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.TRV_Entities);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.BTN_Entities_Export);
			this.splitContainer5.Panel2.Controls.Add(this.BTN_Entities_New);
			this.splitContainer5.Panel2.Controls.Add(this.BTN_Entities_Delete);
			this.splitContainer5.Size = new System.Drawing.Size(257, 692);
			this.splitContainer5.SplitterDistance = 657;
			this.splitContainer5.TabIndex = 1;
			// 
			// TRV_Entities
			// 
			this.TRV_Entities.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TRV_Entities.Location = new System.Drawing.Point(0, 0);
			this.TRV_Entities.Name = "TRV_Entities";
			this.TRV_Entities.Size = new System.Drawing.Size(257, 657);
			this.TRV_Entities.TabIndex = 0;
			this.TRV_Entities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TRV_Entities_AfterSelect);
			this.TRV_Entities.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TRV_Entities_NodeRefresh);
			// 
			// BTN_Entities_Export
			// 
			this.BTN_Entities_Export.Enabled = false;
			this.BTN_Entities_Export.Location = new System.Drawing.Point(10, 5);
			this.BTN_Entities_Export.Name = "BTN_Entities_Export";
			this.BTN_Entities_Export.Size = new System.Drawing.Size(75, 23);
			this.BTN_Entities_Export.TabIndex = 2;
			this.BTN_Entities_Export.Text = "Export";
			this.BTN_Entities_Export.UseVisualStyleBackColor = true;
			// 
			// BTN_Entities_New
			// 
			this.BTN_Entities_New.Enabled = false;
			this.BTN_Entities_New.Location = new System.Drawing.Point(91, 5);
			this.BTN_Entities_New.Name = "BTN_Entities_New";
			this.BTN_Entities_New.Size = new System.Drawing.Size(75, 23);
			this.BTN_Entities_New.TabIndex = 1;
			this.BTN_Entities_New.Text = "New";
			this.BTN_Entities_New.UseVisualStyleBackColor = true;
			// 
			// BTN_Entities_Delete
			// 
			this.BTN_Entities_Delete.Enabled = false;
			this.BTN_Entities_Delete.Location = new System.Drawing.Point(172, 5);
			this.BTN_Entities_Delete.Name = "BTN_Entities_Delete";
			this.BTN_Entities_Delete.Size = new System.Drawing.Size(75, 23);
			this.BTN_Entities_Delete.TabIndex = 0;
			this.BTN_Entities_Delete.Text = "Delete";
			this.BTN_Entities_Delete.UseVisualStyleBackColor = true;
			// 
			// PG_Entities_Details
			// 
			this.PG_Entities_Details.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PG_Entities_Details.Location = new System.Drawing.Point(0, 0);
			this.PG_Entities_Details.Name = "PG_Entities_Details";
			this.PG_Entities_Details.Size = new System.Drawing.Size(631, 692);
			this.PG_Entities_Details.TabIndex = 0;
			this.PG_Entities_Details.Click += new System.EventHandler(this.PG_Entities_Details_Click);
			// 
			// BTN_StopServer
			// 
			this.BTN_StopServer.Enabled = false;
			this.BTN_StopServer.Location = new System.Drawing.Point(84, 3);
			this.BTN_StopServer.Name = "BTN_StopServer";
			this.BTN_StopServer.Size = new System.Drawing.Size(75, 23);
			this.BTN_StopServer.TabIndex = 2;
			this.BTN_StopServer.Text = "Stop";
			this.BTN_StopServer.UseVisualStyleBackColor = true;
			this.BTN_StopServer.Click += new System.EventHandler(this.BTN_StopServer_Click);
			// 
			// BTN_StartServer
			// 
			this.BTN_StartServer.Enabled = false;
			this.BTN_StartServer.Location = new System.Drawing.Point(3, 3);
			this.BTN_StartServer.Name = "BTN_StartServer";
			this.BTN_StartServer.Size = new System.Drawing.Size(75, 23);
			this.BTN_StartServer.TabIndex = 1;
			this.BTN_StartServer.Text = "Start";
			this.BTN_StartServer.UseVisualStyleBackColor = true;
			this.BTN_StartServer.Click += new System.EventHandler(this.BTN_StartServer_Click);
			// 
			// BTN_Connect
			// 
			this.BTN_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTN_Connect.Location = new System.Drawing.Point(814, 2);
			this.BTN_Connect.Name = "BTN_Connect";
			this.BTN_Connect.Size = new System.Drawing.Size(75, 23);
			this.BTN_Connect.TabIndex = 0;
			this.BTN_Connect.Text = "Connect";
			this.BTN_Connect.UseVisualStyleBackColor = true;
			this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
			// 
			// TAB_MainTabs
			// 
			this.TAB_MainTabs.Controls.Add(this.TAB_Control_Page);
			this.TAB_MainTabs.Controls.Add(this.TAB_Chat_Page);
			this.TAB_MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TAB_MainTabs.Location = new System.Drawing.Point(0, 0);
			this.TAB_MainTabs.Name = "TAB_MainTabs";
			this.TAB_MainTabs.SelectedIndex = 0;
			this.TAB_MainTabs.Size = new System.Drawing.Size(906, 759);
			this.TAB_MainTabs.TabIndex = 1;
			// 
			// TAB_Control_Page
			// 
			this.TAB_Control_Page.Controls.Add(this.splitContainer1);
			this.TAB_Control_Page.Location = new System.Drawing.Point(4, 22);
			this.TAB_Control_Page.Name = "TAB_Control_Page";
			this.TAB_Control_Page.Padding = new System.Windows.Forms.Padding(3);
			this.TAB_Control_Page.Size = new System.Drawing.Size(898, 733);
			this.TAB_Control_Page.TabIndex = 0;
			this.TAB_Control_Page.Text = "Control";
			this.TAB_Control_Page.UseVisualStyleBackColor = true;
			// 
			// TAB_Chat_Page
			// 
			this.TAB_Chat_Page.Controls.Add(this.splitContainer6);
			this.TAB_Chat_Page.Location = new System.Drawing.Point(4, 22);
			this.TAB_Chat_Page.Name = "TAB_Chat_Page";
			this.TAB_Chat_Page.Padding = new System.Windows.Forms.Padding(3);
			this.TAB_Chat_Page.Size = new System.Drawing.Size(898, 733);
			this.TAB_Chat_Page.TabIndex = 1;
			this.TAB_Chat_Page.Text = "Chat";
			this.TAB_Chat_Page.UseVisualStyleBackColor = true;
			// 
			// splitContainer6
			// 
			this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer6.Location = new System.Drawing.Point(3, 3);
			this.splitContainer6.Name = "splitContainer6";
			this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.Controls.Add(this.splitContainer8);
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
			this.splitContainer6.Size = new System.Drawing.Size(892, 727);
			this.splitContainer6.SplitterDistance = 694;
			this.splitContainer6.TabIndex = 5;
			// 
			// splitContainer8
			// 
			this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer8.Location = new System.Drawing.Point(0, 0);
			this.splitContainer8.Name = "splitContainer8";
			// 
			// splitContainer8.Panel1
			// 
			this.splitContainer8.Panel1.Controls.Add(this.LST_Chat_Messages);
			// 
			// splitContainer8.Panel2
			// 
			this.splitContainer8.Panel2.Controls.Add(this.LST_Chat_ConnectedPlayers);
			this.splitContainer8.Size = new System.Drawing.Size(892, 694);
			this.splitContainer8.SplitterDistance = 705;
			this.splitContainer8.TabIndex = 4;
			// 
			// LST_Chat_Messages
			// 
			this.LST_Chat_Messages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LST_Chat_Messages.FormattingEnabled = true;
			this.LST_Chat_Messages.Location = new System.Drawing.Point(0, 0);
			this.LST_Chat_Messages.Name = "LST_Chat_Messages";
			this.LST_Chat_Messages.ScrollAlwaysVisible = true;
			this.LST_Chat_Messages.Size = new System.Drawing.Size(705, 694);
			this.LST_Chat_Messages.TabIndex = 3;
			// 
			// LST_Chat_ConnectedPlayers
			// 
			this.LST_Chat_ConnectedPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LST_Chat_ConnectedPlayers.FormattingEnabled = true;
			this.LST_Chat_ConnectedPlayers.Location = new System.Drawing.Point(0, 0);
			this.LST_Chat_ConnectedPlayers.Name = "LST_Chat_ConnectedPlayers";
			this.LST_Chat_ConnectedPlayers.Size = new System.Drawing.Size(183, 694);
			this.LST_Chat_ConnectedPlayers.TabIndex = 0;
			// 
			// splitContainer7
			// 
			this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer7.Location = new System.Drawing.Point(0, 0);
			this.splitContainer7.Name = "splitContainer7";
			// 
			// splitContainer7.Panel1
			// 
			this.splitContainer7.Panel1.Controls.Add(this.TXT_Chat_Message);
			// 
			// splitContainer7.Panel2
			// 
			this.splitContainer7.Panel2.Controls.Add(this.BTN_Chat_Send);
			this.splitContainer7.Size = new System.Drawing.Size(892, 29);
			this.splitContainer7.SplitterDistance = 755;
			this.splitContainer7.TabIndex = 2;
			// 
			// TXT_Chat_Message
			// 
			this.TXT_Chat_Message.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TXT_Chat_Message.Location = new System.Drawing.Point(0, 0);
			this.TXT_Chat_Message.Name = "TXT_Chat_Message";
			this.TXT_Chat_Message.Size = new System.Drawing.Size(755, 20);
			this.TXT_Chat_Message.TabIndex = 0;
			this.TXT_Chat_Message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Chat_Message_KeyDown);
			// 
			// BTN_Chat_Send
			// 
			this.BTN_Chat_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BTN_Chat_Send.Location = new System.Drawing.Point(53, 3);
			this.BTN_Chat_Send.Name = "BTN_Chat_Send";
			this.BTN_Chat_Send.Size = new System.Drawing.Size(75, 23);
			this.BTN_Chat_Send.TabIndex = 1;
			this.BTN_Chat_Send.Text = "Send";
			this.BTN_Chat_Send.UseVisualStyleBackColor = true;
			this.BTN_Chat_Send.Click += new System.EventHandler(this.BTN_Chat_Send_Click);
			// 
			// SEServerGUIForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 759);
			this.Controls.Add(this.TAB_MainTabs);
			this.Name = "SEServerGUIForm";
			this.Text = "SEServerGUI";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.TAB_MainTabs.ResumeLayout(false);
			this.TAB_Control_Page.ResumeLayout(false);
			this.TAB_Chat_Page.ResumeLayout(false);
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
			this.splitContainer6.ResumeLayout(false);
			this.splitContainer8.Panel1.ResumeLayout(false);
			this.splitContainer8.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
			this.splitContainer8.ResumeLayout(false);
			this.splitContainer7.Panel1.ResumeLayout(false);
			this.splitContainer7.Panel1.PerformLayout();
			this.splitContainer7.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
			this.splitContainer7.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button BTN_Connect;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.PropertyGrid PG_Entities_Details;
		private System.Windows.Forms.Button BTN_StopServer;
		private System.Windows.Forms.Button BTN_StartServer;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.TreeView TRV_Entities;
		private System.Windows.Forms.Button BTN_Entities_Export;
		private System.Windows.Forms.Button BTN_Entities_New;
		private System.Windows.Forms.Button BTN_Entities_Delete;
		private System.Windows.Forms.TabControl TAB_MainTabs;
		private System.Windows.Forms.TabPage TAB_Control_Page;
		private System.Windows.Forms.TabPage TAB_Chat_Page;
		private System.Windows.Forms.SplitContainer splitContainer6;
		private System.Windows.Forms.SplitContainer splitContainer8;
		private System.Windows.Forms.ListBox LST_Chat_Messages;
		private System.Windows.Forms.ListBox LST_Chat_ConnectedPlayers;
		private System.Windows.Forms.SplitContainer splitContainer7;
		private System.Windows.Forms.TextBox TXT_Chat_Message;
		private System.Windows.Forms.Button BTN_Chat_Send;
	}
}

