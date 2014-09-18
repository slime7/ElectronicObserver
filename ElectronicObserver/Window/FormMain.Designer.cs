﻿namespace ElectronicObserver.Window {
	partial class FormMain {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
			WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			this.MainDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.StripMenu = new System.Windows.Forms.MenuStrip();
			this.StripMenu_Debug = new System.Windows.Forms.ToolStripMenuItem();
			this.StripMenu_Debug_LoadAPIFromFile = new System.Windows.Forms.ToolStripMenuItem();
			this.StripStatus = new System.Windows.Forms.StatusStrip();
			this.UIUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.StripMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainDockPanel
			// 
			this.MainDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainDockPanel.DockBottomPortion = 150D;
			this.MainDockPanel.DockLeftPortion = 150D;
			this.MainDockPanel.DockRightPortion = 150D;
			this.MainDockPanel.DockTopPortion = 150D;
			this.MainDockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
			this.MainDockPanel.Location = new System.Drawing.Point(0, 26);
			this.MainDockPanel.Name = "MainDockPanel";
			this.MainDockPanel.ShowDocumentIcon = true;
			this.MainDockPanel.Size = new System.Drawing.Size(284, 214);
			dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
			autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
			tabGradient1.EndColor = System.Drawing.SystemColors.Control;
			tabGradient1.StartColor = System.Drawing.SystemColors.Control;
			tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			autoHideStripSkin1.TabGradient = tabGradient1;
			autoHideStripSkin1.TextFont = new System.Drawing.Font("メイリオ", 9F);
			dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
			tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
			dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
			dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
			dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
			tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
			tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
			tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
			dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
			dockPaneStripSkin1.TextFont = new System.Drawing.Font("メイリオ", 9F);
			tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
			tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
			tabGradient5.EndColor = System.Drawing.SystemColors.Control;
			tabGradient5.StartColor = System.Drawing.SystemColors.Control;
			tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
			dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
			dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
			tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
			tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
			dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
			tabGradient7.EndColor = System.Drawing.Color.Transparent;
			tabGradient7.StartColor = System.Drawing.Color.Transparent;
			tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
			dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
			dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
			this.MainDockPanel.Skin = dockPanelSkin1;
			this.MainDockPanel.TabIndex = 0;
			// 
			// StripMenu
			// 
			this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Debug});
			this.StripMenu.Location = new System.Drawing.Point(0, 0);
			this.StripMenu.Name = "StripMenu";
			this.StripMenu.Size = new System.Drawing.Size(284, 26);
			this.StripMenu.TabIndex = 2;
			this.StripMenu.Text = "menuStrip1";
			// 
			// StripMenu_Debug
			// 
			this.StripMenu_Debug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Debug_LoadAPIFromFile});
			this.StripMenu_Debug.Name = "StripMenu_Debug";
			this.StripMenu_Debug.Size = new System.Drawing.Size(87, 22);
			this.StripMenu_Debug.Text = "デバッグ(D)";
			// 
			// StripMenu_Debug_LoadAPIFromFile
			// 
			this.StripMenu_Debug_LoadAPIFromFile.Name = "StripMenu_Debug_LoadAPIFromFile";
			this.StripMenu_Debug_LoadAPIFromFile.Size = new System.Drawing.Size(245, 22);
			this.StripMenu_Debug_LoadAPIFromFile.Text = "ファイルからAPIをロード(L)...";
			this.StripMenu_Debug_LoadAPIFromFile.Click += new System.EventHandler(this.StripMenu_Debug_LoadAPIFromFile_Click);
			// 
			// StripStatus
			// 
			this.StripStatus.Location = new System.Drawing.Point(0, 240);
			this.StripStatus.Name = "StripStatus";
			this.StripStatus.Size = new System.Drawing.Size(284, 22);
			this.StripStatus.TabIndex = 3;
			// 
			// UIUpdateTimer
			// 
			this.UIUpdateTimer.Interval = 500;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.MainDockPanel);
			this.Controls.Add(this.StripStatus);
			this.Controls.Add(this.StripMenu);
			this.MainMenuStrip = this.StripMenu;
			this.Name = "FormMain";
			this.Text = "試製七四式電子観測儀";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.StripMenu.ResumeLayout(false);
			this.StripMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private WeifenLuo.WinFormsUI.Docking.DockPanel MainDockPanel;
		private System.Windows.Forms.MenuStrip StripMenu;
		private System.Windows.Forms.StatusStrip StripStatus;
		private System.Windows.Forms.ToolStripMenuItem StripMenu_Debug;
		private System.Windows.Forms.ToolStripMenuItem StripMenu_Debug_LoadAPIFromFile;
		private System.Windows.Forms.Timer UIUpdateTimer;
	}
}

