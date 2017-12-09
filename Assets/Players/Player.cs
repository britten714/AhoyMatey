using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour
{
    private Vector3 inputValue;

	void Update () {
	    if (!isLocalPlayer)     //Unity API 따라한 것. 로컬플레이어일 경우에만 아래 조작이 가능하도록 한 것. isLocalPlayer가 NetworkBehaviour를 상속하기 때문에 namespace 바꿔줬다. 이렇게 하면 호스트에서는 호스트 플레이어만, 클라이언트에서는 클라이언트 플레이어만 조작 가능하다. 당연히 클라이언트끼리의 구분도 되겠지. 
	    {
	        return;
	    }
	    inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
	    inputValue.y = 0f;
	    inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(inputValue);
	}
}
