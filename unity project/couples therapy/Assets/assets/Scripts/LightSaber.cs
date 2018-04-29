using UnityEngine;
using System.Collections;

public class LightSaber : SteamVR_InteractableObject
{
    private bool beamActive = false;
    private Vector2 beamLimits = new Vector2(0f, 1.2f);
    private float currentBeamSize;
    private float beamExtendSpeed = 0;

    private GameObject blade;
    public CapsuleCollider bladeCollider;

    private Light light;

    private AudioSource soundLoop;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        beamExtendSpeed = 15f;
        Debug.Log("lightSaber on");
        var sound = this.transform.Find("SaberStart").GetComponent<AudioSource>();
        sound.Play();

        soundLoop = this.transform.Find("SaberLoop").GetComponent<AudioSource>();
        soundLoop.PlayDelayed(0.5f);

        light.enabled = true;

        bladeCollider.enabled = true;
    }

    public override void StopUsing(GameObject usingObject)
    {
        base.StopUsing(usingObject);
        beamExtendSpeed = -15f;
        var sound = this.transform.Find("SaberStop").GetComponent<AudioSource>();
        soundLoop.Stop();
        sound.Play();
        light.enabled = false;

        bladeCollider.enabled = false;
    }

    protected override void Start()
    {
        base.Start();
        blade = this.transform.Find("Blade").gameObject;
        currentBeamSize = beamLimits.x;
        SetBeamSize();
         light = blade.transform.Find("PointLight").GetComponent<Light>();
        light.enabled = false;
    }

    private void SetBeamSize()
    {
        blade.transform.localScale = new Vector3(1f, currentBeamSize, 1f);
        beamActive = (currentBeamSize >= beamLimits.y ? true : false);
    }

    private void Update()
    {
        currentBeamSize = Mathf.Clamp(blade.transform.localScale.y + (beamExtendSpeed * Time.deltaTime), beamLimits.x, beamLimits.y);
        SetBeamSize();
    }
}
