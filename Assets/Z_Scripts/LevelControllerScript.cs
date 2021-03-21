using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControllerScript : MonoBehaviour
{

	[SerializeField] FlashImageScript _flashImage = null;
	[SerializeField] Color _newColor = Color.red;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
	{
		_flashImage.StartFlash(.25f, .5f, _newColor);
	}
    }
}
