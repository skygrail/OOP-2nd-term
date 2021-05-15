using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lab9
{
    public class ExitRoutedUICommand
    {
        public static RoutedUICommand Exit { get; set; }

        static ExitRoutedUICommand()
        {
            Exit = new RoutedUICommand("Exit", "Exit", typeof(MainWindow));
        }
    }
}
