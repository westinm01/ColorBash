using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Rigidbody2D rb;
    protected virtual void takeDamage(){
		Destroy(this.gameObject);
	}

	protected virtual void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Player"){
			takeDamage();
		}
	}
}
