using UnityEngine;
using System.Collections;

public class Buttongame_Dash : MonoBehaviour {

    private Character Player_main;
    public float SpeedPrev;
    // Use this for initialization
    void Start () {
        Player_main = GameObject.Find("Character").GetComponent<Character>();
        SpeedPrev = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        SpeedPrev = Player_main.speed;
        Player_main.speed = 100f;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.1f);
        Player_main.speed = SpeedPrev;
    }
}
