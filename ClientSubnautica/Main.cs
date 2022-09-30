﻿using HarmonyLib;
using QModManager.API.ModLoading;
using System;
using System.Reflection;

namespace ClientSubnautica
{
    [QModCore]
    public static class MainPatcher
    {
        public static string location;
        [QModPatch]
        public static void Patch()
        {
            location = AppDomain.CurrentDomain.BaseDirectory;

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string text = "dam_" + executingAssembly.GetName().Name;
            new Harmony(text).PatchAll(executingAssembly);
        }
    }
}