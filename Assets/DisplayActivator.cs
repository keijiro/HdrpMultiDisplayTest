using UnityEngine;

namespace Evp3
{
    sealed class DisplayActivator : MonoBehaviour
    {
        bool shouldActivateSecondDisplay {
            get {
                // The second display is not available on Editor.
                if (Application.isEditor) return false;

                // Check if the second display actually exists.
                if (Display.displays.Length < 1) return false;

                return true;
            }
        }

        void Start()
        {
            if (shouldActivateSecondDisplay) Display.displays[1].Activate();
        }
    }
}
