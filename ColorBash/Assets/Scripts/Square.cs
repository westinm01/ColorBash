using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    protected virtual void takeDamage(){
		Destroy(this.gameObject);
	}

	protected virtual void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player"){
            Debug.Log("Collided with Player");
			takeDamage();
		}
	}
}
