using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public AudioSource sound;
    int soundOff;
    public ParticleSystem particles;
    public Rigidbody2D player;
    public float speed;
    public GameManager gm;
    public ParticleEmitter pe;

    void Start()
    {
        soundOff = PlayerPrefs.GetInt("SoundOff");
        if (soundOff == 1)
        {
            sound.enabled = false;
        }
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Debug.Log(touch.position.x);
            // sound on and particles on when tapping
            if (soundOff == 0)
            {
                sound.enabled = true;
            }

            pe.DoEmit(particles);
            // x position doesn't change when user touches the screen
            //player.velocity = new Vector2(0, speed * Time.deltaTime);

            float sideOffset = 0;
            if ((touch.position.x / Screen.width * 100) < 40)
            {
                sideOffset = -(50 - (touch.position.x / Screen.width * 100));
            }
            if ((touch.position.x / Screen.width * 100) > 60) {
                sideOffset = (touch.position.x / Screen.width * 100) / 2;
            }
            if ((touch.position.x / Screen.width * 100) >= 40  && (touch.position.x / Screen.width * 100) <=60)
            {
                sideOffset = 0;
            }
            // x position changes when user touches the screen
            player.velocity = new Vector2(3*sideOffset*Time.deltaTime, speed * Time.deltaTime);
            
        }
        if (Input.touchCount <= 0)
        {
            // x position freezes when user doesn't touch screen
            player.velocity = new Vector2(0, player.velocity.y);

            // sound off and particles off when not tapping
            pe.DontEmit(particles);
            if (soundOff == 0)
            {
                sound.enabled = false;
            }

        }

    }
}
