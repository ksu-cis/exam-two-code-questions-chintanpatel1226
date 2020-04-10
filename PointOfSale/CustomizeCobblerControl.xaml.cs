using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void FruitFillingSelection_Clicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is Cobbler cobbler)
            {
                if (sender is RadioButton rb)
                {
                    switch (rb.Tag)
                    {
                        case "Blueberry":
                            cobbler.Fruit = FruitFilling.Blueberry;
                            break;
                        case "Cherry":
                            cobbler.Fruit = FruitFilling.Cherry;
                            break;
                        case "Peach":
                            cobbler.Fruit = FruitFilling.Peach;
                            break;
                        default:
                            throw new NotImplementedException("Flavor not available");
                    }
                }
            }
        }

        private void RadioButtonSelection_Loaded(object sender, RoutedEventArgs args)
        {
            if (DataContext is Cobbler cobbler)
            {
                switch (cobbler.Fruit)
                {
                    case FruitFilling.Blueberry:
                        BlueberryButton.IsChecked = true;
                        break;
                    case FruitFilling.Cherry:
                        CherryButton.IsChecked = true;
                        break;
                    case FruitFilling.Peach:
                        PeachButton.IsChecked = true;
                        break;
                }
            }
        }
    }
}
