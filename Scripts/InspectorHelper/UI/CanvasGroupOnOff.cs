using UnityEngine;

namespace BaseTools.Utils
{
    [RequireComponent(typeof(CanvasGroup))]
    public class CanvasGroupOnOff : MonoBehaviour
    {
        public CanvasGroup Canvas;
        private bool _visible;

        void Reset()
        {
            Canvas = GetComponent<CanvasGroup>();
        }

        /// <summary>
        /// Set The CanvasGroup Visitable and Intractable
        /// </summary>
        public void On()
        {
            _visible = true;
            Canvas.alpha = 1;
            Canvas.interactable = true;
            Canvas.blocksRaycasts = true;
        }

        /// <summary>
        /// Set The CanvasGroup Hiden and not Intractable
        /// </summary>
        public void Off()
        {
            _visible = false;
            Canvas.alpha = 0;
            Canvas.interactable = false;
            Canvas.blocksRaycasts = false;
        }

        /// <summary>
        /// Toggle Between Visible and Hidden
        /// </summary>
        public void Toggle()
        {
            if (_visible)
                Off();
            else
                On();
        }
        
        /// <summary>
        /// Toggle Between Visible and Hidden with an specific Value
        /// </summary>
        /// <param name="visible">true = Show, false = Hide</param>
        public void Toggle(bool visible)
        {
            if (visible)
                On();
            else
                Off();
        }

        /// <summary>
        /// returns the Curret visibility State
        /// </summary>
        /// <returns>true = visible false = hidden</returns>
        public bool GetVisibility()
        {
            return _visible;
        }
    }
}
