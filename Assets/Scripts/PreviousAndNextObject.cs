using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PreviousAndNextObject : MonoBehaviour
{
    public GameObject[] rooms;

    public Button _prev;
    public Button _next;

    public int _index;
    public TextMeshProUGUI _roomNameText;

    void Start()
    {
        _index = 0;
        RoomActive(_index);
        _roomNameText.text = rooms[_index].name.ToString();
        _prev.interactable = false;
    }

    void Update()
    {
        
    }

    public void ButtonPrevNext(bool Next)
    {
        if (Next)
        {
            _index++;
            _prev.interactable = true;
            if (_index < rooms.Length - 1)
            {
                _next.interactable = true;
            }
            else
            {
                _next.interactable = false;
            }
        }
        else
        {
            _index--;
            _next.interactable = true;
            if (_index > 0)
            {
                _prev.interactable = true;
            }
            else
            {
                _prev.interactable = false;
            }
        }
        _roomNameText.text = rooms[_index].name.ToString();

        RoomActive(_index);
    }

    private void RoomActive(int i) 
    {
        foreach (GameObject room in rooms)
        {
            room.SetActive(false);
        }
        rooms[i].SetActive(true);
    }
}
