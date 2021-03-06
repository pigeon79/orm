﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Helpers;
namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 被动响应image消息
    /// </summary>
    [Serializable]
    [XmlRoot("xml")]
    public class RequestImage : BaseMessage
    {
        public RequestImage()
        {
            //消息类型
            MsgType = new CDATA<MessageType>(MessageType.Image);
            //消息发送时间
            CreateTime = DateTime.Now.ConvertToTimeStamp();
            Image = new MediaEntity();
        }
        /// <summary>
        /// 文本消息内容
        /// </summary>
        [XmlElement("Image")]
        public MediaEntity Image { get; set; }
    }
}
