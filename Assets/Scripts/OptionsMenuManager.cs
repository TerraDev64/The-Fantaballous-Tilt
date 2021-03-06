using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenuManager : MonoBehaviour {

  // public Volume v;
  // private CameraVolume cameraV;

  public TMP_Dropdown resolutionDropdown;
  public AudioMixer audioMixer;


  private Resolution[] resolutions;

  public void SetFramerate(int val) {
    // if (val < 256) {
    //   //cameraV.isFrameLimitEnabled.value = true;
    //   cameraV.frameLimit.value = val;
    // }
    //
    // else
    //   Application.targetFrameRate = -1;
      //cameraV.isFrameLimitEnabled.value = false;
  }

  public void SetVSync(bool isVSync) {
    if (isVSync)
      QualitySettings.vSyncCount = 1;
    else if (!isVSync)
      QualitySettings.vSyncCount = 0;
    print(QualitySettings.vSyncCount);
  }

  public void SetResolution(int val) {
    switch (val) {
      case 0:
        Screen.SetResolution(640, 480, Screen.fullScreen);
        break;
      case 1:
        Screen.SetResolution(800, 600, Screen.fullScreen);
        break;
      case 2:
        Screen.SetResolution(1280, 720, Screen.fullScreen);
        break;
      case 3:
        Screen.SetResolution(1920, 1080, Screen.fullScreen);
        break;
      default:
        Screen.SetResolution(640, 480, Screen.fullScreen);
        break;
    }
  }

  public void SetFullscreen(bool isFullscreen) {
    Screen.fullScreen = isFullscreen;
  }

  public void SetVolume(float sliderVolume) {
    audioMixer.SetFloat("Volume", sliderVolume);
  }

  void Start() {
    // if (v.profile.TryGet<CameraVolume>(out CameraVolume cameraVolume))
    //   cameraV = cameraVolume;
    //   resolutions = Screen.resolutions;
    //   
    //   resolutionDropdown.ClearOptions();
    //
    //   List<string> options = new List<string>();
    //
    //   for (int i = 0; i < resolutions.Length; i++) {
    //     string option = resolutions[i].width + " x " + resolutions[i].height;
    //     options.Add(option);
    //   }
    //   
    //   resolutionDropdown.AddOptions(options);
  }

  void Update() {
  }
}