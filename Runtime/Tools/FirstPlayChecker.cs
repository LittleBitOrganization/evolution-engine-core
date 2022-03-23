using UnityEngine;

namespace LittleBit.Modules.CoreModule.Tools
{
    public class FirstPlayChecker
    {
        private const int True = 1;
        private const int False = 0;
        private bool _isFirstPlay = false;

        private bool _isInit = false;

        private void Init()
        {
            _isInit = true;
            _isFirstPlay = PlayerPrefs.GetInt("FirstPlay", True) == True;
            PlayerPrefs.SetInt("FirstPlay", False);
        }
    
        public bool IsFirstPlay()
        {
            if (!_isInit)
            {
                Init();
            }
            return _isFirstPlay;
        }
    
    }
}