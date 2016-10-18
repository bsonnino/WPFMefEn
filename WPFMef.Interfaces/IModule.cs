using System.Windows;

namespace WPFMef.Interfaces
{
    public interface IModule
    {
        string Title { get; }
        UIElement Content { get; } 
    }
}