using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Material[] mat;
    public Renderer rend;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = mat[0];
	}
	
	

}
