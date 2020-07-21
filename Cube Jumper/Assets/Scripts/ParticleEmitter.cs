using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEmitter : MonoBehaviour
{
    public void DoEmit(ParticleSystem particles)
    {
        var em = particles.emission;
        em.enabled = true;
    }

    public void DontEmit(ParticleSystem particles)
    {
        var em = particles.emission;
        em.enabled = false;
    }
}
