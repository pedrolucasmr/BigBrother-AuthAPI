﻿namespace AuthApiPoc.Models
{
    public class Password
    {
        public string EncryptedPassword { get; set; }
        public string Salt { get; set; }
    }
}