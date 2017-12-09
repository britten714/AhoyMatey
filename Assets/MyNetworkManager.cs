using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{
    public void MyStartHost()
    {
        StartHost();
        Debug.Log(Time.timeSinceLevelLoad + " Starting Host.");
    }

    public override void OnStartHost()      //OnStartHost() 메서드가 아마도 virtual (또는 abstract)라서 오버라이딩이 가능한 것 같다. 어떤 메서드가 virtual인지 아닌지 어떻게 파악하는 지는 모르겠다. 다만 이 OnStartHost()는 이벤트함수 같은데 정확한 작동원리는 모르겠다... host 가 start 할 때 실행된다고 하는데 그걸 어떻게 인식한거지? 아마 StartHost() 메서드 때문인 것 같긴 한데... 
    {                                       
        Debug.Log(Time.timeSinceLevelLoad + " Host started.");
    }

    public override void OnStartClient(NetworkClient myClient)      //클라이언트가 start 했을 때 실행되는 이벤트 함수. 
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client Start Requested.");
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)        //클라이언트가 connect 됐을 때 실행되는 이벤트 함수. 
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
