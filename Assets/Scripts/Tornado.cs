using System;
using System.Collections;
using System.Collections.Generic;
using HauntedPSX.RenderPipelines.PSX.Runtime;
using JetBrains.Rider.Unity.Editor;
using UnityEngine;
using UnityEngine.UIElements;

public class Tornado : MonoBehaviour {
  private GameObject ball;
  private Rigidbody ballRigidbody;
  private GameObject spawnPoint;
  
  [SerializeField] private float pullStrength = 0.5f;
  [SerializeField] private int pullDistance = 10;

  private void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Player")) {
      ball.transform.position = spawnPoint.transform.position;
    }
  }
  
  private void Awake() {
    ball = GameObject.FindWithTag("Player");
    spawnPoint = GameObject.FindWithTag("SpawnPoint");
    
    ballRigidbody = ball.GetComponent<Rigidbody>();
  }

  private void PullBallToTornado() {
    print("turned on function");
    ballRigidbody.AddForce((transform.position - ball.transform.position) * pullStrength * Time.fixedTime, ForceMode.Force);
  }
  

  void Update() {
    if (Vector3.Distance(transform.position, ball.transform.position) < pullDistance)
      PullBallToTornado();
  }
}