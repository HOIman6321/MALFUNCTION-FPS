﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{
	public GameObject CrosshairUi;
	public GameObject DieMenuUi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Again()
    {
    	// CrosshairUi.SetActive(true);
    	// DieMenuUi.SetActive(false);
    	// Time.timeScale = 1f;
    	// Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
