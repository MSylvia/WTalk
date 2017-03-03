﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTalk.Desktop.Model
{
    public class Participant
    {
        private WTalk.Core.ProtoJson.Schema.ConversationParticipantData _conversationParticipantData;
        internal Participant(WTalk.Core.ProtoJson.Schema.ConversationParticipantData conversationParticipantData)
        {
            // TODO: Complete member initialization
            _conversationParticipantData = conversationParticipantData;
        }


        public string DisplayName { get { return _conversationParticipantData.fallback_name; } }
        public string Id { get { return _conversationParticipantData.id.gaia_id; } }
    }
}
