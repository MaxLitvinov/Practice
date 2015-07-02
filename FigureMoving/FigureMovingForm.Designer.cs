namespace FigureMoving
{
    partial class FigureMovingForm
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
            this.circleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.figureTreeView = new System.Windows.Forms.TreeView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.treeViewPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPanel.SuspendLayout();
            this.treeViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pictureBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(3, 3);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(95, 29);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(104, 3);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(95, 29);
            this.triangleButton.TabIndex = 1;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(205, 3);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(95, 29);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.Text = "Square";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(363, 3);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(95, 29);
            this.moveButton.TabIndex = 3;
            this.moveButton.Text = "Start";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // figureTreeView
            // 
            this.figureTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.figureTreeView.Location = new System.Drawing.Point(0, 0);
            this.figureTreeView.Name = "figureTreeView";
            this.figureTreeView.Size = new System.Drawing.Size(168, 365);
            this.figureTreeView.TabIndex = 4;
            this.figureTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.figureTreeView_AfterSelect);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Controls.Add(this.circleButton);
            this.buttonPanel.Controls.Add(this.moveButton);
            this.buttonPanel.Controls.Add(this.triangleButton);
            this.buttonPanel.Controls.Add(this.rectangleButton);
            this.buttonPanel.Location = new System.Drawing.Point(12, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(674, 36);
            this.buttonPanel.TabIndex = 6;
            // 
            // treeViewPanel
            // 
            this.treeViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPanel.Controls.Add(this.figureTreeView);
            this.treeViewPanel.Location = new System.Drawing.Point(11, 54);
            this.treeViewPanel.Name = "treeViewPanel";
            this.treeViewPanel.Size = new System.Drawing.Size(168, 365);
            this.treeViewPanel.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(499, 363);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPanel.Controls.Add(this.pictureBox);
            this.pictureBoxPanel.Location = new System.Drawing.Point(185, 54);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(501, 365);
            this.pictureBoxPanel.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // FigureMovingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 431);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.treeViewPanel);
            this.Controls.Add(this.buttonPanel);
            this.Name = "FigureMovingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figure Moving";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.buttonPanel.ResumeLayout(false);
            this.treeViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pictureBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TreeView figureTreeView;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel treeViewPanel;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}

