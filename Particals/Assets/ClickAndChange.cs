using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndChange: MonoBehaviour {

    ParticleSystem exhaust;
    public Material skybox1;
    public Material skybox2;
    int judge1or2;

    void Start()
    {
        exhaust = GetComponent<ParticleSystem>();
        judge1or2 = 0;
    }


    void Update()
    {
        //exhaust.Play
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2-50, Screen.height/2+150, 200 , 100), "ChangeSence"))
        {
            judge1or2++;
            if(judge1or2 % 2 == 0)
            {
                GameObject.Find("Particle1").GetComponent<ParticleSystem>().Play();
                RenderSettings.skybox = skybox1;
            }else
            {
                GameObject.Find("Particle2").GetComponent<ParticleSystem>().Play();
                GameObject.Find("Ring").GetComponent<ParticleSystem>().Play();
                RenderSettings.skybox = skybox2;
            }
        }
    }
}
