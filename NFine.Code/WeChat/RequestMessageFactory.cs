﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace NFine.Code.WeChat
{
    public static class RequestMessageFactory
    {
        //<?xml version="1.0" encoding="utf-8"?>
        //<xml>
        //  <ToUserName><![CDATA[gh_a96a4a619366]]></ToUserName>
        //  <FromUserName><![CDATA[olPjZjsXuQPJoV0HlruZkNzKc91E]]></FromUserName>
        //  <CreateTime>1357986928</CreateTime>
        //  <MsgType><![CDATA[text]]></MsgType>
        //  <Content><![CDATA[中文]]></Content>
        //  <MsgId>5832509444155992350</MsgId>
        //</xml>

        /// <summary>
        /// 获取XDocument转换后的IRequestMessageBase实例。
        /// 如果MsgType不存在，抛出UnknownRequestMsgTypeException异常
        /// </summary>
        /// <returns></returns>
        public static IRequestMessageBase GetRequestEntity(XDocument doc)
        {
            RequestMessageBase requestMessage = null;
            RequestMsgType msgType;

            try
            {
                msgType = GetRequestMsgType(doc);
                switch (msgType)
                {
                    case RequestMsgType.Text:
                        requestMessage = new RequestMessageText();
                        break;
                    case RequestMsgType.Location:
                        requestMessage = new RequestMessageLocation();
                        break;
                    case RequestMsgType.Image:
                        requestMessage = new RequestMessageImage();
                        break;
                    case RequestMsgType.Voice:
                        requestMessage = new RequestMessageVoice();
                        break;
                    case RequestMsgType.Video:
                        requestMessage = new RequestMessageVideo();
                        break;
                    case RequestMsgType.Link:
                        requestMessage = new RequestMessageLink();
                        break;
                    case RequestMsgType.ShortVideo:
                        requestMessage = new RequestMessageShortVideo();
                        break;
                    case RequestMsgType.Event:
                        //判断Event类型
                        switch (doc.Root.Element("Event").Value.ToUpper())
                        {
                            case "ENTER"://进入会话
                                requestMessage = new RequestMessageEvent_Enter();
                                break;
                            case "LOCATION"://地理位置
                                requestMessage = new RequestMessageEvent_Location();
                                break;
                            case "SUBSCRIBE"://订阅（关注）
                                requestMessage = new RequestMessageEvent_Subscribe();
                                break;
                            case "UNSUBSCRIBE"://取消订阅（关注）
                                requestMessage = new RequestMessageEvent_Unsubscribe();
                                break;
                            case "CLICK"://菜单点击
                                requestMessage = new RequestMessageEvent_Click();
                                break;
                            case "SCAN"://二维码扫描
                                requestMessage = new RequestMessageEvent_Scan();
                                break;
                            case "VIEW"://URL跳转
                                requestMessage = new RequestMessageEvent_View();
                                break;
                            case "MASSSENDJOBFINISH":
                                requestMessage = new RequestMessageEvent_MassSendJobFinish();
                                break;
                            case "TEMPLATESENDJOBFINISH"://模板信息
                                requestMessage = new RequestMessageEvent_TemplateSendJobFinish();
                                break;
                            case "SCANCODE_PUSH"://扫码推事件(scancode_push)
                                requestMessage = new RequestMessageEvent_Scancode_Push();
                                break;
                            case "SCANCODE_WAITMSG"://扫码推事件且弹出“消息接收中”提示框(scancode_waitmsg)
                                requestMessage = new RequestMessageEvent_Scancode_Waitmsg();
                                break;
                            case "PIC_SYSPHOTO"://弹出系统拍照发图(pic_sysphoto)
                                requestMessage = new RequestMessageEvent_Pic_Sysphoto();
                                break;
                            case "PIC_PHOTO_OR_ALBUM"://弹出拍照或者相册发图（pic_photo_or_album）
                                requestMessage = new RequestMessageEvent_Pic_Photo_Or_Album();
                                break;
                            case "PIC_WEIXIN"://弹出微信相册发图器(pic_weixin)
                                requestMessage = new RequestMessageEvent_Pic_Weixin();
                                break;
                            case "LOCATION_SELECT"://弹出地理位置选择器（location_select）
                                requestMessage = new RequestMessageEvent_Location_Select();
                                break;
                            case "CARD_PASS_CHECK"://卡券通过审核
                                requestMessage = new RequestMessageEvent_Card_Pass_Check();
                                break;
                            case "CARD_NOT_PASS_CHECK"://卡券未通过审核
                                requestMessage = new RequestMessageEvent_Card_Not_Pass_Check();
                                break;
                            case "USER_GET_CARD"://领取卡券
                                requestMessage = new RequestMessageEvent_User_Get_Card();
                                break;
                            case "USER_DEL_CARD"://删除卡券
                                requestMessage = new RequestMessageEvent_User_Del_Card();
                                break;
                            case "KF_CREATE_SESSION"://多客服接入会话
                                requestMessage = new RequestMessageEvent_Kf_Create_Session();
                                break;
                            case "KF_CLOSE_SESSION"://多客服关闭会话
                                requestMessage = new RequestMessageEvent_Kf_Close_Session();
                                break;
                            case "KF_SWITCH_SESSION"://多客服转接会话
                                requestMessage = new RequestMessageEvent_Kf_Switch_Session();
                                break;
                            case "POI_CHECK_NOTIFY"://审核结果事件推送
                                requestMessage = new RequestMessageEvent_Poi_Check_Notify();
                                break;
                            case "WIFICONNECTED"://Wi-Fi连网成功事件
                                requestMessage = new RequestMessageEvent_WifiConnected();
                                break;
                            case "USER_CONSUME_CARD"://卡券核销
                                requestMessage = new RequestMessageEvent_User_Consume_Card();
                                break;
                            case "USER_ENTER_SESSION_FROM_CARD"://从卡券进入公众号会话
                                requestMessage = new RequestMessageEvent_User_Enter_Session_From_Card();
                                break;
                            case "USER_VIEW_CARD"://进入会员卡
                                requestMessage = new RequestMessageEvent_User_View_Card();
                                break;
                            default://其他意外类型（也可以选择抛出异常）
                                requestMessage = new RequestMessageEventBase();
                                break;
                        }
                        break;
                    default:
                        throw new ApplicationException(string.Format("MsgType：{0} 在RequestMessageFactory中没有对应的处理程序！", msgType), new ArgumentOutOfRangeException());//为了能够对类型变动最大程度容错（如微信目前还可以对公众账号suscribe等未知类型，但API没有开放），建议在使用的时候catch这个异常
                }
                EntityHelper.FillEntityWithXml(requestMessage, doc);
            }
            catch (ArgumentException ex)
            {
                throw new ApplicationException(string.Format("RequestMessage转换出错！可能是MsgType不存在！，XML：{0}", doc.ToString()), ex);
            }
            return requestMessage;
        }


        /// <summary>
        /// 获取XDocument转换后的IRequestMessageBase实例。
        /// 如果MsgType不存在，抛出UnknownRequestMsgTypeException异常
        /// </summary>
        /// <returns></returns>
        public static IRequestMessageBase GetRequestEntity(string xml)
        {
            return GetRequestEntity(XDocument.Parse(xml));
        }


        /// <summary>
        /// 获取XDocument转换后的IRequestMessageBase实例。
        /// 如果MsgType不存在，抛出UnknownRequestMsgTypeException异常
        /// </summary>
        /// <param name="stream">如Request.InputStream</param>
        /// <returns></returns>
        public static IRequestMessageBase GetRequestEntity(Stream stream)
        {
            using (XmlReader xr = XmlReader.Create(stream))
            {
                var doc = XDocument.Load(xr);
                return GetRequestEntity(doc);
            }
        }
        /// <summary>
        /// 根据xml信息，返回RequestMsgType
        /// </summary>
        /// <returns></returns>
        public static RequestMsgType GetRequestMsgType(XDocument doc)
        {
            return (RequestMsgType)Enum.Parse(typeof(RequestMsgType), doc.Root.Element("MsgType").Value, true);
        }
    }
    public interface IRequestMessageBase : IMessageBase
    {
        RequestMsgType MsgType { get; }
        string Encrypt { get; set; }
        long MsgId { get; set; }
    }

    /// <summary>
    /// 接收到请求的消息
    /// </summary>
    public class RequestMessageBase :MessageBase, IRequestMessageBase
    {
        public virtual RequestMsgType MsgType
        {
            get { return RequestMsgType.Text; }
        }

        public string Encrypt { get; set; }

        public RequestMessageBase()
        {

        }

        public long MsgId { get; set; }
    }
    public interface IMessageBase
    {
        string ToUserName { get; set; }
        string FromUserName { get; set; }
        DateTime CreateTime { get; set; }
    }

    /// <summary>
    /// 所有Request和Response消息的基类
    /// </summary>
    public class MessageBase : IMessageBase
    {
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
