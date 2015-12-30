using UnityEngine;

public class CubGame : MonoBehaviour {

    static float _timeLeft = 30.0f;
    public CharacterController _controller;
    int direct = 0;
    public Vector3 dir = Vector3.zero;
    private static bool _destroyHelper = false;

    void Start()
    {
        direct = 0;
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Time.timeSinceLevelLoad;
        Reward.Instance._timeHelper = _timeLeft - Time.timeSinceLevelLoad;
        Debug.Log("Update = " + Reward.Instance._timeHelper);
        if (Reward.Instance._timeHelper > 0)
        {
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
            _destroyHelper = true;
            Reward.Instance.ResultGame();
        }
    }

    void OnDestroy()
    {
        if (_destroyHelper)
        {
            Debug.Log("Destroy = " + Reward.Instance._timeHelper);
            Singleton.Instance._currentDistance = (int)(transform.position.x * (-1));
            Singleton.Instance._currentCoin += Reward.Instance._currentCoin;
            Singleton.Instance._currentCrystal += Reward.Instance._currentCrystal;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Block")
        {
            Debug.Log("Hit = " + Reward.Instance._timeHelper);
            _timeLeft = Reward.Instance._timeHelper;
            Singleton.Instance._currentDeath += 1;
            Application.LoadLevel(Singleton.Instance._chooseMap);
        }
    }

}
