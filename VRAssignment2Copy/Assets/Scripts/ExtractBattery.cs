using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtractBattery : UseItemOnThis
{
    public GameObject Battery, RobotAnimation;
    public AudioSource audio;
    public AudioClip clip;
    public override void DoesntWork()
    {

    }

    public override void FirstUnlockInstance()
    {
        Battery.SetActive(true);
        RobotAnimation.SetActive(false);
        audio.Stop();
        audio.PlayOneShot(clip);

        SetItemAsUsed();
    }

    public override void SubsequentActivation_IfAny()
    {

    }
}
