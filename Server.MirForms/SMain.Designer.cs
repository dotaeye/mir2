using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    partial class SMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            MainTabs = new TabControl();
            tabPage1 = new TabPage();
            LogTextBox = new TextBox();
            tabPage2 = new TabPage();
            DebugLogTextBox = new TextBox();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            GlobalMessageButton = new Button();
            GlobalMessageTextBox = new TextBox();
            ChatLogTextBox = new TextBox();
            tabPage4 = new TabPage();
            PlayersOnlineListView = new CustomFormControl.ListViewNF();
            indexHeader = new ColumnHeader();
            nameHeader = new ColumnHeader();
            levelHeader = new ColumnHeader();
            classHeader = new ColumnHeader();
            genderHeader = new ColumnHeader();
            StatusBar = new StatusStrip();
            PlayersLabel = new ToolStripStatusLabel();
            MonsterLabel = new ToolStripStatusLabel();
            ConnectionsLabel = new ToolStripStatusLabel();
            BlockedIPsLabel = new ToolStripStatusLabel();
            CycleDelayLabel = new ToolStripStatusLabel();
            MainMenu = new MenuStrip();
            controlToolStripMenuItem = new ToolStripMenuItem();
            startServerToolStripMenuItem = new ToolStripMenuItem();
            stopServerToolStripMenuItem = new ToolStripMenuItem();
            rebootServerToolStripMenuItem = new ToolStripMenuItem();
            clearBlockedIPsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            reloadNPCsToolStripMenuItem = new ToolStripMenuItem();
            reloadDropsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeServerToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            databaseFormsToolStripMenuItem = new ToolStripMenuItem();
            mapInfoToolStripMenuItem = new ToolStripMenuItem();
            itemInfoToolStripMenuItem = new ToolStripMenuItem();
            monsterInfoToolStripMenuItem = new ToolStripMenuItem();
            itemNEWToolStripMenuItem = new ToolStripMenuItem();
            monsterExperimentalToolStripMenuItem = new ToolStripMenuItem();
            nPCInfoToolStripMenuItem = new ToolStripMenuItem();
            questInfoToolStripMenuItem = new ToolStripMenuItem();
            magicInfoToolStripMenuItem = new ToolStripMenuItem();
            gameshopToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem1 = new ToolStripMenuItem();
            serverToolStripMenuItem = new ToolStripMenuItem();
            balanceToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            dragonSystemToolStripMenuItem = new ToolStripMenuItem();
            miningToolStripMenuItem = new ToolStripMenuItem();
            guildsToolStripMenuItem = new ToolStripMenuItem();
            fishingToolStripMenuItem = new ToolStripMenuItem();
            mailToolStripMenuItem = new ToolStripMenuItem();
            goodsToolStripMenuItem = new ToolStripMenuItem();
            refiningToolStripMenuItem = new ToolStripMenuItem();
            relationshipToolStripMenuItem = new ToolStripMenuItem();
            mentorToolStripMenuItem = new ToolStripMenuItem();
            gemToolStripMenuItem = new ToolStripMenuItem();
            conquestToolStripMenuItem = new ToolStripMenuItem();
            respawnsToolStripMenuItem = new ToolStripMenuItem();
            monsterTunerToolStripMenuItem = new ToolStripMenuItem();
            dropBuilderToolStripMenuItem = new ToolStripMenuItem();
            导出ToolStripMenuItem = new ToolStripMenuItem();
            地图数据ToolStripMenuItem = new ToolStripMenuItem();
            怪物数据ToolStripMenuItem = new ToolStripMenuItem();
            物品数据ToolStripMenuItem = new ToolStripMenuItem();
            任务数据ToolStripMenuItem = new ToolStripMenuItem();
            nPC数据ToolStripMenuItem = new ToolStripMenuItem();
            商城数据ToolStripMenuItem = new ToolStripMenuItem();
            征服数据ToolStripMenuItem = new ToolStripMenuItem();
            InterfaceTimer = new Timer(components);
            MainTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            StatusBar.SuspendLayout();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabs
            // 
            MainTabs.Controls.Add(tabPage1);
            MainTabs.Controls.Add(tabPage2);
            MainTabs.Controls.Add(tabPage3);
            MainTabs.Controls.Add(tabPage4);
            MainTabs.Dock = DockStyle.Fill;
            MainTabs.Location = new Point(0, 36);
            MainTabs.Margin = new Padding(6);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new Size(889, 656);
            MainTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LogTextBox);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Margin = new Padding(6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6);
            tabPage1.Size = new Size(881, 619);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logs";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            LogTextBox.Dock = DockStyle.Fill;
            LogTextBox.Location = new Point(6, 6);
            LogTextBox.Margin = new Padding(6);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = ScrollBars.Vertical;
            LogTextBox.Size = new Size(869, 607);
            LogTextBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DebugLogTextBox);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Margin = new Padding(6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6);
            tabPage2.Size = new Size(881, 619);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Debug Logs";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DebugLogTextBox
            // 
            DebugLogTextBox.Dock = DockStyle.Fill;
            DebugLogTextBox.Location = new Point(6, 6);
            DebugLogTextBox.Margin = new Padding(6);
            DebugLogTextBox.Multiline = true;
            DebugLogTextBox.Name = "DebugLogTextBox";
            DebugLogTextBox.ReadOnly = true;
            DebugLogTextBox.ScrollBars = ScrollBars.Vertical;
            DebugLogTextBox.Size = new Size(869, 607);
            DebugLogTextBox.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(ChatLogTextBox);
            tabPage3.Location = new Point(4, 33);
            tabPage3.Margin = new Padding(6);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(6);
            tabPage3.Size = new Size(881, 619);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Chat Logs";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GlobalMessageButton);
            groupBox1.Controls.Add(GlobalMessageTextBox);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(6, 528);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(869, 85);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send Message";
            // 
            // GlobalMessageButton
            // 
            GlobalMessageButton.Location = new Point(719, 26);
            GlobalMessageButton.Margin = new Padding(6);
            GlobalMessageButton.Name = "GlobalMessageButton";
            GlobalMessageButton.Size = new Size(134, 44);
            GlobalMessageButton.TabIndex = 0;
            GlobalMessageButton.Text = "Send";
            GlobalMessageButton.UseVisualStyleBackColor = true;
            GlobalMessageButton.Click += GlobalMessageButton_Click;
            // 
            // GlobalMessageTextBox
            // 
            GlobalMessageTextBox.Location = new Point(11, 31);
            GlobalMessageTextBox.Margin = new Padding(6);
            GlobalMessageTextBox.Name = "GlobalMessageTextBox";
            GlobalMessageTextBox.Size = new Size(693, 30);
            GlobalMessageTextBox.TabIndex = 0;
            // 
            // ChatLogTextBox
            // 
            ChatLogTextBox.Location = new Point(6, 6);
            ChatLogTextBox.Margin = new Padding(6);
            ChatLogTextBox.Multiline = true;
            ChatLogTextBox.Name = "ChatLogTextBox";
            ChatLogTextBox.ReadOnly = true;
            ChatLogTextBox.ScrollBars = ScrollBars.Vertical;
            ChatLogTextBox.Size = new Size(860, 493);
            ChatLogTextBox.TabIndex = 4;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Controls.Add(PlayersOnlineListView);
            tabPage4.Location = new Point(4, 33);
            tabPage4.Margin = new Padding(6);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(6);
            tabPage4.Size = new Size(881, 619);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Players Online";
            // 
            // PlayersOnlineListView
            // 
            PlayersOnlineListView.Activation = ItemActivation.OneClick;
            PlayersOnlineListView.BackColor = SystemColors.Window;
            PlayersOnlineListView.Columns.AddRange(new ColumnHeader[] { indexHeader, nameHeader, levelHeader, classHeader, genderHeader });
            PlayersOnlineListView.Dock = DockStyle.Fill;
            PlayersOnlineListView.FullRowSelect = true;
            PlayersOnlineListView.GridLines = true;
            PlayersOnlineListView.Location = new Point(6, 6);
            PlayersOnlineListView.Margin = new Padding(6);
            PlayersOnlineListView.Name = "PlayersOnlineListView";
            PlayersOnlineListView.Size = new Size(869, 607);
            PlayersOnlineListView.Sorting = SortOrder.Ascending;
            PlayersOnlineListView.TabIndex = 0;
            PlayersOnlineListView.UseCompatibleStateImageBehavior = false;
            PlayersOnlineListView.View = View.Details;
            PlayersOnlineListView.ColumnWidthChanging += PlayersOnlineListView_ColumnWidthChanging;
            PlayersOnlineListView.DoubleClick += PlayersOnlineListView_DoubleClick;
            // 
            // indexHeader
            // 
            indexHeader.Text = "Index";
            indexHeader.Width = 71;
            // 
            // nameHeader
            // 
            nameHeader.Text = "Name";
            nameHeader.Width = 93;
            // 
            // levelHeader
            // 
            levelHeader.Text = "Level";
            levelHeader.Width = 90;
            // 
            // classHeader
            // 
            classHeader.Text = "Class";
            classHeader.Width = 100;
            // 
            // genderHeader
            // 
            genderHeader.Text = "Gender";
            genderHeader.Width = 98;
            // 
            // StatusBar
            // 
            StatusBar.ImageScalingSize = new Size(24, 24);
            StatusBar.Items.AddRange(new ToolStripItem[] { PlayersLabel, MonsterLabel, ConnectionsLabel, BlockedIPsLabel, CycleDelayLabel });
            StatusBar.Location = new Point(0, 692);
            StatusBar.Name = "StatusBar";
            StatusBar.Padding = new Padding(2, 0, 26, 0);
            StatusBar.Size = new Size(889, 35);
            StatusBar.SizingGrip = false;
            StatusBar.TabIndex = 4;
            StatusBar.Text = "statusStrip1";
            // 
            // PlayersLabel
            // 
            PlayersLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            PlayersLabel.Name = "PlayersLabel";
            PlayersLabel.Size = new Size(95, 28);
            PlayersLabel.Text = "Players: 0";
            // 
            // MonsterLabel
            // 
            MonsterLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            MonsterLabel.Name = "MonsterLabel";
            MonsterLabel.Size = new Size(114, 28);
            MonsterLabel.Text = "Monsters: 0";
            // 
            // ConnectionsLabel
            // 
            ConnectionsLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            ConnectionsLabel.Name = "ConnectionsLabel";
            ConnectionsLabel.Size = new Size(140, 28);
            ConnectionsLabel.Text = "Connections: 0";
            // 
            // BlockedIPsLabel
            // 
            BlockedIPsLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            BlockedIPsLabel.Name = "BlockedIPsLabel";
            BlockedIPsLabel.Size = new Size(131, 28);
            BlockedIPsLabel.Text = "Blocked IPs: 0";
            // 
            // CycleDelayLabel
            // 
            CycleDelayLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            CycleDelayLabel.Name = "CycleDelayLabel";
            CycleDelayLabel.Size = new Size(129, 28);
            CycleDelayLabel.Text = "CycleDelay: 0";
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new Size(24, 24);
            MainMenu.Items.AddRange(new ToolStripItem[] { controlToolStripMenuItem, accountToolStripMenuItem, databaseFormsToolStripMenuItem, configToolStripMenuItem1, 导出ToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(11, 4, 0, 4);
            MainMenu.Size = new Size(889, 36);
            MainMenu.TabIndex = 3;
            MainMenu.Text = "menuStrip1";
            // 
            // controlToolStripMenuItem
            // 
            controlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startServerToolStripMenuItem, stopServerToolStripMenuItem, rebootServerToolStripMenuItem, clearBlockedIPsToolStripMenuItem, toolStripMenuItem1, reloadNPCsToolStripMenuItem, reloadDropsToolStripMenuItem, toolStripSeparator1, closeServerToolStripMenuItem });
            controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            controlToolStripMenuItem.Size = new Size(62, 28);
            controlToolStripMenuItem.Text = "控制";
            // 
            // startServerToolStripMenuItem
            // 
            startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            startServerToolStripMenuItem.Size = new Size(256, 34);
            startServerToolStripMenuItem.Text = "Start Server";
            startServerToolStripMenuItem.Click += startServerToolStripMenuItem_Click;
            // 
            // stopServerToolStripMenuItem
            // 
            stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            stopServerToolStripMenuItem.Size = new Size(256, 34);
            stopServerToolStripMenuItem.Text = "Stop Server";
            stopServerToolStripMenuItem.Click += stopServerToolStripMenuItem_Click;
            // 
            // rebootServerToolStripMenuItem
            // 
            rebootServerToolStripMenuItem.Name = "rebootServerToolStripMenuItem";
            rebootServerToolStripMenuItem.Size = new Size(256, 34);
            rebootServerToolStripMenuItem.Text = "Reboot Server";
            rebootServerToolStripMenuItem.Click += rebootServerToolStripMenuItem_Click;
            // 
            // clearBlockedIPsToolStripMenuItem
            // 
            clearBlockedIPsToolStripMenuItem.Name = "clearBlockedIPsToolStripMenuItem";
            clearBlockedIPsToolStripMenuItem.Size = new Size(256, 34);
            clearBlockedIPsToolStripMenuItem.Text = "Clear Blocked IPs";
            clearBlockedIPsToolStripMenuItem.Click += clearBlockedIPsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(253, 6);
            // 
            // reloadNPCsToolStripMenuItem
            // 
            reloadNPCsToolStripMenuItem.Name = "reloadNPCsToolStripMenuItem";
            reloadNPCsToolStripMenuItem.Size = new Size(256, 34);
            reloadNPCsToolStripMenuItem.Text = "Reload NPCs";
            reloadNPCsToolStripMenuItem.Click += reloadNPCsToolStripMenuItem_Click;
            // 
            // reloadDropsToolStripMenuItem
            // 
            reloadDropsToolStripMenuItem.Name = "reloadDropsToolStripMenuItem";
            reloadDropsToolStripMenuItem.Size = new Size(256, 34);
            reloadDropsToolStripMenuItem.Text = "Reload Drops";
            reloadDropsToolStripMenuItem.Click += reloadDropsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(253, 6);
            // 
            // closeServerToolStripMenuItem
            // 
            closeServerToolStripMenuItem.Name = "closeServerToolStripMenuItem";
            closeServerToolStripMenuItem.Size = new Size(256, 34);
            closeServerToolStripMenuItem.Text = "Close Server";
            closeServerToolStripMenuItem.Click += closeServerToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(62, 28);
            accountToolStripMenuItem.Text = "帐号";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // databaseFormsToolStripMenuItem
            // 
            databaseFormsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mapInfoToolStripMenuItem, itemInfoToolStripMenuItem, monsterInfoToolStripMenuItem, itemNEWToolStripMenuItem, monsterExperimentalToolStripMenuItem, nPCInfoToolStripMenuItem, questInfoToolStripMenuItem, magicInfoToolStripMenuItem, gameshopToolStripMenuItem });
            databaseFormsToolStripMenuItem.Name = "databaseFormsToolStripMenuItem";
            databaseFormsToolStripMenuItem.Size = new Size(80, 28);
            databaseFormsToolStripMenuItem.Text = "数据库";
            // 
            // mapInfoToolStripMenuItem
            // 
            mapInfoToolStripMenuItem.Name = "mapInfoToolStripMenuItem";
            mapInfoToolStripMenuItem.Size = new Size(322, 34);
            mapInfoToolStripMenuItem.Text = "Map";
            mapInfoToolStripMenuItem.Click += mapInfoToolStripMenuItem_Click;
            // 
            // itemInfoToolStripMenuItem
            // 
            itemInfoToolStripMenuItem.Name = "itemInfoToolStripMenuItem";
            itemInfoToolStripMenuItem.ShowShortcutKeys = false;
            itemInfoToolStripMenuItem.Size = new Size(322, 34);
            itemInfoToolStripMenuItem.Text = "Item (OLD- HIDDEN)";
            itemInfoToolStripMenuItem.Visible = false;
            itemInfoToolStripMenuItem.Click += itemInfoToolStripMenuItem_Click;
            // 
            // monsterInfoToolStripMenuItem
            // 
            monsterInfoToolStripMenuItem.Name = "monsterInfoToolStripMenuItem";
            monsterInfoToolStripMenuItem.Size = new Size(322, 34);
            monsterInfoToolStripMenuItem.Text = "Monster(OLD - HIDDEN)";
            monsterInfoToolStripMenuItem.Visible = false;
            monsterInfoToolStripMenuItem.Click += monsterInfoToolStripMenuItem_Click;
            // 
            // itemNEWToolStripMenuItem
            // 
            itemNEWToolStripMenuItem.Name = "itemNEWToolStripMenuItem";
            itemNEWToolStripMenuItem.Size = new Size(322, 34);
            itemNEWToolStripMenuItem.Text = "Item";
            itemNEWToolStripMenuItem.Click += itemNEWToolStripMenuItem_Click;
            // 
            // monsterExperimentalToolStripMenuItem
            // 
            monsterExperimentalToolStripMenuItem.Name = "monsterExperimentalToolStripMenuItem";
            monsterExperimentalToolStripMenuItem.Size = new Size(322, 34);
            monsterExperimentalToolStripMenuItem.Text = "Monster";
            monsterExperimentalToolStripMenuItem.Click += monsterExperimentalToolStripMenuItem_Click;
            // 
            // nPCInfoToolStripMenuItem
            // 
            nPCInfoToolStripMenuItem.Name = "nPCInfoToolStripMenuItem";
            nPCInfoToolStripMenuItem.Size = new Size(322, 34);
            nPCInfoToolStripMenuItem.Text = "NPC";
            nPCInfoToolStripMenuItem.Click += nPCInfoToolStripMenuItem_Click;
            // 
            // questInfoToolStripMenuItem
            // 
            questInfoToolStripMenuItem.Name = "questInfoToolStripMenuItem";
            questInfoToolStripMenuItem.Size = new Size(322, 34);
            questInfoToolStripMenuItem.Text = "Quest";
            questInfoToolStripMenuItem.Click += questInfoToolStripMenuItem_Click;
            // 
            // magicInfoToolStripMenuItem
            // 
            magicInfoToolStripMenuItem.Name = "magicInfoToolStripMenuItem";
            magicInfoToolStripMenuItem.Size = new Size(322, 34);
            magicInfoToolStripMenuItem.Text = "Magic";
            magicInfoToolStripMenuItem.Click += magicInfoToolStripMenuItem_Click;
            // 
            // gameshopToolStripMenuItem
            // 
            gameshopToolStripMenuItem.Name = "gameshopToolStripMenuItem";
            gameshopToolStripMenuItem.Size = new Size(322, 34);
            gameshopToolStripMenuItem.Text = "Gameshop";
            gameshopToolStripMenuItem.Click += gameshopToolStripMenuItem_Click;
            // 
            // configToolStripMenuItem1
            // 
            configToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { serverToolStripMenuItem, balanceToolStripMenuItem, systemToolStripMenuItem, monsterTunerToolStripMenuItem, dropBuilderToolStripMenuItem });
            configToolStripMenuItem1.Name = "configToolStripMenuItem1";
            configToolStripMenuItem1.Size = new Size(62, 28);
            configToolStripMenuItem1.Text = "配置";
            // 
            // serverToolStripMenuItem
            // 
            serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            serverToolStripMenuItem.Size = new Size(236, 34);
            serverToolStripMenuItem.Text = "Server";
            serverToolStripMenuItem.Click += serverToolStripMenuItem_Click;
            // 
            // balanceToolStripMenuItem
            // 
            balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            balanceToolStripMenuItem.Size = new Size(236, 34);
            balanceToolStripMenuItem.Text = "Balance";
            balanceToolStripMenuItem.Click += balanceToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dragonSystemToolStripMenuItem, miningToolStripMenuItem, guildsToolStripMenuItem, fishingToolStripMenuItem, mailToolStripMenuItem, goodsToolStripMenuItem, refiningToolStripMenuItem, relationshipToolStripMenuItem, mentorToolStripMenuItem, gemToolStripMenuItem, conquestToolStripMenuItem, respawnsToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(236, 34);
            systemToolStripMenuItem.Text = "System";
            // 
            // dragonSystemToolStripMenuItem
            // 
            dragonSystemToolStripMenuItem.Name = "dragonSystemToolStripMenuItem";
            dragonSystemToolStripMenuItem.Size = new Size(217, 34);
            dragonSystemToolStripMenuItem.Text = "Dragon";
            dragonSystemToolStripMenuItem.Click += dragonSystemToolStripMenuItem_Click;
            // 
            // miningToolStripMenuItem
            // 
            miningToolStripMenuItem.Name = "miningToolStripMenuItem";
            miningToolStripMenuItem.Size = new Size(217, 34);
            miningToolStripMenuItem.Text = "Mining";
            miningToolStripMenuItem.Click += miningToolStripMenuItem_Click;
            // 
            // guildsToolStripMenuItem
            // 
            guildsToolStripMenuItem.Name = "guildsToolStripMenuItem";
            guildsToolStripMenuItem.Size = new Size(217, 34);
            guildsToolStripMenuItem.Text = "Guilds";
            guildsToolStripMenuItem.Click += guildsToolStripMenuItem_Click;
            // 
            // fishingToolStripMenuItem
            // 
            fishingToolStripMenuItem.Name = "fishingToolStripMenuItem";
            fishingToolStripMenuItem.Size = new Size(217, 34);
            fishingToolStripMenuItem.Text = "Fishing";
            fishingToolStripMenuItem.Click += fishingToolStripMenuItem_Click;
            // 
            // mailToolStripMenuItem
            // 
            mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            mailToolStripMenuItem.Size = new Size(217, 34);
            mailToolStripMenuItem.Text = "Mail";
            mailToolStripMenuItem.Click += mailToolStripMenuItem_Click;
            // 
            // goodsToolStripMenuItem
            // 
            goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            goodsToolStripMenuItem.Size = new Size(217, 34);
            goodsToolStripMenuItem.Text = "Goods";
            goodsToolStripMenuItem.Click += goodsToolStripMenuItem_Click;
            // 
            // refiningToolStripMenuItem
            // 
            refiningToolStripMenuItem.Name = "refiningToolStripMenuItem";
            refiningToolStripMenuItem.Size = new Size(217, 34);
            refiningToolStripMenuItem.Text = "Refining";
            refiningToolStripMenuItem.Click += refiningToolStripMenuItem_Click;
            // 
            // relationshipToolStripMenuItem
            // 
            relationshipToolStripMenuItem.Name = "relationshipToolStripMenuItem";
            relationshipToolStripMenuItem.Size = new Size(217, 34);
            relationshipToolStripMenuItem.Text = "Relationship";
            relationshipToolStripMenuItem.Click += relationshipToolStripMenuItem_Click;
            // 
            // mentorToolStripMenuItem
            // 
            mentorToolStripMenuItem.Name = "mentorToolStripMenuItem";
            mentorToolStripMenuItem.Size = new Size(217, 34);
            mentorToolStripMenuItem.Text = "Mentor";
            mentorToolStripMenuItem.Click += mentorToolStripMenuItem_Click;
            // 
            // gemToolStripMenuItem
            // 
            gemToolStripMenuItem.Name = "gemToolStripMenuItem";
            gemToolStripMenuItem.Size = new Size(217, 34);
            gemToolStripMenuItem.Text = "Gem";
            gemToolStripMenuItem.Click += gemToolStripMenuItem_Click;
            // 
            // conquestToolStripMenuItem
            // 
            conquestToolStripMenuItem.Name = "conquestToolStripMenuItem";
            conquestToolStripMenuItem.Size = new Size(217, 34);
            conquestToolStripMenuItem.Text = "Conquest";
            conquestToolStripMenuItem.Click += conquestToolStripMenuItem_Click;
            // 
            // respawnsToolStripMenuItem
            // 
            respawnsToolStripMenuItem.Name = "respawnsToolStripMenuItem";
            respawnsToolStripMenuItem.Size = new Size(217, 34);
            respawnsToolStripMenuItem.Text = "SpawnTick";
            respawnsToolStripMenuItem.Click += respawnsToolStripMenuItem_Click;
            // 
            // monsterTunerToolStripMenuItem
            // 
            monsterTunerToolStripMenuItem.Name = "monsterTunerToolStripMenuItem";
            monsterTunerToolStripMenuItem.Size = new Size(236, 34);
            monsterTunerToolStripMenuItem.Text = "Monster Tuner";
            monsterTunerToolStripMenuItem.Click += monsterTunerToolStripMenuItem_Click;
            // 
            // dropBuilderToolStripMenuItem
            // 
            dropBuilderToolStripMenuItem.Name = "dropBuilderToolStripMenuItem";
            dropBuilderToolStripMenuItem.Size = new Size(236, 34);
            dropBuilderToolStripMenuItem.Text = "Drop Builder";
            dropBuilderToolStripMenuItem.Click += dropBuilderToolStripMenuItem_Click;
            // 
            // 导出ToolStripMenuItem
            // 
            导出ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 地图数据ToolStripMenuItem, 怪物数据ToolStripMenuItem, 物品数据ToolStripMenuItem, 任务数据ToolStripMenuItem, nPC数据ToolStripMenuItem, 商城数据ToolStripMenuItem, 征服数据ToolStripMenuItem });
            导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            导出ToolStripMenuItem.Size = new Size(62, 28);
            导出ToolStripMenuItem.Text = "导出";
            // 
            // 地图数据ToolStripMenuItem
            // 
            地图数据ToolStripMenuItem.Name = "地图数据ToolStripMenuItem";
            地图数据ToolStripMenuItem.Size = new Size(270, 34);
            地图数据ToolStripMenuItem.Text = "地图数据";
            地图数据ToolStripMenuItem.Click += 地图数据ToolStripMenuItem_Click;
            // 
            // 怪物数据ToolStripMenuItem
            // 
            怪物数据ToolStripMenuItem.Name = "怪物数据ToolStripMenuItem";
            怪物数据ToolStripMenuItem.Size = new Size(270, 34);
            怪物数据ToolStripMenuItem.Text = "怪物数据";
            怪物数据ToolStripMenuItem.Click += 怪物数据ToolStripMenuItem_Click;
            // 
            // 物品数据ToolStripMenuItem
            // 
            物品数据ToolStripMenuItem.Name = "物品数据ToolStripMenuItem";
            物品数据ToolStripMenuItem.Size = new Size(270, 34);
            物品数据ToolStripMenuItem.Text = "物品数据";
            物品数据ToolStripMenuItem.Click += 物品数据ToolStripMenuItem_Click;
            // 
            // 任务数据ToolStripMenuItem
            // 
            任务数据ToolStripMenuItem.Name = "任务数据ToolStripMenuItem";
            任务数据ToolStripMenuItem.Size = new Size(270, 34);
            任务数据ToolStripMenuItem.Text = "任务数据";
            任务数据ToolStripMenuItem.Click += 任务数据ToolStripMenuItem_Click;
            // 
            // nPC数据ToolStripMenuItem
            // 
            nPC数据ToolStripMenuItem.Name = "nPC数据ToolStripMenuItem";
            nPC数据ToolStripMenuItem.Size = new Size(270, 34);
            nPC数据ToolStripMenuItem.Text = "NPC数据";
            nPC数据ToolStripMenuItem.Click += nPC数据ToolStripMenuItem_Click;
            // 
            // 商城数据ToolStripMenuItem
            // 
            商城数据ToolStripMenuItem.Name = "商城数据ToolStripMenuItem";
            商城数据ToolStripMenuItem.Size = new Size(270, 34);
            商城数据ToolStripMenuItem.Text = "商城数据";
            商城数据ToolStripMenuItem.Click += 商城数据ToolStripMenuItem_Click;
            // 
            // 征服数据ToolStripMenuItem
            // 
            征服数据ToolStripMenuItem.Name = "征服数据ToolStripMenuItem";
            征服数据ToolStripMenuItem.Size = new Size(270, 34);
            征服数据ToolStripMenuItem.Text = "征服数据";
            征服数据ToolStripMenuItem.Click += 征服数据ToolStripMenuItem_Click;
            // 
            // InterfaceTimer
            // 
            InterfaceTimer.Enabled = true;
            InterfaceTimer.Tick += InterfaceTimer_Tick;
            // 
            // SMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(889, 727);
            Controls.Add(MainTabs);
            Controls.Add(StatusBar);
            Controls.Add(MainMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "SMain";
            Text = "Legend of Mir Server";
            FormClosing += SMain_FormClosing;
            Load += SMain_Load;
            MainTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            StatusBar.ResumeLayout(false);
            StatusBar.PerformLayout();
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl MainTabs;
        private TabPage tabPage1;
        private TextBox LogTextBox;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel PlayersLabel;
        private ToolStripStatusLabel MonsterLabel;
        private ToolStripStatusLabel ConnectionsLabel;
        private MenuStrip MainMenu;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem startServerToolStripMenuItem;
        private ToolStripMenuItem stopServerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem closeServerToolStripMenuItem;
        private Timer InterfaceTimer;
        private TabPage tabPage2;
        private TextBox DebugLogTextBox;
        private TabPage tabPage3;
        private TextBox ChatLogTextBox;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem databaseFormsToolStripMenuItem;
        private ToolStripMenuItem mapInfoToolStripMenuItem;
        private ToolStripMenuItem itemInfoToolStripMenuItem;
        private ToolStripMenuItem monsterInfoToolStripMenuItem;
        private ToolStripMenuItem nPCInfoToolStripMenuItem;
        private ToolStripMenuItem questInfoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem1;
        private ToolStripMenuItem serverToolStripMenuItem;
        private ToolStripMenuItem balanceToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem dragonSystemToolStripMenuItem;
        private ToolStripMenuItem guildsToolStripMenuItem;
        private ToolStripMenuItem miningToolStripMenuItem;
        private ToolStripMenuItem fishingToolStripMenuItem;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private Button GlobalMessageButton;
        private TextBox GlobalMessageTextBox;
        private CustomFormControl.ListViewNF PlayersOnlineListView;
        private ColumnHeader nameHeader;
        private ColumnHeader levelHeader;
        private ColumnHeader classHeader;
        private ColumnHeader genderHeader;
        private ColumnHeader indexHeader;
        private ToolStripMenuItem mailToolStripMenuItem;
        private ToolStripMenuItem goodsToolStripMenuItem;
        private ToolStripStatusLabel CycleDelayLabel;
        private ToolStripMenuItem magicInfoToolStripMenuItem;
        private ToolStripMenuItem refiningToolStripMenuItem;
        private ToolStripMenuItem relationshipToolStripMenuItem;
        private ToolStripMenuItem mentorToolStripMenuItem;
        private ToolStripMenuItem gameshopToolStripMenuItem;
        private ToolStripMenuItem gemToolStripMenuItem;
        private ToolStripMenuItem conquestToolStripMenuItem;
        private ToolStripMenuItem rebootServerToolStripMenuItem;
        private ToolStripMenuItem respawnsToolStripMenuItem;
        private ToolStripMenuItem monsterTunerToolStripMenuItem;
        private ToolStripMenuItem reloadNPCsToolStripMenuItem;
        private ToolStripMenuItem reloadDropsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem itemNEWToolStripMenuItem;
        private ToolStripMenuItem monsterExperimentalToolStripMenuItem;
        private ToolStripMenuItem dropBuilderToolStripMenuItem;
        private ToolStripStatusLabel BlockedIPsLabel;
        private ToolStripMenuItem clearBlockedIPsToolStripMenuItem;
        private ToolStripMenuItem 导出ToolStripMenuItem;
        private ToolStripMenuItem 地图数据ToolStripMenuItem;
        private ToolStripMenuItem 怪物数据ToolStripMenuItem;
        private ToolStripMenuItem 物品数据ToolStripMenuItem;
        private ToolStripMenuItem 任务数据ToolStripMenuItem;
        private ToolStripMenuItem nPC数据ToolStripMenuItem;
        private ToolStripMenuItem 商城数据ToolStripMenuItem;
        private ToolStripMenuItem 征服数据ToolStripMenuItem;
    }
}

