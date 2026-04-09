using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class NewBehaviourScript : MonoBehaviour {
	[System.Serializable]
	public enum State{	
		isup,
		isdown,
		isenter,
		isexit,
		isdrag,
		isover
	}
	public struct Eventtype{
		public State eventstate;
		public UnityEvent customevent;
	}
	public Eventtype[] tt; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		for (int i = 0; i < tt.Length; i++) {
			if (tt [i].eventstate == State.isup) {
				tt [i].customevent.Invoke ();
			}
		}
	}
	void OnMouseDown(){
		for (int i = 0; i < tt.Length; i++) {
			if (tt [i].eventstate == State.isdown) {
				tt [i].customevent.Invoke ();
			}
		}
	}
	void OnMouseOver(){
		for (int i = 0; i < tt.Length; i++) {
			if (tt [i].eventstate ==State.isover) {
				tt [i].customevent.Invoke ();
			}
		}
	}
	void OnMouseDrag(){
		for (int i = 0; i < tt.Length; i++) {
			if (tt [i].eventstate ==State.isdrag) {
				tt [i].customevent.Invoke ();
			}
		}
	}
	void OnMouseEnter(){
		for (int i = 0; i < tt.Length; i++) {
			if (tt [i].eventstate == State.isenter) {
				tt [i].customevent.Invoke ();
			}
		}
	}
	void OnMouseExit(){
		for (int i = 0; i < tt.Length; i++) {
			if (tt [i].eventstate == State.isexit) {
				tt [i].customevent.Invoke ();
			}
		}
	}

}
