using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ButtonActionQuit : ButtonAction
    {
        protected override void DoAction()
        {
            // Quit in build
            Application.Quit();
            
            // Quit in the editor
#if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
#endif
        }
    }
}
