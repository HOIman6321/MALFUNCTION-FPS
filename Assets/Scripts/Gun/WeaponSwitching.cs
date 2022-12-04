using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
	public int selectedWeapon = 0;

    public GameObject weaponHolder;

    public bool isReloading = false;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
    	int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f && Time.timeScale > 0f && isReloading == false)
        {
        	if (selectedWeapon >= transform.childCount - 1)
        	{
        		selectedWeapon = 0;
        	} else
        	{
        		selectedWeapon++;
        	}
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f && Time.timeScale > 0f && isReloading == false)
        {
        	if (selectedWeapon <= 0)
        	{
        		selectedWeapon = transform.childCount - 1;
        	} else
        	{
        		selectedWeapon--;
        	}
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && Time.timeScale > 0f && isReloading == false)
        {
            selectedWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2 && Time.timeScale > 0f && isReloading == false)
        {
            selectedWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3 && Time.timeScale > 0f && isReloading == false)
        {
            selectedWeapon = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4 && Time.timeScale > 0f && isReloading == false)
        {
            selectedWeapon = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5) && transform.childCount >= 5 && Time.timeScale > 0f && isReloading == false)
        {
            selectedWeapon = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6) && transform.childCount >= 6 && Time.timeScale > 0f && isReloading == false)
        {
            selectedWeapon = 5;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
        	SelectWeapon();
        }
    }

    void SelectWeapon ()
    {
    	int i = 0;
    	foreach (Transform weapon in transform)
    	{
    		if (i == selectedWeapon)
    		{
    			weapon.gameObject.SetActive(true);
    		} else
    		{
    			weapon.gameObject.SetActive(false);
    		}


    		i++;
    	}
    }
}
