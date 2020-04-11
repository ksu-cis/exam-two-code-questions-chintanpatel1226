using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        private FruitFilling fruit;
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get => fruit;
            set
            {
                fruit = value;
                InvokePropertyChanged("Name");
                InvokePropertyChanged("Fruit");
            }
        }

        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get => withIceCream;
            set
            {
                withIceCream = value;
                InvokePropertyChanged("Price");
                InvokePropertyChanged("WithIceCream");
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }
        public string Name
        {
            get
            {
                switch (Fruit)
                {
                    case FruitFilling.Blueberry:
                        return "Blueberry Cobbler";
                    case FruitFilling.Cherry:
                        return "Cherry Cobbler";
                    case FruitFilling.Peach:
                        return "Peach Cobbler";
                    default:
                        throw new NotImplementedException("No cobbler found.");
                }
            }
        }
    }
}
