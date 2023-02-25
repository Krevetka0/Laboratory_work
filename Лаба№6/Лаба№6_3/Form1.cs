using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Лаба_6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int radius = 150;
        int rectHeight = radius / 2 + (radius / 2 / 2);
        int rectWidth = radius / 2 + (radius / 2 / 2);

        Pen remarksPen = new Pen(Color.Black);

        System.Drawing.Point yLocation = new System.Drawing.Point(180, 0);
        System.Drawing.Point xLocation = new System.Drawing.Point(390, 150);
        System.Drawing.Point twoTopLocation = new System.Drawing.Point(180, 35);
        System.Drawing.Point twoRightLocation = new System.Drawing.Point(280, 150);
        System.Drawing.Point twoLeftLocation = new System.Drawing.Point(115, 150);
        System.Drawing.Point twoBottomLocation = new System.Drawing.Point(180, 220);
        System.Drawing.Point fourRightLocation = new System.Drawing.Point(350, 150);
        System.Drawing.Point zeroLocation = new System.Drawing.Point(180, 130);

        // Настройки шрифта подписей на осях
        FontFamily family = new FontFamily("Arial");
        int emSize = 14;
        StringFormat format = StringFormat.GenericDefault;

        private void DrawRemarks()
        {
            Graphics gr = panelGraf.CreateGraphics();

            // Подписываем оси графика
            Figure yTxt = new Figure();
            yTxt.Path.AddString("y", family, 0, emSize, new System.Drawing.Point(yLocation.X, yLocation.Y), format);
            yTxtRegion = yTxt.Region.Clone();
            gr.DrawPath(remarksPen, yTxt.Path);

            Figure xTxt = new Figure();
            xTxt.Path.AddString("x", family, 0, emSize, new System.Drawing.Point(xLocation.X, xLocation.Y), format);
            xTxtRegion = xTxt.Region.Clone();
            gr.DrawPath(remarksPen, xTxt.Path);


            Figure threeTopTxt = new Figure();
            threeTopTxt.Path.AddString("2", family, 0, emSize, new System.Drawing.Point(twoTopLocation.X, twoTopLocation.Y), format);
            threeTopTxtRegion = threeTopTxt.Region.Clone();
            gr.DrawPath(remarksPen, threeTopTxt.Path);

            Figure threeRightTxt = new Figure();
            threeRightTxt.Path.AddString("2", family, 0, emSize, new System.Drawing.Point(twoRightLocation.X, twoRightLocation.Y), format);
            threeRightTxtRegion = threeRightTxt.Region.Clone();
            gr.DrawPath(remarksPen, threeRightTxt.Path);

            Figure twoLeftTxt = new Figure();
            twoLeftTxt.Path.AddString("2", family, 0, emSize, new System.Drawing.Point(twoLeftLocation.X, twoLeftLocation.Y), format);
            twoLeftTxtRegion = twoLeftTxt.Region.Clone();
            gr.DrawPath(remarksPen, twoLeftTxt.Path);

            Figure twoBottomTxt = new Figure();
            twoBottomTxt.Path.AddString("2", family, 0, emSize, new System.Drawing.Point(twoBottomLocation.X, twoBottomLocation.Y), format);
            twoBottomTxtRegion = twoBottomTxt.Region.Clone();
            gr.DrawPath(remarksPen, twoBottomTxt.Path);

            Figure zeroTxt = new Figure();
            zeroTxt.Path.AddString("0", family, 0, emSize, new System.Drawing.Point(zeroLocation.X, zeroLocation.Y), format);
            zeroTxtRegion = zeroTxt.Region.Clone();
            gr.DrawPath(remarksPen, zeroTxt.Path);
        }
        Region leftRegion = new Region(), rightRegion = new Region();
        int mouseX = 0, mouseY = 0;

        private void TimerChangeColor_Tick(object sender, EventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();
            if (leftRegion.IsVisible(mouseX, mouseY))
                gr.FillRegion(new SolidBrush(ReturnColor()), leftRegion);
            else if (rightRegion.IsVisible(mouseX, mouseY))
                gr.FillRegion(new SolidBrush(ReturnColor()), rightRegion);
        }

        private void panelGraf_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();
            if (leftRegion.IsVisible(e.X, e.Y) || rightRegion.IsVisible(e.X, e.Y))
            {
                mouseX = e.X;
                mouseY = e.Y;
                TimerChangeColor.Start();
            }
            else TimerChangeColor.Stop();
        }

        private void buttoStartAnimation_Click(object sender, EventArgs e)
        {
            FillFontFamiliesList();
            TimerChangeFont.Start();
        }

        private void buttonStopAnimation_Click(object sender, EventArgs e)
        {
            TimerChangeFont.Stop();
        }

        Region yTxtRegion = new Region(), xTxtRegion = new Region(), zeroTxtRegion = new Region(),
            twoLeftTxtRegion = new Region(), twoBottomTxtRegion = new Region(), fourTxtRegion = new Region(),
            threeTopTxtRegion = new Region(), threeRightTxtRegion = new Region();

        private void panelGraf_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();

            if (yTxtRegion.IsVisible(e.X, e.Y))
                yFlag = true;
            else if (xTxtRegion.IsVisible(e.X, e.Y))
                xFlag = true;
            else if (threeTopTxtRegion.IsVisible(e.X, e.Y))
                threeTopFlag = true;
            else if (threeRightTxtRegion.IsVisible(e.X, e.Y))
                threeRightFlag = true;
            else if (fourTxtRegion.IsVisible(e.X, e.Y))
                fourFlag = true;
            else if (zeroTxtRegion.IsVisible(e.X, e.Y))
                zeroFlag = true;
            else if (twoLeftTxtRegion.IsVisible(e.X, e.Y))
                twoLeftFlag = true;
            else if (twoBottomTxtRegion.IsVisible(e.X, e.Y))
                twoBottomFlag = true;
        }

        private void rightStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();
            ColorDialog clrDlg = new ColorDialog();
            Color newColor;
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                newColor = clrDlg.Color;
                gr.FillRegion(new SolidBrush(newColor), rightRegion);
            }
        }

        private void leftStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();
            ColorDialog clrDlg = new ColorDialog();
            Color newColor;
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                newColor = clrDlg.Color;
                gr.FillRegion(new SolidBrush(newColor), leftRegion);
            }
        }

        private void bothStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();
            ColorDialog clrDlg = new ColorDialog();
            Color newColor;
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                newColor = clrDlg.Color;
                gr.FillRegion(new SolidBrush(newColor), leftRegion);
                gr.FillRegion(new SolidBrush(newColor), rightRegion);
            }
        }

        private void panelGraf_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panelGraf.CreateGraphics();
            Pen axisPen = new Pen(Color.Black, 1);
            axisPen.StartCap = LineCap.ArrowAnchor;

            // Рисуем ось x
            Figure axisX = new Figure();
            System.Drawing.Point xAxisStart = new System.Drawing.Point(panelGraf.Width, panelGraf.Height / 2);
            System.Drawing.Point xAxisEnd = new System.Drawing.Point(0, panelGraf.Height / 2);
            axisX.Path.AddLine(xAxisStart.X, xAxisStart.Y, xAxisEnd.X, xAxisEnd.Y);
            gr.DrawPath(axisPen, axisX.Path);

            // Рисуем ось y
            Figure axisY = new Figure();
            System.Drawing.Point yAxisStart = new System.Drawing.Point(panelGraf.Width / 2, 0);
            System.Drawing.Point yAxisEnd = new System.Drawing.Point(panelGraf.Width / 2, panelGraf.Height);
            axisY.Path.AddLine(yAxisStart.X, yAxisStart.Y, yAxisEnd.X, yAxisEnd.Y);
            gr.DrawPath(axisPen, axisY.Path);

            Pen circlePen = new Pen(Color.FromArgb(0, 0, 0), 1);

            // Рисуем круг
            System.Drawing.Point CenterCircleLocation = new System.Drawing.Point
                (
                panelGraf.Width / 2 - radius / 2,
                panelGraf.Height / 2 - radius / 2
                );
            Figure centerCircle = new Figure();
            centerCircle.Path.AddEllipse(new Rectangle(CenterCircleLocation.X, CenterCircleLocation.Y, radius, radius));
            gr.DrawPath(circlePen, centerCircle.Path);

            // Горизонтальная линия
            Pen linePen = new Pen(Color.Black, 1);
            linePen.DashStyle = DashStyle.Solid;
            Figure lineX = new Figure();
            System.Drawing.Point lineXStart = new System.Drawing.Point(panelGraf.Width / 2 - radius, panelGraf.Height / 2 - radius / 2);
            System.Drawing.Point lineXEnd = new System.Drawing.Point(panelGraf.Width / 2 + radius, panelGraf.Height / 2 - radius / 2);
            lineX.Path.AddLine(lineXStart.X, lineXStart.Y, lineXEnd.X, lineXEnd.Y);
            gr.DrawPath(linePen, lineX.Path);

            // Вертикальная линия
            Figure lineY = new Figure();
            System.Drawing.Point lineYStart = new System.Drawing.Point(panelGraf.Width / 2 + radius / 2, panelGraf.Height / 2 + radius);
            System.Drawing.Point lineYEnd = new System.Drawing.Point(panelGraf.Width / 2 + radius / 2, panelGraf.Height / 2 - radius);
            lineY.Path.AddLine(lineYStart.X, lineYStart.Y, lineYEnd.X, lineYEnd.Y);
            gr.DrawPath(linePen, lineY.Path);

            // Наклонная линия>
            System.Drawing.Point rectLocation = new System.Drawing.Point
            (
                panelGraf.Width / 2,
                panelGraf.Height / 2 - rectHeight
            );
            Pen slashLinePen = new Pen(Color.Black, 1);
            Figure slashLine = new Figure();
            System.Drawing.Point slashLineStart = new System.Drawing.Point(panelGraf.Width / 2 - rectHeight, panelGraf.Height / 2 + rectHeight);
            System.Drawing.Point slashLineEnd = new System.Drawing.Point(rectLocation.X + rectWidth, rectLocation.Y);
            slashLine.Path.AddLine(slashLineStart.X, slashLineStart.Y, slashLineEnd.X, slashLineEnd.Y);
            gr.DrawPath(slashLinePen, slashLine.Path);
            DrawRemarks();

            // Невидимые треугольники
            Figure firstTriangle = new Figure();
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            points[0] = new System.Drawing.Point(panelGraf.Width / 2, panelGraf.Height / 2);
            points[1] = new System.Drawing.Point(panelGraf.Width / 2, panelGraf.Height / 2 - radius / 2);
            points[2] = new System.Drawing.Point(panelGraf.Width / 2 + radius / 2, panelGraf.Height / 2 - radius / 2);
            firstTriangle.Path.AddPolygon(points);

            Figure secondTriangle = new Figure();
            System.Drawing.Point[] pointsTwo = new System.Drawing.Point[3];
            pointsTwo[0] = new System.Drawing.Point(panelGraf.Width / 2, panelGraf.Height / 2);
            pointsTwo[1] = new System.Drawing.Point(panelGraf.Width / 2, panelGraf.Height / 2 + radius / 2);
            pointsTwo[2] = new System.Drawing.Point(panelGraf.Width / 2 - radius / 2, panelGraf.Height / 2 + radius  / 2);
            secondTriangle.Path.AddPolygon(pointsTwo);


            // Закрашиваем правое верхнее пересечение
            var regionOne = firstTriangle.Region;
            regionOne.Exclude(centerCircle.Region);
            gr.FillRegion(new SolidBrush(Color.FromArgb(0, 0, 0)), regionOne);
            rightRegion = regionOne.Clone();

            // Закрашиваем левое нижнее пересечение
            var regionTwo = secondTriangle.Region;
            regionTwo.Intersect(centerCircle.Region);
            gr.FillRegion(new SolidBrush(Color.FromArgb(0, 0, 0)), regionTwo);
            leftRegion = regionTwo.Clone();
            DrawRemarks();
        }

        private void panelGraf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (yFlag)
            {
                yLocation.X = e.X;
                yLocation.Y = e.Y;
                yFlag = false;
                panelGraf.Invalidate();
            }
            if (xFlag)
            {
                xLocation.X = e.X;
                xLocation.Y = e.Y;
                xFlag = false;
                panelGraf.Invalidate();
            }
            if (twoLeftFlag)
            {
                twoLeftLocation.X = e.X;
                twoLeftLocation.Y = e.Y;
                twoLeftFlag = false;
                panelGraf.Invalidate();
            }
            if (twoBottomFlag)
            {
                twoBottomLocation.X = e.X;
                twoBottomLocation.Y = e.Y;
                twoBottomFlag = false;
                panelGraf.Invalidate();
            }
            if (threeRightFlag)
            {
                twoRightLocation.X = e.X;
                twoRightLocation.Y = e.Y;
                threeRightFlag = false;
                panelGraf.Invalidate();
            }
            if (threeTopFlag)
            {
                twoTopLocation.X = e.X;
                twoTopLocation.Y = e.Y;
                threeTopFlag = false;
                panelGraf.Invalidate();
            }
            if (fourFlag)
            {
                fourRightLocation.X = e.X;
                fourRightLocation.Y = e.Y;
                fourFlag = false;
                panelGraf.Invalidate();
            }
            if (zeroFlag)
            {
                zeroLocation.X = e.X;
                zeroLocation.Y = e.Y;
                zeroFlag = false;
                panelGraf.Invalidate();
            }
        }

        bool yFlag = false, xFlag = false, threeTopFlag = false, threeRightFlag = false, fourFlag = false, zeroFlag = false,
            twoLeftFlag = false, twoBottomFlag = false;

        private void TimerChangeFont_Tick(object sender, EventArgs e)
        {
            if (fontIndex < fontFamilies.Count)
            {
                family = fontFamilies[fontIndex];
                fontIndex++;
                panelGraf.Invalidate();
            }
            else fontIndex = 0;
        }

        int fontIndex = 0;

        List<FontFamily> fontFamilies = new List<FontFamily>() { };
        private void FillFontFamiliesList()
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                fontFamilies.Add(oneFontFamily);
            }
        }
        int r = 0, g = 0, b = 0;

        // При наведении на пересечение закрашиваем его зеленым цветом
        private Color ReturnColor()
        {
            if (r == 0 && g == 0 && b == 0)
                g = 225;
            return Color.FromArgb(r, g, b);
        }
    }
    class Figure
    {
        public GraphicsPath Path = new GraphicsPath();

        public Region Region
        {
            get { return new Region(Path); }
        }
    }
}

