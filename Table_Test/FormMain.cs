using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Table_Test
{
    public partial class FormMain : Form
    {
        private int[,] table = null;
        private Random random = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        private void DisplayTable(int rowSelected,int columnSelected)
        {
            Graphics grp = this.panTable.CreateGraphics();
            grp.Clear(this.panTable.BackColor);

            //绘制方格
            int rowCount = this.table.GetLength(0);
            int columnCount = this.table.GetLength(1);

            float cellWidth = (float)this.panTable.Width / (columnCount+1);
            float cellHeight = (float)this.panTable.Height / (rowCount+1);

            for (int rowIndex = 1; rowIndex <= rowCount; rowIndex++)
            {
                PointF startPoint = new PointF(0f,cellHeight * rowIndex);
                PointF endPoint = new PointF(this.panTable.Width,cellHeight * rowIndex);

                grp.DrawLine(Pens.Blue, startPoint, endPoint);
            }

            for (int columnIndex =1; columnIndex <= columnCount; columnIndex++)
            {
                PointF startPoint = new PointF(cellWidth * columnIndex, 0f);
                PointF endPoint = new PointF(cellWidth * columnIndex, this.panTable.Height);

                grp.DrawLine(Pens.Blue, startPoint, endPoint);
            }

            #region 显示所有二维数组的值
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {

                    if (rowIndex == rowSelected && columnIndex == columnSelected)
                    {
                        grp.FillRectangle(Brushes.Yellow, new RectangleF(cellWidth * columnIndex,
                                                    cellHeight * rowIndex,
                                                    cellWidth, cellHeight));
                    }

                    grp.DrawString(this.table[rowIndex, columnIndex].ToString(),
                        new Font("黑体", 14f),
                        Brushes.Red,
                        new PointF(cellWidth * columnIndex,cellHeight * rowIndex)
                        );
                }
            }
            #endregion

            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                int rowSum = 0;

                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    rowSum += this.table[rowIndex, columnIndex];
                }
                grp.FillRectangle(Brushes.Black, 
                    new RectangleF(cellWidth * columnCount,
                                                    cellHeight * rowIndex,
                                                    cellWidth, cellHeight));
                grp.DrawString(rowSum.ToString(),
                        new Font("黑体", 14f),
                        Brushes.Yellow,
                         new PointF(cellWidth * columnCount,
                                                    cellHeight * rowIndex));
            }

            for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {
                int columnSum = 0;

                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                {
                    columnSum += this.table[rowIndex, columnIndex];
                }
                grp.FillRectangle(Brushes.Black,
                    new RectangleF(cellWidth * columnIndex,
                                                    cellHeight * rowCount,
                                                    cellWidth, cellHeight));
                grp.DrawString(columnSum.ToString(),
                        new Font("黑体", 14f),
                        Brushes.Yellow,
                         new PointF(cellWidth * columnIndex,
                                                    cellHeight * rowCount));
            }
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            int row = int.Parse(this.txtRow.Text);
            int column = int.Parse(this.txtColumn.Text);
            this.table = new int[row,column];

            this.DisplayTable(-1,-1);
        }

        private void tmRandom_Tick(object sender, EventArgs e)
        {
            int row = int.Parse(this.txtRow.Text);
            int column = int.Parse(this.txtColumn.Text);

            int rowSelected = this.random.Next(0,row);
            int columnSelected = this.random.Next(0,column);

            this.table[rowSelected, columnSelected]++;

            this.DisplayTable(rowSelected, columnSelected);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            this.tmRandom.Start();
        }
       bool flag = true;
        private void btnPause_Click(object sender, EventArgs e)
        {
            
            if (flag == true)
            {
                this.tmRandom.Stop();
                flag = false;
            }
            else
            {
                this.tmRandom.Start();
                flag = true;
            }
        }
    }
}
