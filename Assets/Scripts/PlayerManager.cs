using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
  public int Floor = 1;
  public Vector2 Position = new Vector2();

	// Use this for initialization
	void Start () {
    transform.position = new Vector3(Position.x * 64, Position.y * -64, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
