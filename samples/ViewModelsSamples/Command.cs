﻿#pragma warning disable 67

using System;
using System.Windows.Input;

namespace ViewModelsSamples;

public class Command : ICommand
{
    private readonly Action<object?> _command;
    public event EventHandler? CanExecuteChanged { add { } remove { } }

    public Command(Action<object?> command)
    {
        _command = command;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _command(parameter);
    }
}
