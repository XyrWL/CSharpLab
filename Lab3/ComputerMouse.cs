using System;
using System.Collections.Generic;

namespace Lab3
{
    public class ComputerMouse
    {        
        int dpi;
        double sensitivityX;
        double sensitivityY;
        List<MouseButton> mouseButtons = new List<MouseButton>();

        public void SetDpi(int dpi)
        {
            if (dpi >= 0)
                this.dpi = dpi;
            else
                throw new ArgumentException("Value is not a positive integer", "dpi");
        }
        public int GetDpi()
        {
            return dpi;
        }
        public void SetSensitivityX(double sensitivityX)
        {
            this.sensitivityX = sensitivityX;
        }
        public double GetSensitivityX()
        {
            return sensitivityX;
        }
        public void SetSensitivityY(double sensitivityY)
        {
            this.sensitivityY = sensitivityY;
        }
        public double GetSensitivityY()
        {
            return sensitivityY;
        }

        public void AddMouseButton(MouseButton mouseButton)
        {
            if (mouseButton != null)
                mouseButtons.Add(mouseButton);
            else
                throw new ArgumentNullException("mouseButton");
        }
        public void ClearMouseButtons()
        {
            mouseButtons.Clear();
        }

        public double GetMouseSpeedX()
        {
            return sensitivityX * dpi;
        }
        public double GetMouseSpeedY()
        {
            return sensitivityY * dpi;
        }        
        public int GetNumberOfButtons()
        {
            return mouseButtons.Count;
        }
        public int GetNumberOfScrollableButtons()
        {
            int numberScrollableButtons = 0;
            foreach (MouseButton button in mouseButtons)
            {
                if (button.GetIsScrollable())
                    numberScrollableButtons++;
            }
            return numberScrollableButtons;
        }
        public int GetNumberOfDoubleClickableButtons()
        {
            int numberDoubleClickableButtons = 0;
            foreach (MouseButton button in mouseButtons)
            {
                if (button.GetIsDoubleClickable())
                    numberDoubleClickableButtons++;
            }
            return numberDoubleClickableButtons;
        }
    }
}
