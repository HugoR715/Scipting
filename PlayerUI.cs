using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEnegine.UI;
using TMpro;

public class PlayerUI : MonoBehaviour
{
	public CoinsCounter coinsCount; 
	public Health health;
	public TexMeshProUGUI coinsCounterText;
	public Slider healthSlider;

	void Update(){
		coinsCounterText.text = coinsCount.coins.ToString()
	}

	healthSlider.maxValue = health.maxHealth;
	healthSlider.value = health.currenthelth;

}
