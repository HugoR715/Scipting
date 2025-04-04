using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public GameObject fierballPrefab
   public Transform attackPoint;


   void Update()
   {
	   if (Input.getMouseButtonDown(0){
		   Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
	   }

}
