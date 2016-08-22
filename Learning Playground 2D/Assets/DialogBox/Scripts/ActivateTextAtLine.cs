using UnityEngine;
using System.Collections;

public class ActivateTextAtLine : MonoBehaviour {

	public TextAsset dialog;

	public int startLine;
	public int endAtLine;

	public TextBoxManager textBox;

	public bool destoryOnActivation;
	public bool requireButtonPress;
	private bool waitForPress;

	void Start () {
		textBox = FindObjectOfType<TextBoxManager> ();
	}

	void Update () {
		if (waitForPress && Input.GetKeyDown(KeyCode.J)){
			textBox.ReloadScript (dialog);
			textBox.currentLine = startLine;
			textBox.endAtLine = endAtLine;
			textBox.EnableTextBox ();
			if (destoryOnActivation) {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player" ) {

			if (requireButtonPress) {
				waitForPress = true;
				return;
			}
			textBox.ReloadScript (dialog);
			textBox.currentLine = startLine;
			textBox.endAtLine = endAtLine;
			textBox.EnableTextBox ();
			if (destoryOnActivation) {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "Player") {
			waitForPress = false;
		}
	}
}
