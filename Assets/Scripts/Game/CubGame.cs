using UnityEngine;

public class CubGame : MonoBehaviour {

    private static float _timeLeft = 30.0f;
    private static bool _destroyHelper;
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
        if (Reward.Instance._timeHelper >= 0)
        {
            Reward.Instance._timeHelper = _timeLeft - Time.timeSinceLevelLoad;
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
            _destroyHelper = true;
        }
    }

    void OnDestroy()
    {
        if (_destroyHelper) {
            Debug.Log("Destroy = " + Reward.Instance._timeHelper);
            Singleton.Instance._currentDistance = (int)(transform.position.x * (-1));
            Singleton.Instance._currentCoin += Reward.Instance._currentCoin;
            Singleton.Instance._currentCrystal += Reward.Instance._currentCrystal;
            _timeLeft = 30.0f;
            _destroyHelper = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            _timeLeft = Reward.Instance._timeHelper;
            Singleton.Instance._currentDeath += 1;
            Application.LoadLevel(Singleton.Instance._chooseMap);
        }
    }

}
