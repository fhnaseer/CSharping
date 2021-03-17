﻿using System;
using System.Windows.Input;

namespace Framework.Wpf.Helpers
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }

    //public class RelayCommand<T> : ICommand
    //{
    //    private readonly Action<T> _execute;

    //    private readonly Predicate<bool> _canExecute;

    //    public RelayCommand(Action<T> execute)
    //        : this(execute, null) { }

    //    public RelayCommand(Action<T> execute, Predicate<bool> canExecute)
    //    {
    //        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
    //        _canExecute = canExecute;
    //    }

    //    [DebuggerStepThrough]
    //    public bool CanExecute(object parameter)
    //    {
    //        return _canExecute == null || _canExecute();
    //    }

    //    public event EventHandler CanExecuteChanged
    //    {
    //        add => CommandManager.RequerySuggested += value;
    //        remove => CommandManager.RequerySuggested -= value;
    //    }

    //    public void Execute(T parameter) { _execute(parameter); }
    //}
}
