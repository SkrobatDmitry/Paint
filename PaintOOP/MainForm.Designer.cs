
namespace PaintOOP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.CornersNumLabel = new System.Windows.Forms.Label();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.CornersNumBox = new System.Windows.Forms.NumericUpDown();
            this.PenSizeBox = new System.Windows.Forms.NumericUpDown();
            this.SecondColorLabel = new System.Windows.Forms.Label();
            this.FirstColorLabel = new System.Windows.Forms.Label();
            this.SecondColorButton = new System.Windows.Forms.Button();
            this.FirstColorButton = new System.Windows.Forms.Button();
            this.BrokenLineButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CornersNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenSizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.ControlPanel.Controls.Add(this.CornersNumLabel);
            this.ControlPanel.Controls.Add(this.PenWidthLabel);
            this.ControlPanel.Controls.Add(this.CornersNumBox);
            this.ControlPanel.Controls.Add(this.PenSizeBox);
            this.ControlPanel.Controls.Add(this.SecondColorLabel);
            this.ControlPanel.Controls.Add(this.FirstColorLabel);
            this.ControlPanel.Controls.Add(this.SecondColorButton);
            this.ControlPanel.Controls.Add(this.FirstColorButton);
            this.ControlPanel.Controls.Add(this.BrokenLineButton);
            this.ControlPanel.Controls.Add(this.PolygonButton);
            this.ControlPanel.Controls.Add(this.EllipseButton);
            this.ControlPanel.Controls.Add(this.RectangleButton);
            this.ControlPanel.Controls.Add(this.LineButton);
            this.ControlPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.ControlPanel, "ControlPanel");
            this.ControlPanel.Name = "ControlPanel";
            // 
            // CornersNumLabel
            // 
            resources.ApplyResources(this.CornersNumLabel, "CornersNumLabel");
            this.CornersNumLabel.Name = "CornersNumLabel";
            // 
            // PenWidthLabel
            // 
            resources.ApplyResources(this.PenWidthLabel, "PenWidthLabel");
            this.PenWidthLabel.Name = "PenWidthLabel";
            // 
            // CornersNumBox
            // 
            this.CornersNumBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CornersNumBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CornersNumBox, "CornersNumBox");
            this.CornersNumBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CornersNumBox.Name = "CornersNumBox";
            this.CornersNumBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // PenSizeBox
            // 
            this.PenSizeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PenSizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PenSizeBox, "PenSizeBox");
            this.PenSizeBox.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PenSizeBox.Name = "PenSizeBox";
            // 
            // SecondColorLabel
            // 
            resources.ApplyResources(this.SecondColorLabel, "SecondColorLabel");
            this.SecondColorLabel.Name = "SecondColorLabel";
            // 
            // FirstColorLabel
            // 
            resources.ApplyResources(this.FirstColorLabel, "FirstColorLabel");
            this.FirstColorLabel.Name = "FirstColorLabel";
            // 
            // SecondColorButton
            // 
            this.SecondColorButton.BackColor = System.Drawing.Color.White;
            this.SecondColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SecondColorButton, "SecondColorButton");
            this.SecondColorButton.Name = "SecondColorButton";
            this.SecondColorButton.UseVisualStyleBackColor = false;
            this.SecondColorButton.Click += new System.EventHandler(this.SecondColorButton_Click);
            // 
            // FirstColorButton
            // 
            this.FirstColorButton.BackColor = System.Drawing.Color.White;
            this.FirstColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.FirstColorButton, "FirstColorButton");
            this.FirstColorButton.Name = "FirstColorButton";
            this.FirstColorButton.UseVisualStyleBackColor = false;
            this.FirstColorButton.Click += new System.EventHandler(this.FirstColorButton_Click);
            // 
            // BrokenLineButton
            // 
            this.BrokenLineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BrokenLineButton, "BrokenLineButton");
            this.BrokenLineButton.Name = "BrokenLineButton";
            this.BrokenLineButton.UseVisualStyleBackColor = true;
            // 
            // PolygonButton
            // 
            this.PolygonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PolygonButton, "PolygonButton");
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.UseVisualStyleBackColor = true;
            // 
            // EllipseButton
            // 
            this.EllipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.EllipseButton, "EllipseButton");
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.UseVisualStyleBackColor = true;
            // 
            // RectangleButton
            // 
            this.RectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RectangleButton, "RectangleButton");
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.UseVisualStyleBackColor = true;
            // 
            // LineButton
            // 
            this.LineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LineButton, "LineButton");
            this.LineButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LineButton.Name = "LineButton";
            this.LineButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CornersNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenSizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button BrokenLineButton;
        private System.Windows.Forms.Button PolygonButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button FirstColorButton;
        private System.Windows.Forms.Button SecondColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label FirstColorLabel;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Label SecondColorLabel;
        private System.Windows.Forms.Label CornersNumLabel;
        private System.Windows.Forms.Label PenWidthLabel;
        private System.Windows.Forms.NumericUpDown CornersNumBox;
        private System.Windows.Forms.NumericUpDown PenSizeBox;
    }
}

