using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light spotlight;
    public float intervalo = 2f;

    private float timer;

    void Start()
    {
        timer = intervalo;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spotlight.enabled = !spotlight.enabled;
            timer = intervalo;
        }
    }
}
