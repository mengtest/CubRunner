using UnityEngine;
using System.Collections;

public class Crystal : MonoBehaviour {
	void Update () {
        transform.Rotate(Vector3.up, 60 * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Reward.Instance.AdjustCrystal(1);

            Destroy(gameObject);
        }
    }

}
