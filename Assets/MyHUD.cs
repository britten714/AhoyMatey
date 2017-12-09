using UnityEngine;
using UnityEngine.Networking;

public class MyHUD : MonoBehaviour
{
    private NetworkManager networkManager;

	void Start ()
	{
	    networkManager = GetComponent<NetworkManager>();
	}

    public void MyStartHost()
    {
        networkManager.StartHost();
        Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
    }

    void OnStartHost()
    {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
    }
}
