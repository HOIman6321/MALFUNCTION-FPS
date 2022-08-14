using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Player player;
    public Transform playerTransform;

    public Slider healthSlider;

    public LayerMask playerMask;

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = player.health;

        if(playerTransform.position.y < -50)
        {
            player.Die();
        }
        if(player.health <= 0)
        {
            player.Die();
        }
    }
}
