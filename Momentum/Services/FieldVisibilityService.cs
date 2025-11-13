
namespace Momentum.Services
{
    public class FieldVisibilityService
    {
        private bool _globalVisibility = false;
        private readonly Dictionary<string, bool> _fieldVisibilities = new();

        public bool GlobalVisibility 
        { 
            get => _globalVisibility;
            set
            {
                if (_globalVisibility != value)
                {
                    _globalVisibility = value;
                    NotifyVisibilityChanged();
                }
            }
        }

        public bool ShouldShowField(string fieldName)
        {
            bool result;
    
            if (_globalVisibility)
            {
                result = true;
            }
            else
            {
                result = _fieldVisibilities.ContainsKey(fieldName) && _fieldVisibilities[fieldName];
            }
    
            return result;
        }


        public void SetFieldVisibility(string fieldName, bool isVisible)
        {
            _fieldVisibilities[fieldName] = isVisible;
            NotifyVisibilityChanged();
        }

        public bool GetFieldVisibility(string fieldName)
        {
            return _fieldVisibilities.ContainsKey(fieldName) && _fieldVisibilities[fieldName];
        }

        public event Action? OnVisibilityChanged;

        private void NotifyVisibilityChanged()
        {
            OnVisibilityChanged?.Invoke();
        }
    }
}