﻿using Lol.Support.Local.Models;
using System;
using System.Collections.Generic;

namespace Lol.Support.Local.Helpers
{
    public class MenuService
    {
        public event EventHandler<MenuChangedEventArgs> MenuChanged;

        public void ChangeMenu(int menuId)
        {
            MenuChanged?.Invoke(this, new MenuChangedEventArgs(menuId));
        }

        public List<MainMenuInfo> GetMenus()
        {
            List<MainMenuInfo> source = new()
            {
                new MainMenuInfo(0, "HOME", "TEXT"),
                new MainMenuInfo(1, "TFT", "TEXT"),
                new MainMenuInfo(2, "CLASH", "TEXT"),
                new MainMenuInfo(3, "Profile", "ICON"),
                new MainMenuInfo(4, "Collection", "ICON"),
                new MainMenuInfo(5, "Loot", "ICON"),
                new MainMenuInfo(6, "My Shop", "ICON"),
                new MainMenuInfo(7, "Store", "ICON"),
                new MainMenuInfo(8, "GAME", "TEXT")
            };
            return source;
        }

        public List<SubMenuInfo> GetSubMenus()
        {
            List<SubMenuInfo> source = new()
            {
                new SubMenuInfo(9, 0, "OVERVIEW"),
                new SubMenuInfo(10, 0, "PRESEASON"),
                new SubMenuInfo(11, 0, "PATCH NOTES"),
                new SubMenuInfo(44, 0, "AVATAR CREATE"),

                new SubMenuInfo(12, 2, "HUB"),
                new SubMenuInfo(13, 2, "FIND A TEAM"),
                new SubMenuInfo(14, 2, "BRACKET"),
                new SubMenuInfo(15, 2, "WINNERS"),
                new SubMenuInfo(16, 2, "AWARDS"),

                new SubMenuInfo(17, 4, "CHAMPIONS"),
                new SubMenuInfo(18, 4, "SKINS"),
                new SubMenuInfo(19, 4, "EMOTES"),
                new SubMenuInfo(20, 4, "RUNES"),
                new SubMenuInfo(21, 4, "SPELLS"),
                new SubMenuInfo(22, 4, "ITEMS"),
                new SubMenuInfo(23, 4, "ICONS"),
                new SubMenuInfo(24, 4, "WARDS"),
                new SubMenuInfo(25, 4, "CHROMAS"),

                new SubMenuInfo(26, 7, "FEATURED"),
                new SubMenuInfo(27, 7, "CHAMPIONS"),
                new SubMenuInfo(28, 7, "SKINS"),
                new SubMenuInfo(29, 7, "TFT"),
                new SubMenuInfo(30, 7, "LOOT"),
                new SubMenuInfo(31, 7, "ACCESSORIES"),

                new SubMenuInfo(32, 3, "SUMMARY"),
                new SubMenuInfo(33, 3, "MATCH HISTORY"),
                new SubMenuInfo(34, 3, "RANKED"),
                new SubMenuInfo(35, 3, "HIGHLIGHTS"),
                new SubMenuInfo(36, 3, "STATS"),

                new SubMenuInfo(37, 8, "PVP"),
                new SubMenuInfo(38, 8, "CO-OP VS. AI"),
                new SubMenuInfo(39, 8, "TRAINING"),
                new SubMenuInfo(40, 8, "CREATE CUSTOM"),
                new SubMenuInfo(41, 8, "JOIN CUSTOM"),
                new SubMenuInfo(42, 8, "RIFT"),
                new SubMenuInfo(43, 8, "CUSTOM GAMEROOM")
            };
            return source;
        }
    }
}
