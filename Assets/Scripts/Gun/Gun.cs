using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{

    public Recoil recoil;
    public float damage = 10f;
    public float range = 1000;
    public float fireRate = 15f;
    public float impactForce = 200f;

    public Transform[] origins;
    public GameObject bulletPrefab;


    public bool flashOn = false;

    public float nextTimeToFire = 0f;

    public Rigidbody playerRb;

    public float thrust;

    public float ammo;

    public float currentAmmo;

    public float totalAmmo;

    public float reloadTime;

    public Animator animator;

    public bool reloading = false;

    public TMP_Text ammoCounter;

    public WeaponSwitching ws;

    void Start()
    {
        currentAmmo = ammo;
    }

    // Update is called once per frame
    void Update()
    {
        ammoCounter.text = currentAmmo + " / " + totalAmmo;
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && reloading == false && Time.timeScale > 0f)
        {
        	nextTimeToFire = Time.time + 1f/fireRate;
            if(currentAmmo > 0)
            {
                Shoot();
            }
            else if(totalAmmo > 0)
            {
                StartCoroutine(Reload());
            }
        	flashOn = true;
        }

    }


    void Shoot()
    {
        recoil.Fire();

        foreach (Transform _transform in origins)
        {
            GameObject bulletObject = Instantiate(bulletPrefab, _transform.position, _transform.rotation);
            Bullet bullet = bulletObject.GetComponent<Bullet>();
            bullet.force = _transform.forward;
            currentAmmo -= 1f;
        }

        if (playerRb != null)
        {
            playerRb.AddForce(-origins[0].transform.forward * thrust * Time.fixedDeltaTime, ForceMode.Impulse);
        }
    }

    IEnumerator Reload()
    {
        animator.SetBool("reload", true);
        reloading = true;
        ws.isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        if (totalAmmo > 0)
        {
            currentAmmo = ammo;
            totalAmmo -= ammo;
        }
        else
        {
            currentAmmo = 0;
            totalAmmo = 0;
        }
        animator.SetBool("reload", false);
        yield return new WaitForSeconds(0.1f);
        ws.isReloading = false;
        reloading = false;
    }
}
