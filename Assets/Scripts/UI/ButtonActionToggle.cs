using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class ButtonActionToggle : ButtonAction
    {
        [SerializeField] private List<GameObject> objectsToToggleOff = new List<GameObject>();
        [SerializeField] private List<GameObject> objectsToToggleOn = new List<GameObject>();
        
        protected override void DoAction()
        {
            foreach(var obj in objectsToToggleOff) obj.SetActive(false);
            foreach(var obj in objectsToToggleOn) obj.SetActive(true);
        }
    }
}