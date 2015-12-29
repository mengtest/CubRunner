using UnityEngine;
using System.Collections;

public class Coint : MonoBehaviour {
	void Update () {

        transform.Rotate(Vector3.up, 60 * Time.deltaTime);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            Reward.Instance.AdjustCoin(1);
            Destroy(gameObject);
        }
    }
}
