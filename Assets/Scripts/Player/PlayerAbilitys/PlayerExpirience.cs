using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExpirience : MonoBehaviour
{
    [SerializeField] private int _currentLevel = 1;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private PlayerEnergy _playerEnergy;

    private int _currentExpirienceValue;
    private int _maxExpirienceValue = 100;

    public void AddExpirience(int value)
    {
        if(_currentExpirienceValue + value >= _maxExpirienceValue)
        {
            LevelUp();
            _currentExpirienceValue = _currentExpirienceValue + value - _maxExpirienceValue;
        }
        else
        {
            _currentExpirienceValue += value;
        }
    }

    private void LevelUp()
    {
        _currentLevel++;
    }
}
