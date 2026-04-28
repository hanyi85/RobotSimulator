using System;
using System.Windows;
using System.Windows.Media;

namespace CPCRobotSimulator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateRobotStatus(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txtDistance == null) return;

            double x = sldX.Value;
            double y = sldY.Value;
            double z = sldZ.Value;

            // 計算 3D 空間距離
            double distance = Math.Sqrt(x * x + y * y + z * z);
            txtDistance.Text = distance.ToString("F1");

            if (distance > 450)
            {
                // 警報狀態
                elpStatus.Fill = Brushes.Red;
                txtAlert.Text = "LIMIT EXCEEDED";
                txtAlert.Foreground = Brushes.Red;
                // 讓距離數字變色
                txtDistance.Foreground = Brushes.Red;
            }
            else
            {
                // 正常狀態
                elpStatus.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#34D399"));
                txtAlert.Text = "SYSTEM READY";
                txtAlert.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#34D399"));
                txtDistance.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#38BDF8"));
            }
        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            sldX.Value = 0;
            sldY.Value = 0;
            sldZ.Value = 0;
        }
    }
}