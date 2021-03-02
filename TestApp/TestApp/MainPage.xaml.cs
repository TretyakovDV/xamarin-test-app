using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();

            progressBar1.ProgressTo(1, 5000, Easing.BounceOut);
            progressBar2.ProgressTo(1, 5000, Easing.CubicOut);
            progressBar3.ProgressTo(1, 5000, Easing.SpringIn);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = $"You clicked {++count} times!";
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            Stepper_Label.Text = value.ToString();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }
}
