using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
	public AudioMixer mixer;
	public Slider slider;

	public TMP_Dropdown resolutionDropdown;

	Resolution[] resolutions;

	int boolToInt(bool val)
	{
	    if (val)
	        return 1;
	    else
	        return 0;
	}

	bool intToBool(int val)
	{
	    if (val != 0)
	        return true;
	    else
	        return false;
	}

	void Start()
	{
		slider.value = PlayerPrefs.GetFloat("Volume", 0.75f);
		resolutions = Screen.resolutions;

		resolutionDropdown.ClearOptions();

		List<string> options = new List<string>();

		int currentResolutionIndex = 0;

		for (int i = 0; i < resolutions.Length; i++)
		{
			string option = resolutions[i].width + "x" + resolutions[i].height;
			options.Add(option);

			if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
			{
				currentResolutionIndex = i;
			}
		}

		resolutionDropdown.AddOptions(options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue();
	}

	public void SetResolution (int resolutionIndex)
	{
		Resolution resolution = resolutions[resolutionIndex];
		Screen.SetResolution(resolution.width, resolution.height, true);
	}

	public void Apply()
	{
		SetResolution(resolutionDropdown.value);
	}

	void Update()
	{
		SetVolume(slider.value);
	}

	public void SetVolume(float volume)
	{
		mixer.SetFloat("Volume", volume);
		PlayerPrefs.SetFloat("Volume", volume);
	}
}
