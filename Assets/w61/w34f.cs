//      _
//    _| |_
//   [__ __]
//     | |
//     |_|
//      _
//     ] [
//    [___]
//     | |
//     |_|
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w34f : MonoBehaviour
{
    bool hasAnimated;
    public bool transformspot;
    public bool Loop;
    public bool PlayerActivated;
    public float speed = 0.001f;
    public float delayo = 0;
    public float songhnstart = 0;
    public bool appear;
    public AudioClip Sound;
    public AudioClip[] Sounds;
    public float SoundDelay;
    public float Volume = 1;
    public bool AllowSameSoundsToPlayAtDSameTiem = false;
    public float TiemUltilTheSoundCanPlayAgain = 0.05f;

    Vector3 orgin = new Vector3(0, 0, 0);
    public AnimationClip Animatioon;
    int e;
    float delay;
    bool redy;
    public float far;
    public AnimationClip IdleAnimation;
    public bool RandomizeIdleAnimationStartFrame;
    void Start()
    {
        animate w = gameObject.AddComponent<animate>();
        w.transformspot = transformspot;
        w.Loop = Loop;
        w.speed = speed;
        w.delayo = delayo;
        w.songhnstart = songhnstart;
        w.appear = appear;
        w.Sound = Sound;
        w.Sounds = Sounds;
        w.SoundDelay = SoundDelay;
        w.Volume = Volume;
        w.AllowSameSoundsToPlayAtDSameTiem = AllowSameSoundsToPlayAtDSameTiem;
        w.TiemUltilTheSoundCanPlayAgain = TiemUltilTheSoundCanPlayAgain;
        w.Animatioon = Animatioon;
        w.far = far;
        w.IdleAnimation = IdleAnimation;
        w.RandomizeIdleAnimationStartFrame = RandomizeIdleAnimationStartFrame;
        Destroy(GetComponent<w34f>());
    }
}
