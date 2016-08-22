﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text currentText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public PlayerMove player;

	public bool isActive;
	public bool stopPlayerMovement;

	private bool isTyping = false;
	private bool cancelTyping = false;

	public float typeSpeed;

	void Start () {
		player = FindObjectOfType<PlayerMove>();
		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}
		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}
		if (isActive) {
			EnableTextBox ();
		} else {
			DisableTextBox ();
		}
	}

	void Update () {
		if (!isActive) {
			return;
		}

		// currentText.text = textLines [currentLine];
		if (Input.GetKeyDown (KeyCode.Return)) {
			if(!isTyping)
			{
				currentLine += 1;
				if (currentLine > endAtLine) {
					DisableTextBox ();
				} else {
					StartCoroutine(TextScroll(textLines[currentLine]));
				}
			} else if (isTyping && !cancelTyping) {
				cancelTyping = true;
			}
		}
	}

	private IEnumerator TextScroll (string lineOfText) {
		int letter = 0;
		currentText.text = "";
		isTyping = true;
		cancelTyping = false;
		while (isTyping && !cancelTyping && (letter < lineOfText.Length -1)){

			currentText.text += lineOfText[letter];
			letter += 1;
			yield return new WaitForSeconds(typeSpeed);
		}
		currentText.text = lineOfText;
		isTyping = false;
		cancelTyping = false;
	}

	public void EnableTextBox(){
		isActive = true;
		textBox.SetActive (true);
		if (stopPlayerMovement) {
			player.canMove = false;
		}
		StartCoroutine(TextScroll(textLines[currentLine]));
	}

	public void DisableTextBox(){
		isActive = false;
		textBox.SetActive (false);
		player.canMove = true;
	}

	public void ReloadScript(TextAsset dialog){
		if (dialog != null) {
			textLines = new string[1];
			textLines = (dialog.text.Split ('\n'));
		}
	}
}
