using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class MyPaint : Form
    {
        Color[] colorPalette = {
            Color.Transparent,
            Color.DarkRed,
            Color.Red,
            Color.DarkOrange,
            Color.OrangeRed,
            Color.Orange,
            Color.Pink,
            Color.Gold,
            Color.Yellow,
            Color.LightYellow,
            Color.Lime,
            Color.LimeGreen,
            Color.Green,
            Color.DarkGreen,
            Color.DodgerBlue,
            Color.Blue,
            Color.Navy,
            Color.BlueViolet,
            Color.Violet,
            Color.Black,
            Color.DarkGray,
            Color.Gray,
            Color.LightGray,
            Color.White
        };

        Color selectedDrawColor = Color.Black;
        Color selectedFillColor = Color.Transparent;
        SketchTool selectedTool = SketchTool.None;
        int penSize = 1;

        public MyPaint()
        {
            InitializeComponent();
            foreach(Color color in colorPalette)
            {
                ToolStripButton toolFillColor = new ToolStripButton(" ")
                {
                    BackColor = color,
                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                    ToolTipText = color.Name
                };
                toolFillColor.Click += ToolFillColor_Click;
                ToolStripButton toolDrawColor = new ToolStripButton(" ")
                {
                    BackColor = color,
                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                    ToolTipText = color.Name
                };
                toolDrawColor.Click += ToolDrawColor_Click;

                toolFillColors.Items.Add(toolFillColor);
                toolDrawColors.Items.Add(toolDrawColor);

            }

            btNone.Click += (s, e) => SelectTool(SketchTool.None);
            btRectangle.Click += (s, e) => SelectTool(SketchTool.DrawRect);
            btCircle.Click += (s, e) => SelectTool(SketchTool.DrawCircle);
            btLine.Click += (s, e) => SelectTool(SketchTool.DrawLine);
            btFreedraw.Click += (s, e) => SelectTool(SketchTool.Freedraw);
            btUndo.Click += (s, e) => SelectTool(SketchTool.Undo);
            btRedo.Click += (s, e) => SelectTool(SketchTool.Redo);

            toolPenSize.SelectedIndexChanged += (s, e) =>
            {
                penSize = 1 + toolPenSize.SelectedIndex * 2;
                SelectTool(selectedTool);
            };

            btNew.Click += (s, e) => sketch1.Clear();
            btSave.Click += (s, e) =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save your sketch";
                saveFileDialog.Filter = "Bitmap Image | *.bmp|JPeg Image| *.jpg ";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sketch1.Save(saveFileDialog.FileName);
                }
            };
        }

        private void ToolDrawColor_Click(object sender, EventArgs e)
        {
            selectedDrawColor = (sender as ToolStripButton).BackColor;
            btSelectedDrawColor.BackColor = selectedDrawColor;
            SelectTool(selectedTool);
        }

        private void ToolFillColor_Click(object sender, EventArgs e)
        {
            selectedFillColor = (sender as ToolStripButton).BackColor;
            btSelectedFillColor.BackColor = selectedFillColor;
            SelectTool(selectedTool);
        }

        private void SelectTool(SketchTool tool)
        {
            selectedTool = tool;
            sketch1.SelectTool(tool, selectedDrawColor, selectedFillColor, penSize);
            if(tool == SketchTool.Undo)
            {
                sketch1.Undo();
            }
            if (tool == SketchTool.Redo)
            {
                sketch1.Redo();
            }
        }
    }
}
