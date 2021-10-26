using UsefulUtilitiesDependencyInjection.Models;

namespace UsefulUtilitiesDependencyInjection.ViewModel
{
    public class IndexViewModel
    {
        public string Color { get; }
        
        public IndexViewModel(string color)
        {
            Color = color;
        }
    }
}