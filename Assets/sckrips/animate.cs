using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Animations;
public class animate : MonoBehaviour
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
    AnimationClipPlayable ClipAnimation;
    float delay;
    bool redy;
    public float far;
    public PlayableGraph graf;
    public AnimationPlayableOutput output;

    public AnimationClip IdleAnimation;
    public bool RandomizeIdleAnimationStartFrame;
    AnimationMixerPlayable mixer;
    AnimationClipPlayable Idle;
    
}