using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticleControl : MonoBehaviour
{
    [SerializeField] private bool createDustOnwalk = true;
    [SerializeField] private ParticleSystem dustParticleSystem;

    public void CreateDustParticles()
    {
        if (createDustOnwalk)
        {
            dustParticleSystem.Stop();
            dustParticleSystem.Play();
        }
    }

}
