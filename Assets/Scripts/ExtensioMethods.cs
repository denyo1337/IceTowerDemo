using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensioMethods
{
  public static void ChangeVolume(this Sound  manager, float volume)
    {
        manager.volume = volume;
    }
}
