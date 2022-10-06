using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Factory : MonoBehaviour
{
   [SerializeField] private float maxTime;
   [SerializeField] private float currentTime;
   [SerializeField] private GameObject poopObject;


   private void Update()
   {
      currentTime += Time.deltaTime;
      if (currentTime >= maxTime)
      {
         Instantiate(poopObject, new Vector2(Random.Range(-8.55f, 8.55f), 5.7f), quaternion.identity);
         currentTime = 0;
      }
   }
}
