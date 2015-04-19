﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySteamPlay.Models
{
    public class Tag
    {
        public int tagID { get; set; }      // should be unique identifier for each tag
        public string tag { get; set; }     // a description for a game, e.g. multiplayer, the genre, etc.
    }
}