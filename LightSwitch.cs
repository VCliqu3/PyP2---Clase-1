using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Test
{
    public class LightSwitch : IInteractable
    {
        public List<Light> lights;

        public LightSwitch(List<Light> lights)
        {
            this.lights = lights;
        }

        public void Interact()
        {
            foreach(Light light in lights)
            {
                if (light.lightCondition == LightCondition.Broken) return;
                //TurnOn
            }
        }
    } 
}



