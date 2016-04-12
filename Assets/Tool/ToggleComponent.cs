using UnityEngine;
using System.Collections;

[System.Serializable]
public class BehavAndKey
{
	public MonoBehaviour behaviour;
	public KeyCode keyCodes;
}

public class ToggleComponent : MonoBehaviour {

	public BehavAndKey[] behavs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < behavs.Length; i++){
			if(Input.GetKeyDown(behavs[i].keyCodes)){
				MonoBehaviour bhv = behavs[i].behaviour;
				bhv.enabled = !bhv.enabled;
			}
		}
	}
}
