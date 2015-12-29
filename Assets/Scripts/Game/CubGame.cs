using UnityEngine;

public class CubGame : MonoBehaviour {

    public int _timeLeft = 30;
    public CharacterController _controller;
    int direct = 0;
    public Vector3 dir = Vector3.zero;

    void Start()
    {
        direct = 0;
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (Time.timeSinceLevelLoad < _timeLeft)
        {
            Reward.Instance._timeHelper = 30 - Time.timeSinceLevelLoad;
            
            dir = transform.TransformDirection(dir);
            dir.x = transform.position.x - 1;

                if (Input.GetKeyDown(KeyCode.A) && direct != -1)
                {
                direct--;
                    dir.z -= 2f;
                }

                if (Input.GetKeyDown(KeyCode.D) && direct != 1)
                {
                    direct++;
                    dir.z += 2f;
            }

            _controller.Move((dir - transform.position) * Time.deltaTime * Singleton.Instance._currentSpeedCube);
        }
        else
        {
            Reward.Instance.ResultGame();
        }
    }

    void OnDestroy()
    {
        Singleton.Instance._currentDistance = (int)(transform.position.x * (-1));
        Singleton.Instance._currentCoin += Reward.Instance._currentCoin;
        Singleton.Instance._currentCrystal += Reward.Instance._currentCrystal;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            Singleton.Instance._currentDeath += 1;
            Application.LoadLevel(Singleton.Instance._chooseMap);
        }
    }

}
