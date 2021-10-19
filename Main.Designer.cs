namespace GT2Bizhawk {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Money",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Days",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Current Car Index",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Garage Size",
            "0"}, -1);
            this.DetectedGameLbl = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.GameTab = new System.Windows.Forms.TabPage();
            this.GotoCar1Btn = new System.Windows.Forms.Button();
            this.MaxMoneyBtn = new System.Windows.Forms.Button();
            this.GameListView = new System.Windows.Forms.ListView();
            this.PropNameHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarageTab = new System.Windows.Forms.TabPage();
            this.CarEditBtn = new System.Windows.Forms.Button();
            this.GarageListView = new System.Windows.Forms.ListView();
            this.MainTabControl.SuspendLayout();
            this.GameTab.SuspendLayout();
            this.GarageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetectedGameLbl
            // 
            this.DetectedGameLbl.AutoSize = true;
            this.DetectedGameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetectedGameLbl.Location = new System.Drawing.Point(0, 0);
            this.DetectedGameLbl.Name = "DetectedGameLbl";
            this.DetectedGameLbl.Padding = new System.Windows.Forms.Padding(5);
            this.DetectedGameLbl.Size = new System.Drawing.Size(118, 23);
            this.DetectedGameLbl.TabIndex = 1;
            this.DetectedGameLbl.Text = "Detected Game: N/A";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.GameTab);
            this.MainTabControl.Controls.Add(this.GarageTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 23);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(400, 427);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // GameTab
            // 
            this.GameTab.Controls.Add(this.GotoCar1Btn);
            this.GameTab.Controls.Add(this.MaxMoneyBtn);
            this.GameTab.Controls.Add(this.GameListView);
            this.GameTab.Location = new System.Drawing.Point(4, 22);
            this.GameTab.Name = "GameTab";
            this.GameTab.Padding = new System.Windows.Forms.Padding(3);
            this.GameTab.Size = new System.Drawing.Size(392, 401);
            this.GameTab.TabIndex = 0;
            this.GameTab.Text = "Game";
            this.GameTab.UseVisualStyleBackColor = true;
            // 
            // GotoCar1Btn
            // 
            this.GotoCar1Btn.Location = new System.Drawing.Point(89, 372);
            this.GotoCar1Btn.Name = "GotoCar1Btn";
            this.GotoCar1Btn.Size = new System.Drawing.Size(75, 23);
            this.GotoCar1Btn.TabIndex = 2;
            this.GotoCar1Btn.Text = "Get In Car 0";
            this.GotoCar1Btn.UseVisualStyleBackColor = true;
            this.GotoCar1Btn.Click += new System.EventHandler(this.GotoCar1Btn_Click);
            // 
            // MaxMoneyBtn
            // 
            this.MaxMoneyBtn.Location = new System.Drawing.Point(8, 372);
            this.MaxMoneyBtn.Name = "MaxMoneyBtn";
            this.MaxMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.MaxMoneyBtn.TabIndex = 1;
            this.MaxMoneyBtn.Text = "Max Money";
            this.MaxMoneyBtn.UseVisualStyleBackColor = true;
            this.MaxMoneyBtn.Click += new System.EventHandler(this.MaxMoneyBtn_Click);
            // 
            // GameListView
            // 
            this.GameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PropNameHead,
            this.ValueHeader});
            this.GameListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameListView.HideSelection = false;
            this.GameListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.GameListView.Location = new System.Drawing.Point(3, 3);
            this.GameListView.Name = "GameListView";
            this.GameListView.Size = new System.Drawing.Size(386, 363);
            this.GameListView.TabIndex = 0;
            this.GameListView.UseCompatibleStateImageBehavior = false;
            this.GameListView.View = System.Windows.Forms.View.Details;
            // 
            // PropNameHead
            // 
            this.PropNameHead.Text = "Property";
            this.PropNameHead.Width = 100;
            // 
            // ValueHeader
            // 
            this.ValueHeader.Text = "Value";
            this.ValueHeader.Width = 280;
            // 
            // GarageTab
            // 
            this.GarageTab.Controls.Add(this.CarEditBtn);
            this.GarageTab.Controls.Add(this.GarageListView);
            this.GarageTab.Location = new System.Drawing.Point(4, 22);
            this.GarageTab.Name = "GarageTab";
            this.GarageTab.Padding = new System.Windows.Forms.Padding(3);
            this.GarageTab.Size = new System.Drawing.Size(392, 401);
            this.GarageTab.TabIndex = 1;
            this.GarageTab.Text = "Garage";
            this.GarageTab.UseVisualStyleBackColor = true;
            // 
            // CarEditBtn
            // 
            this.CarEditBtn.Location = new System.Drawing.Point(6, 372);
            this.CarEditBtn.Name = "CarEditBtn";
            this.CarEditBtn.Size = new System.Drawing.Size(75, 23);
            this.CarEditBtn.TabIndex = 1;
            this.CarEditBtn.Text = "Edit";
            this.CarEditBtn.UseVisualStyleBackColor = true;
            this.CarEditBtn.Click += new System.EventHandler(this.CarEditBtn_Click);
            // 
            // GarageListView
            // 
            this.GarageListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GarageListView.HideSelection = false;
            this.GarageListView.Location = new System.Drawing.Point(3, 3);
            this.GarageListView.Name = "GarageListView";
            this.GarageListView.Size = new System.Drawing.Size(386, 363);
            this.GarageListView.TabIndex = 0;
            this.GarageListView.UseCompatibleStateImageBehavior = false;
            this.GarageListView.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.DetectedGameLbl);
            this.Name = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.GameTab.ResumeLayout(false);
            this.GarageTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DetectedGameLbl;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage GameTab;
        private System.Windows.Forms.ListView GameListView;
        private System.Windows.Forms.ColumnHeader PropNameHead;
        private System.Windows.Forms.ColumnHeader ValueHeader;
        private System.Windows.Forms.TabPage GarageTab;
        private System.Windows.Forms.Button MaxMoneyBtn;
        private System.Windows.Forms.Button GotoCar1Btn;
        private System.Windows.Forms.ListView GarageListView;
        private System.Windows.Forms.Button CarEditBtn;
    }
}

