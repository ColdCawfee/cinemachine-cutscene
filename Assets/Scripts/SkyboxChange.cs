using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SkyboxChange : MonoBehaviour {
    public Color colorStart = Color.blue;
    public Color colorEnd = Color.green;
    public float duration = 1.0F;
    void Update() {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        RenderSettings.skybox.SetColor("_Tint", Color.Lerp(colorStart, colorEnd, lerp));
    }
}