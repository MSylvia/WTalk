﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTalk
{
    internal static class HangoutUri
    {

#if V1
        public const string ORIGIN_URL = "https://talkgadget.google.com";
        public const string PVT_TOKEN_URL = "https://talkgadget.google.com/talkgadget/_/extension-start";
        public const string CHAT_INIT_URL = "https://talkgadget.google.com/u/0/talkgadget/_/chat";
#else
        public const string ORIGIN_URL = "https://hangouts.google.com";
        public const string PVT_TOKEN_URL = "https://hangouts.google.com/webchat/extension-start";
        public const string CHAT_INIT_URL = "https://hangouts.google.com/webchat/load";
#endif
        
        public const string IMAGE_UPLOAD_URL = "http://docs.google.com/upload/photos/resumable";
        public const string CHANNEL_URL = "https://0.client-channel.google.com/client-channel/";
        public const string CHAT_SERVER_URL = "https://clients6.google.com/chat/v1/";

        public const string COOKIE_URI = "https://google.com/";





    }
}
