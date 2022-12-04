using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCrosshairColor : MonoBehaviour
{
    [SerializeField] private GameObject crosshair;
    public Image[] crosshairImages;
    private float regularFOV;
    private float currentFOV = 60f;
    public float aimingSpeed = 10f;

    private void Start()
    {
        regularFOV = this.gameObject.GetComponentInParent<Camera>().fieldOfView;
    }

    private void Update()
    {
        if(crosshair.GetComponent<Crosshair>().Aiming)
        {
            currentFOV = Mathf.Lerp(currentFOV, regularFOV - 30f, Time.deltaTime * aimingSpeed);
        }
        else
        {
            currentFOV = Mathf.Lerp(currentFOV, regularFOV, Time.deltaTime * aimingSpeed);
        }

        this.gameObject.GetComponentInParent<Camera>().fieldOfView = currentFOV;

        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 200f))
        {
            if(hit.transform.gameObject.CompareTag("Enemy"))
            {
                foreach(Image crosshairImage in crosshairImages)
                {
                    crosshairImage.color = new Color(1f, 141/255f, 0f, 1f);
                }
            }
            else
            {
                foreach(Image crosshairImage in crosshairImages)
                {
                    crosshairImage.color = new Color(0f, 0f, 0f, 1f);
                }
            }
        }
        else
        {
            foreach(Image crosshairImage in crosshairImages)
            {
                crosshairImage.color = new Color(0f, 0f, 0f, 1f);
            }
        }
    }
}
