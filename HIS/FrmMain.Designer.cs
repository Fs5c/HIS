namespace HIS
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User Profile");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("shopping Items");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Invertory");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Statistics and Charts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Clothes shop", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.panelHander = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelApplication = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHander.SuspendLayout();
            this.panelApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHander
            // 
            this.panelHander.BackColor = System.Drawing.Color.White;
            this.panelHander.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHander.Controls.Add(this.label1);
            this.panelHander.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHander.Location = new System.Drawing.Point(0, 0);
            this.panelHander.Name = "panelHander";
            this.panelHander.Size = new System.Drawing.Size(810, 65);
            this.panelHander.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clothes shop";
            // 
            // panelApplication
            // 
            this.panelApplication.BackColor = System.Drawing.Color.White;
            this.panelApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApplication.Controls.Add(this.btnExit);
            this.panelApplication.Controls.Add(this.lblname);
            this.panelApplication.Controls.Add(this.pictureBox1);
            this.panelApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApplication.Location = new System.Drawing.Point(0, 65);
            this.panelApplication.Name = "panelApplication";
            this.panelApplication.Size = new System.Drawing.Size(810, 89);
            this.panelApplication.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::HIS.Properties.Resources._3d_orange_vector_blank_button_hd_png_11664423373m2wszg3yrj1;
            this.btnExit.Location = new System.Drawing.Point(707, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 68);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(137, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(85, 19);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Farah saad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.treeView1);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 154);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(169, 366);
            this.panelNavigation.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeUserProfile";
            treeNode1.Text = "User Profile";
            treeNode2.Name = "NodeShoppingItems";
            treeNode2.Text = "shopping Items";
            treeNode3.Name = "NodeMyInvertory";
            treeNode3.Text = "My Invertory";
            treeNode4.Name = "NodeSACH";
            treeNode4.Text = "Statistics and Charts";
            treeNode5.Name = "NodeRoot";
            treeNode5.Text = "Clothes shop";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(167, 364);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(169, 154);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(641, 366);
            this.panelContent.TabIndex = 0;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelApplication);
            this.Controls.Add(this.panelHander);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "Clothes shop";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelHander.ResumeLayout(false);
            this.panelHander.PerformLayout();
            this.panelApplication.ResumeLayout(false);
            this.panelApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHander;
        private System.Windows.Forms.Panel panelApplication;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TreeView treeView1;
    }
}