using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 _cameraOffset = new Vector3(0, 7, -10);

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + _cameraOffset;
    }
}
