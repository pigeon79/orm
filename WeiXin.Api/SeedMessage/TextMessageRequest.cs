﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;
using Qhyhgf.WeiXin.Qy.Api.Request;
using Qhyhgf.WeiXin.Qy.Api.Attribute;

namespace Qhyhgf.WeiXin.Qy.Api.SeedMessage
{
    /// <summary>
    /// 发送文本消息
    /// </summary>
    [HttpMethod(Method = HttpVerb.Post, Url = "https://qyapi.weixin.qq.com/cgi-bin/message/send", Name = "主动发送消息", IsToken = true, Serialize = SerializeVerb.Json)]
    public class TextMessageRequest : SendMessageRequest
    {
        public TextMessageRequest()
        {
            MsgType = Domain.MessageType.Text;
            Safe = "0";
            Text = new TextEntity();
        }
        /// <summary>
        /// 内容
        /// </summary>
        [DataMember(Name = "text")]
        public TextEntity Text { get; set; }
        /// <summary>
        /// 表示是否是保密消息，0表示否，1表示是，默认0
        /// </summary>
        [DataMember(Name = "safe")]
        public string Safe { get; set; }
    }
}
