using UnityEngine;
using System.Collections;

public class ZoomController : MonoBehaviour {

	[SerializeField] Transform target1 = null, target2 = null;
	[SerializeField] Vector2 offset = new Vector2(1, 1);

	private float screenAspect = 0; 
	private Camera _camera = null;

	void Awake()
	{
		screenAspect = (float)Screen.height / Screen.width;
		_camera = GetComponent<Camera> ();
	}

	void Update () 
	{
		UpdateCameraPosition ();
		UpdateOrthographicSize ();
		
		if (_camera.fieldOfView < 4f) {
			_camera.fieldOfView = 4f;
		}

		if(_camera.fieldOfView > 6f){
			_camera.fieldOfView = 6f;
		}
	}

	void UpdateCameraPosition()
	{
		// 2点間の中心点からカメラの位置を更新
		Vector3 center = Vector3.Lerp (target1.position, target2.position, 0.5f);
		transform.position = center + Vector3.forward * -10;
	}

	void UpdateOrthographicSize()
	{
		// ２点間のベクトルを取得
		Vector3 targetsVector = AbsPositionDiff (target1, target2) + (Vector3)offset;

		// アスペクト比が縦長ならyの半分、横長ならxとアスペクト比でカメラのサイズを更新
		float targetsAspect = targetsVector.y / targetsVector.x;
		float targetOrthographicSize = 0;
		if ( screenAspect < targetsAspect) {
			targetOrthographicSize = targetsVector.y * 0.5f;
		} else {
			targetOrthographicSize = targetsVector.x * (1/_camera.aspect) * 0.5f;
		}
		_camera.orthographicSize =  targetOrthographicSize;
	}
	
	Vector3 AbsPositionDiff(Transform target1, Transform target2)
	{
		Vector3 targetsDiff = target1.position - target2.position;
		return new Vector3(Mathf.Abs(targetsDiff.x), Mathf.Abs(targetsDiff.y));
	}
}