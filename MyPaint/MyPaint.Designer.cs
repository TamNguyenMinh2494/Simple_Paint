namespace MyPaint
{
    partial class MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNew = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btUndo = new System.Windows.Forms.ToolStripButton();
            this.btRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btNone = new System.Windows.Forms.ToolStripButton();
            this.btRectangle = new System.Windows.Forms.ToolStripButton();
            this.btCircle = new System.Windows.Forms.ToolStripButton();
            this.btLine = new System.Windows.Forms.ToolStripButton();
            this.btFreedraw = new System.Windows.Forms.ToolStripButton();
            this.toolPenSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolFillColors = new System.Windows.Forms.ToolStrip();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btSelectedFillColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDrawColors = new System.Windows.Forms.ToolStrip();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btSelectedDrawColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sketch1 = new Sketch();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolFillColors.SuspendLayout();
            this.toolDrawColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNew,
            this.btSave,
            this.btUndo,
            this.btRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNew
            // 
            this.btNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNew.Image = global::MyPaint.Properties.Resources._new;
            this.btNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(23, 22);
            this.btNew.Text = "New";
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = global::MyPaint.Properties.Resources.save;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 22);
            this.btSave.Text = "Save";
            // 
            // btUndo
            // 
            this.btUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUndo.Image = global::MyPaint.Properties.Resources.undo;
            this.btUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(23, 22);
            this.btUndo.Text = "Undo";
            // 
            // btRedo
            // 
            this.btRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRedo.Image = global::MyPaint.Properties.Resources.redo;
            this.btRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRedo.Name = "btRedo";
            this.btRedo.Size = new System.Drawing.Size(23, 22);
            this.btRedo.Text = "Redo";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btNone,
            this.btRectangle,
            this.btCircle,
            this.btLine,
            this.btFreedraw,
            this.toolPenSize});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Tools";
            // 
            // btNone
            // 
            this.btNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNone.Image = global::MyPaint.Properties.Resources.cursor;
            this.btNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNone.Name = "btNone";
            this.btNone.Size = new System.Drawing.Size(23, 22);
            this.btNone.Text = "None";
            // 
            // btRectangle
            // 
            this.btRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRectangle.Image = global::MyPaint.Properties.Resources.times_square;
            this.btRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(23, 22);
            this.btRectangle.Text = "Rectangle";
            // 
            // btCircle
            // 
            this.btCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCircle.Image = global::MyPaint.Properties.Resources.circle;
            this.btCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(23, 22);
            this.btCircle.Text = "Ellipse";
            // 
            // btLine
            // 
            this.btLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btLine.Image = global::MyPaint.Properties.Resources.minus;
            this.btLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(23, 22);
            this.btLine.Text = "Line";
            // 
            // btFreedraw
            // 
            this.btFreedraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFreedraw.Image = global::MyPaint.Properties.Resources.draw;
            this.btFreedraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFreedraw.Name = "btFreedraw";
            this.btFreedraw.Size = new System.Drawing.Size(23, 22);
            this.btFreedraw.Text = "Freedraw";
            // 
            // toolPenSize
            // 
            this.toolPenSize.Items.AddRange(new object[] {
            "S",
            "XS",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.toolPenSize.Name = "toolPenSize";
            this.toolPenSize.Size = new System.Drawing.Size(121, 25);
            this.toolPenSize.Text = "Pen Size";
            // 
            // toolFillColors
            // 
            this.toolFillColors.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolFillColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton31,
            this.toolStripLabel3,
            this.btSelectedFillColor,
            this.toolStripSeparator1});
            this.toolFillColors.Location = new System.Drawing.Point(0, 50);
            this.toolFillColors.Name = "toolFillColors";
            this.toolFillColors.Size = new System.Drawing.Size(24, 482);
            this.toolFillColors.TabIndex = 3;
            this.toolFillColors.Text = "toolStrip3";
            // 
            // toolStripButton31
            // 
            this.toolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton31.Image = global::MyPaint.Properties.Resources.paint;
            this.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton31.Text = "toolStripButton31";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(21, 55);
            this.toolStripLabel3.Text = "Fill Color";
            this.toolStripLabel3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // btSelectedFillColor
            // 
            this.btSelectedFillColor.BackColor = System.Drawing.Color.Transparent;
            this.btSelectedFillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSelectedFillColor.Image = ((System.Drawing.Image)(resources.GetObject("btSelectedFillColor.Image")));
            this.btSelectedFillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSelectedFillColor.Name = "btSelectedFillColor";
            this.btSelectedFillColor.Size = new System.Drawing.Size(21, 19);
            this.btSelectedFillColor.Text = " ";
            this.btSelectedFillColor.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // toolDrawColors
            // 
            this.toolDrawColors.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolDrawColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton32,
            this.toolStripLabel2,
            this.btSelectedDrawColor,
            this.toolStripSeparator2});
            this.toolDrawColors.Location = new System.Drawing.Point(24, 50);
            this.toolDrawColors.Name = "toolDrawColors";
            this.toolDrawColors.Size = new System.Drawing.Size(24, 482);
            this.toolDrawColors.TabIndex = 4;
            this.toolDrawColors.Text = "toolStrip4";
            // 
            // toolStripButton32
            // 
            this.toolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton32.Image = global::MyPaint.Properties.Resources.crayons;
            this.toolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton32.Name = "toolStripButton32";
            this.toolStripButton32.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton32.Text = "toolStripButton32";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(21, 67);
            this.toolStripLabel2.Text = "Draw Color";
            this.toolStripLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // btSelectedDrawColor
            // 
            this.btSelectedDrawColor.BackColor = System.Drawing.Color.Black;
            this.btSelectedDrawColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSelectedDrawColor.Image = ((System.Drawing.Image)(resources.GetObject("btSelectedDrawColor.Image")));
            this.btSelectedDrawColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSelectedDrawColor.Name = "btSelectedDrawColor";
            this.btSelectedDrawColor.Size = new System.Drawing.Size(21, 19);
            this.btSelectedDrawColor.Text = " ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
            // 
            // sketch1
            // 
            this.sketch1.BackColor = System.Drawing.Color.White;
            this.sketch1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sketch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sketch1.Location = new System.Drawing.Point(48, 50);
            this.sketch1.Margin = new System.Windows.Forms.Padding(4);
            this.sketch1.Name = "sketch1";
            this.sketch1.SelectedTool = SketchTool.Freedraw;
            this.sketch1.Size = new System.Drawing.Size(952, 482);
            this.sketch1.TabIndex = 0;
            this.sketch1.Text = "sketch1";
            this.sketch1.ToolBackColor = System.Drawing.Color.Empty;
            this.sketch1.ToolBorderColor = System.Drawing.Color.Empty;
            this.sketch1.ToolWidth = 2;
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 532);
            this.Controls.Add(this.sketch1);
            this.Controls.Add(this.toolDrawColors);
            this.Controls.Add(this.toolFillColors);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyPaint";
            this.Text = "My Paint";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolFillColors.ResumeLayout(false);
            this.toolFillColors.PerformLayout();
            this.toolDrawColors.ResumeLayout(false);
            this.toolDrawColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sketch sketch1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btNew;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btUndo;
        private System.Windows.Forms.ToolStripButton btRedo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btRectangle;
        private System.Windows.Forms.ToolStripButton btCircle;
        private System.Windows.Forms.ToolStripButton btLine;
        private System.Windows.Forms.ToolStripButton btFreedraw;
        private System.Windows.Forms.ToolStrip toolFillColors;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btSelectedFillColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolDrawColors;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btSelectedDrawColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private System.Windows.Forms.ToolStripButton toolStripButton32;
        private System.Windows.Forms.ToolStripButton btNone;
        private System.Windows.Forms.ToolStripComboBox toolPenSize;
    }
}

