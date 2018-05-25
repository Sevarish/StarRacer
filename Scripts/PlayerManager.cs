using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public float shieldTimer = 0.0f;
    public bool isShielded = false;
    bool doOnce = true;
    bool isHit = false;
    int count = 0;
    public SpriteRenderer render;
    public Sprite shielded;
    public Sprite normal;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (isShielded == true)
        {
            render.sprite = shielded;
            
            shieldTimer += Time.deltaTime;
            if (shieldTimer > 5.5f && shieldTimer < 7 && doOnce == true)
            {
                GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp -= 20;
                doOnce = false;
            }
            if (shieldTimer >= 7)
            {
                
                isShielded = false;
                doOnce = true;
            }
        }
        else
        {
            render.sprite = normal;
        }

        


        if (isHit == true)
        {
            count++;
            if (count == 30)
            {
                Destroy(this.gameObject);
                Application.LoadLevel("DeathScreen");
                isHit = false;
                count = 0;
            }
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle" && isShielded == false)
        {
            isHit = true;
        }


    }

    
}
