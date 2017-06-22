using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour {

    public GameObject Inicial;
    public GameObject Opciones;
    public Slider SfxSlider;
    public Slider MusicSlider;
    public AudioSource Music;


	void Start () {

        PlayerPrefs.SetFloat("MusicVolume",Music.volume);
	}
    public void OptionsMenu() {
        Inicial.SetActive(false);
        Opciones.SetActive(true);
    }
	
	public void AcceptChanges (){
        PlayerPrefs.SetFloat("MusicVolume", MusicSlider.value);
        Inicial.SetActive(true);
        Opciones.SetActive(false);
    }
    public void CancelChanges()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        Inicial.SetActive(true);
        Opciones.SetActive(false);
    }
    public void SetMusicVolume(float value) {
        Music.volume = MusicSlider.value;
    }
}
