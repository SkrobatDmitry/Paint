
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.RedoButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CornersTrackBar = new System.Windows.Forms.TrackBar();
            this.PenWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.isFeelCheck = new System.Windows.Forms.CheckBox();
            this.RegularPolygonButton = new System.Windows.Forms.Button();
            this.CornersNumLabel = new System.Windows.Forms.Label();
            this.PenWidthLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CornersTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.PictureBox, "PictureBox");
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.ControlPanel.Controls.Add(this.RedoButton);
            this.ControlPanel.Controls.Add(this.UndoButton);
            this.ControlPanel.Controls.Add(this.ClearButton);
            this.ControlPanel.Controls.Add(this.CornersTrackBar);
            this.ControlPanel.Controls.Add(this.PenWidthTrackBar);
            this.ControlPanel.Controls.Add(this.isFeelCheck);
            this.ControlPanel.Controls.Add(this.RegularPolygonButton);
            this.ControlPanel.Controls.Add(this.CornersNumLabel);
            this.ControlPanel.Controls.Add(this.PenWidthLabel);
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
            // RedoButton
            // 
            this.RedoButton.BackColor = System.Drawing.Color.White;
            this.RedoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RedoButton, "RedoButton");
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.UseVisualStyleBackColor = false;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.White;
            this.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.UndoButton, "UndoButton");
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CornersTrackBar
            // 
            resources.ApplyResources(this.CornersTrackBar, "CornersTrackBar");
            this.CornersTrackBar.Minimum = 3;
            this.CornersTrackBar.Name = "CornersTrackBar";
            this.CornersTrackBar.Value = 3;
            this.CornersTrackBar.Scroll += new System.EventHandler(this.CornersTrackBar_Scroll);
            // 
            // PenWidthTrackBar
            // 
            resources.ApplyResources(this.PenWidthTrackBar, "PenWidthTrackBar");
            this.PenWidthTrackBar.Minimum = 1;
            this.PenWidthTrackBar.Name = "PenWidthTrackBar";
            this.PenWidthTrackBar.Value = 3;
            this.PenWidthTrackBar.Scroll += new System.EventHandler(this.PenWidthTrackBar_Scroll);
            // 
            // isFeelCheck
            // 
            resources.ApplyResources(this.isFeelCheck, "isFeelCheck");
            this.isFeelCheck.Name = "isFeelCheck";
            this.isFeelCheck.UseVisualStyleBackColor = true;
            this.isFeelCheck.CheckedChanged += new System.EventHandler(this.isFeelCheck_CheckedChanged);
            // 
            // RegularPolygonButton
            // 
            this.RegularPolygonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RegularPolygonButton, "RegularPolygonButton");
            this.RegularPolygonButton.Name = "RegularPolygonButton";
            this.RegularPolygonButton.UseVisualStyleBackColor = true;
            this.RegularPolygonButton.Click += new System.EventHandler(this.RegularPolygonButton_Click);
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
            this.FirstColorButton.BackColor = System.Drawing.Color.Black;
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
            this.BrokenLineButton.Click += new System.EventHandler(this.BrokenLineButton_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PolygonButton, "PolygonButton");
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.Click += new System.EventHandler(this.PolygonButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.EllipseButton, "EllipseButton");
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RectangleButton, "RectangleButton");
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LineButton, "LineButton");
            this.LineButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LineButton.Name = "LineButton";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CornersTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
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
        private System.Windows.Forms.Button RegularPolygonButton;
        private System.Windows.Forms.CheckBox isFeelCheck;
        private System.Windows.Forms.TrackBar PenWidthTrackBar;
        private System.Windows.Forms.TrackBar CornersTrackBar;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button UndoButton;
    }
}

