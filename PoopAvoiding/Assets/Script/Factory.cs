using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Factory : MonoBehaviour
{
   [SerializeField] private float maxTime;
   [SerializeField] private GameObject poopObject;


   private void Start()
   {
      StartCoroutine(MakePoop());
   }

   public IEnumerator MakePoop()
   {
      Instantiate(poopObject, new Vector2(Random.Range(-8.55f, 8.55f), 5.7f), quaternion.identity);
      yield return new WaitForSeconds(maxTime);
      StartCoroutine(MakePoop());
   }
}
