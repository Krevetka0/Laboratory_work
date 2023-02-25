﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace _4Styles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = 10;
            try
            {
                N = Convert.ToInt32(FigureCount.Text);
            }
            catch (Exception ee)
            {
                this.Title = "Только целое число!";
            }
            GenerateShapes(N);
        }
        private void GenerateShapes(int N)
        {
            Random rndShapeType = new Random(DateTime.Now.Millisecond);
            Random rndStyle = new Random(DateTime.Now.Second);
            Random rndPosition = new Random(DateTime.Now.Minute);
            Random rndSize = new Random(DateTime.Now.Minute);

            for (int i = 0; i < N; i++)
            {
                Shape currentShape;
                int ShapeType = rndShapeType.Next(0,2);
                if (ShapeType == 0)
                    currentShape = new Ellipse();
                else
                    currentShape = new Rectangle();
                int ShapeStyle = rndStyle.Next(0, 3) + 1;
                String styleName = "style" + ShapeStyle.ToString();
                Style currentStyle = (Style)this.FindResource(styleName);
                currentShape.Style = currentStyle;

                currentShape.Width = rndSize.Next(10, 200); 
                currentShape.Height = rndSize.Next(10, 100);

                MainCanvas.Children.Add(currentShape);
                Canvas.SetLeft(currentShape, rndPosition.Next(5, 750));
                Canvas.SetTop(currentShape, rndPosition.Next(5, 350));
            }
        }
    }
}
