using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Test
{
    public class Light
    {
        public float intensity;
        public LightCondition lightCondition;
        public bool shouldBeOn;
        public bool isOn;

        public Light(float intensity, LightCondition lightCondition, bool startOn)
        {
            this.intensity = intensity;
            this.lightCondition = lightCondition;
            shouldBeOn = startOn;
            isOn = shouldBeOn;
        }

        public void ChangeLightState(LightCondition lightState) => this.lightCondition = lightState;

        public void Toggle()
        {
            shouldBeOn = !shouldBeOn;

            if (!shouldBeOn) isOn = false;
        }

        private void Behave()
        {
            switch (lightCondition)
            {
                case LightCondition.Good:
                    GoodLogic();
                    break;
                case LightCondition.SemiBroken:
                    SemibrokenLogic();
                    break;
                case LightCondition.Broken:
                    BrokenLogic();
                    break;
            }
        }

        private void GoodLogic()
        {
            if (!shouldBeOn) return;
            if (isOn) return;

            isOn = true;
        }

        private void SemiBrokenLogic()
        {
            if (!shouldBeOn) return;

            //Tintinear

        }

        private void BrokenLogic()
        {
            if (!shouldBeOn) return;
            if (!isOn) return;

            isOn = false;
        }
    }
}
