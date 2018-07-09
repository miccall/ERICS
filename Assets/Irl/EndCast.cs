using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;

public class EndCast : MonoBehaviour
{
	public GameObject _Canvas;
	public float speed = 35f ;
	private Transform _title, _button, _cast , img ;
	private bool moveup = false ,bgend = true ;

	private Vector3 _titleOriPos, _castOriPos,_imgPos;
	private float _alphad = 0;
	private void Start()
	{
		img = _Canvas.transform.GetChild(0);
		_imgPos = img.transform.position;
		_title = _Canvas.transform.GetChild(1);
		_titleOriPos = _title.transform.position;
		_button = _Canvas.transform.GetChild(2);
		_cast = _Canvas.transform.GetChild(3);
		_castOriPos = _cast.transform.position;
		
		_title.GetComponent<Text>().color = new Color(1f,1f,1f,0f);
		_button.GetComponent<Text>().color = new Color(1f,1f,1f,0f);
		
	}

	public void OnCastButtonClick()
	{
		moveup = true;
	}

	private void Update()
	{
		if (bgend)
		{
			img.Translate(new Vector3(0,-1,0)*Time.deltaTime*speed*5.0f);
			print(img.transform.position);
			if (img.transform.position.y < 420)
				bgend = false;
		}
		else
		{
			img.Translate(new Vector3(0,-1,0)*Time.deltaTime*speed*0.5f);
			_alphad += 0.2f * Time.deltaTime;
			_title.GetComponent<Text>().color = new Color(1f,1f,1f,_alphad);
			_button.GetComponent<Text>().color = new Color(1f,1f,1f,_alphad);
		}
		if (moveup)
		{
			_title.Translate(new Vector3(0,1,0)*Time.deltaTime*speed);
			_cast.Translate(new Vector3(0,1,0)*Time.deltaTime*speed);
			_button.GetComponent<Text>().color = new Color(1f,1f,1f,0f);
		}

		if (_title.transform.position.y > 1200)
		{
			moveup = false;
			_title.transform.position = _titleOriPos ;
			_cast.transform.position = _castOriPos ;
			_button.GetComponent<Text>().color = new Color(1f,1f,1f,1f);
		}
	}
}
