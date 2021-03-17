using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleApp.UI.Behaviors
{
    public class PickerItemSelectedToCommandBehavior : BehaviorBase<Picker>
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(PickerItemSelectedToCommandBehavior), null);
        
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(Picker bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.SelectedIndexChanged += OnItemSelected;
        }

        private void OnItemSelected(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedItem = picker.SelectedItem as string;

            if (Command != null)
            {
                if (Command.CanExecute(selectedItem))
                {
                    Command.Execute(selectedItem);
                }
            }
        }

        protected override void OnDetachingFrom(Picker bindable)
        {
            bindable.SelectedIndexChanged -= OnItemSelected;

            base.OnDetachingFrom(bindable);
        }
    }
}
